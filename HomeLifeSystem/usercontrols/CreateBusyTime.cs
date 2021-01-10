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
    public partial class CreateBusyTime : UserControl
    {

        MainScreen mainScreen;
        ViewList viewList;
        BusyTime busyTime;

        public CreateBusyTime(MainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            dateTimePicker_StartingTime.MinDate = DateTime.Now.Date;
            dateTimePicker_EndingTime.MinDate = DateTime.Now.AddDays(1).Date;
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

            checkedListBox_Frequency.BackColor = GlobalColorConstants.minorListBoxColor;


        }



        internal void EditMode(BusyTime busyTime, ViewList viewList)
        {
            this.viewList = viewList;
            this.busyTime = busyTime;
            textBox_Name.Text = busyTime.Name;
            comboBox_Type.SelectedItem = busyTime.Type;
            textBox_Description.Text = busyTime.Description;
            dateTimePicker_StartingTime.Value = (DateTime.Today + busyTime.StartTime);
            dateTimePicker_EndingTime.Value = (DateTime.Today.AddDays(1) + busyTime.EndTime);
            button2.Text = "Cancel";

            for (int i = 0; i <= (checkedListBox_Frequency.Items.Count - 1); i++)
            {
                if (busyTime.Frequency.Contains(checkedListBox_Frequency.Items[i].ToString().Substring(0, 2)))
                {
                    checkedListBox_Frequency.SetItemCheckState(i, CheckState.Checked);
                }
                else
                {
                    checkedListBox_Frequency.SetItemCheckState(i, CheckState.Unchecked);
                }
            }



            button1.Text = "Save Changes";

        }

        private void button_CreateBusyTime_Click(object sender, EventArgs e)
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
             if (comboBox_Type.SelectedIndex == -1)
             {
                 label_Error.Text = "Type can't be empty";
                 label_Error.Show();
                 return;
             }
             if (checkedListBox_Frequency.CheckedItems.Count == 0)
             {
                 label_Error.Text = "Frequency can't be empty";
                 label_Error.Show();
                 return;
             }
             if((dateTimePicker_EndingTime.Value.TimeOfDay - dateTimePicker_StartingTime.Value.TimeOfDay).TotalMinutes <= 0)
            {
                label_Error.Text = "Ending time can't be earlier than Starting time!";
                label_Error.Show();
                return;
            }

   
            string name = textBox_Name.Text;
            string description = textBox_Description.Text;
            string type = comboBox_Type.SelectedItem.ToString();
            TimeSpan startDateTime = dateTimePicker_StartingTime.Value.TimeOfDay;
            TimeSpan endDateTime = dateTimePicker_EndingTime.Value.TimeOfDay;
            string frequency = "";
            foreach (object item in checkedListBox_Frequency.CheckedItems)
            {
                frequency += item.ToString().Substring(0, 2);
            }

            if(busyTime == null)
            {
                BusyTime busyTime = new BusyTime(name, type,description,frequency, mainScreen.User.ID,startDateTime,endDateTime);
                mainScreen.User.BusyTimes.Add(busyTime);
                if(mainScreen.home != null)
                    mainScreen.home.BusyTimes.Add(busyTime);
                ClearBoxes();
                label_Finished.Text = "Busy Time Created Successfully!";
                
            }
            else
            {
                busyTime.Name = name;
                busyTime.Description = description;
                busyTime.Frequency = frequency;
                busyTime.Type = comboBox_Type.SelectedItem.ToString();
                busyTime.StartTime = startDateTime;
                busyTime.EndTime = endDateTime;


                Database.BusyTimeTableUpdate(busyTime);
                this.Parent.Controls.Remove(this);
                viewList.DrawObjects();

                label_Finished.Text = "Busy Time Updated Successfully!";

            }
            label_Finished.Show();



        }


        private void ClearBoxes()
        {
            Control control = groupBox_BusyTime;
            foreach (TextBox textBox in control.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in control.Controls.OfType<ComboBox>())
            {
                comboBox.SelectedIndex = -1;
            }

            for (int i = 0; i < checkedListBox_Frequency.Items.Count; i++)
                checkedListBox_Frequency.SetItemCheckState(i, (CheckState.Unchecked));

            dateTimePicker_StartingTime.Value = dateTimePicker_StartingTime.MinDate;
            dateTimePicker_EndingTime.Value = dateTimePicker_EndingTime.MinDate;


        }


        private void button2_Click(object sender, EventArgs e)
        {
            label_Finished.Hide();
            if(busyTime == null)
            {
                ClearBoxes();
            }
            else
            {
                this.Parent.Controls.Remove(this);
                viewList.DrawObjects();
            }
        }

        private void CreateBusyTime_VisibleChanged(object sender, EventArgs e)
        {
            label_Finished.Hide();
        }
    }
}
