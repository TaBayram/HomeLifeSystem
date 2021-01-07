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
    public partial class CreateEvent : UserControl
    {

        MainScreen mainScreen;

        public CreateEvent(MainScreen mainScreen)
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
            comboBox_Type.BackColor = GlobalColorConstants.minorComboColor;

            dateTimePicker_EndingTime.CalendarTitleBackColor = GlobalColorConstants.minorTextBoxInnerColor;
            dateTimePicker_StartingTime.CalendarTitleBackColor = GlobalColorConstants.minorTextBoxInnerColor;


        }


        private void button_CreateEvent_Click(object sender, EventArgs e)
        {
            label_Finished.Hide();
            label_Error.Text = "";
            label_Error.Hide();

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
            if (comboBox_Type.SelectedIndex == -1)
            {
                label_Error.Text = "Type can't be empty";
                label_Error.Show();
                return;
            }
            if (comboBox_Type.SelectedIndex == -1)
            {
                label_Error.Text = "Type can't be empty";
                label_Error.Show();
                return;
            }

            string name = textBox_Name.Text;
            string description = textBox_Description.Text;
            string type = comboBox_Type.SelectedItem.ToString();
            DateTime startDateTime = dateTimePicker_StartingTime.Value;
            DateTime endDateTime = dateTimePicker_EndingTime.Value;


            Event @event = new Event(name, type, description, mainScreen.home.ID);
            mainScreen.home.Calendar.AddOccasions(@event, startDateTime, endDateTime, mainScreen.User);


            ClearBoxes();
            label_Finished.Text = "Event Created Successfully!";
            label_Finished.Show();




        }

        private void dateTimePicker_StartingTime_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_StartingTime.Value.TimeOfDay.TotalMinutes > 24 * 60 - 30)
            {
                DateTime minDate = DateTime.Now.Date.AddDays(1).AddMinutes(-30);
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
            dateTimePicker_EndingTime.MinDate = dateTimePicker_StartingTime.Value.AddMinutes(30);

        }

        private void FindStartingTime()
        {
            if (DateTime.Now.TimeOfDay.TotalMinutes > 24 * 60 - 30)
                dateTimePicker_StartingTime.MinDate = DateTime.Now.Date.AddDays(1);
            else
                dateTimePicker_StartingTime.MinDate = DateTime.Now;



            dateTimePicker_EndingTime.MinDate = DateTime.Now.AddMinutes(30);
        }

        private void ClearBoxes()
        {
            Control control = groupBox_Event;
            foreach (TextBox textBox in control.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in control.Controls.OfType<ComboBox>())
            {
                comboBox.SelectedIndex = -1;
            }

            FindStartingTime();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ClearBoxes();
            label_Finished.Hide();
        }

        private void CreateEvent_VisibleChanged(object sender, EventArgs e)
        {
            label_Finished.Hide();
        }
    }
}
