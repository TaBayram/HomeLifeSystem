using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLifeSystem
{
    public partial class CreateRequest : UserControl
    {
        MainScreen mainScreen;
        public CreateRequest(MainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            FindStartingTime();
            Coloring();
        }

        private void Coloring()
        {
            this.BackColor = GlobalColorConstants.mainGroupBoxColor;

            this.button1.BackColor = GlobalColorConstants.minorButtonColor;
            this.button1.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            this.button1.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

            this.button2.BackColor = GlobalColorConstants.minorButtonColor;
            this.button2.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            this.button2.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

            textBox_Description.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Name.BackColor = GlobalColorConstants.minorTextBoxInnerColor;

            dateTimePicker_EndingTime.CalendarTitleBackColor = GlobalColorConstants.minorTextBoxInnerColor;
            dateTimePicker_StartingTime.CalendarTitleBackColor = GlobalColorConstants.minorTextBoxInnerColor;


        }

        private void button_CreateRequest_Click(object sender, EventArgs e)
        {
            label_Error.Text = "";
            label_Error.Hide();
            label_Finished.Hide();

            if (textBox_Name.Text == "" || textBox_Name.Text == null)
            {
                label_Error.Text = "Name can't be empty";
                label_Error.Show();
                return;
            }
            if (textBox_Description.Text == "" || textBox_Description.Text == null)
            {
                label_Error.Text = "Description can't be empty";
                label_Error.Show();
                return;
            }

            string name = textBox_Name.Text;
            string description = textBox_Description.Text;
            DateTime startDateTime = dateTimePicker_StartingTime.Value;
            DateTime endDateTime = dateTimePicker_EndingTime.Value;


            Request request = new Request(name,description,mainScreen.home.ID);
            mainScreen.home.Calendar.AddOccasions(request, startDateTime, endDateTime, mainScreen.User);

            ClearBoxes();
            label_Finished.Text = "Request Created Succesfully!";
            label_Finished.Show();


        }

        private void dateTimePicker_StartingTime_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_StartingTime.Value.TimeOfDay.TotalMinutes > 24 * 60 - 45)
            {
                DateTime minDate = DateTime.Now.Date.AddDays(1).AddMinutes(-16);
                if (DateTime.Now > minDate)
                {
                    dateTimePicker_StartingTime.Value = DateTime.Now.Date.AddDays(1);
                }
                else
                {
                    dateTimePicker_StartingTime.Value = minDate;
                }

            }

            dateTimePicker_EndingTime.MinDate = DateTime.Now;
            dateTimePicker_EndingTime.MaxDate = dateTimePicker_StartingTime.Value.Date.AddDays(1).AddMinutes(-1);
            dateTimePicker_EndingTime.MinDate = dateTimePicker_StartingTime.Value.AddMinutes(15);

        }

        private void FindStartingTime()
        {
            if (DateTime.Now.TimeOfDay.TotalMinutes > 24 * 60 - 45)
                dateTimePicker_StartingTime.MinDate = DateTime.Now.Date.AddDays(1);
            else
                dateTimePicker_StartingTime.MinDate = DateTime.Now;



            dateTimePicker_EndingTime.MinDate = DateTime.Now.AddMinutes(15);
        }


        private void ClearBoxes()
        {
            Control control = groupBox_CreateRequest;
            foreach (TextBox textBox in control.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }

            dateTimePicker_StartingTime.Value = dateTimePicker_StartingTime.MinDate;
            dateTimePicker_EndingTime.Value = dateTimePicker_EndingTime.MinDate;


        }




        private void button2_Click(object sender, EventArgs e)
        {
            label_Finished.Hide();
            ClearBoxes();
        }

        private void CreateRequest_VisibleChanged(object sender, EventArgs e)
        {
            label_Finished.Hide();
        }
    }
}
