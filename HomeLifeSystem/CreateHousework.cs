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
    public partial class CreateHousework : UserControl
    {
        List<Chore> chores;
        List<Object> choresEvent;
        List<Housework> houseworks;
        MainScreen mainScreen;

        Chore chosenChore;
        String chosenChoreName;
        ListBox chosenChoreListBox;
        Chore showChore;
        String showChoreName;
        ListBox showChoreListBox;
        List<Object> dontDoItHousework;




        public CreateHousework(MainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            this.chores = mainScreen.home.Chores;
            this.choresEvent = mainScreen.home.Calendar.GetOccasionsByType(typeof(Housework));
            this.houseworks = mainScreen.home.Houseworks;
            FillListBoxes();
            ClearShowBox();
            ClearChosenChore();
            Coloring();
        }

        private void Coloring()
        {
            listBox_ChoreEvent.BackColor = GlobalColorConstants.mainListBoxColor;
            listBox_Chores.BackColor = GlobalColorConstants.mainListBoxColor;
            listBox_Today.BackColor = GlobalColorConstants.minorListBoxColor;
            listBox_TodayEvent.BackColor = GlobalColorConstants.minorListBoxColor;

            groupBox_ChooseChore.BackColor = GlobalColorConstants.mainGroupBoxColor;
            groupBox_Chosen.BackColor = GlobalColorConstants.minorGroupBoxColor;

            textBox_Question1.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Question2.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Question3.BackColor = GlobalColorConstants.minorTextBoxInnerColor;

            button_Cancel.BackColor = GlobalColorConstants.minorButtonColor;
            button_Cancel.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            button_Cancel.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

            button_ChooseChore.BackColor = GlobalColorConstants.minorButtonColor;
            button_ChooseChore.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            button_ChooseChore.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

            button_DoIt.BackColor = GlobalColorConstants.minorButtonColor;
            button_DoIt.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            button_DoIt.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

            button_DontDoIt.BackColor = GlobalColorConstants.minorButtonColor;
            button_DontDoIt.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            button_DontDoIt.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

        }

        public void FillListBoxes()
        {
            listBox_ChoreEvent.Items.Clear();
            listBox_Chores.Items.Clear();
            listBox_Today.Items.Clear();
            listBox_TodayEvent.Items.Clear();
            DateTime dateTime = DateTime.Now;
            foreach (Chore chore in chores)
            {
                bool isToday = false;
                var isNumeric = int.TryParse(chore.Frequency, out int n);
                if (chore.Frequency == "D")
                {
                    isToday = true;
                }
                else if (isNumeric && n == dateTime.Day)
                {
                    isToday = true;
                }
                else if (chore.Frequency.Contains(dateTime.DayOfWeek.ToString().Substring(0, 2)))
                {
                    isToday = true;
                }
                if (isToday)
                {
                    List<List<object>> todayList = mainScreen.home.Calendar.GetDaysOccasions(dateTime, typeof(Housework));
                    bool skip = false;
                    foreach (List<Object> occasion in todayList)
                    {
                        Housework housework = (Housework)occasion[0];
                        if (housework.Name == chore.Name)
                        {
                            var startTime = ((DateTime)occasion[1]).ToString("HH:mm");
                            var endDate = ((DateTime)occasion[2]).ToString("HH:mm");
                            listBox_TodayEvent.Items.Add(chore.Name + " : (" + startTime + " > " + endDate + ")");
                            skip = true;
                            break;
                        }
                    }
                    if (!skip)
                        listBox_Today.Items.Add(chore.Name);

                }
            }


            for (int i = 1; i < 31; i++)
            {
                DateTime dateTime2 = dateTime.AddDays(i);
                foreach (Chore chore in chores)
                {
                    var isNumeric2 = int.TryParse(chore.Frequency, out int n2);
                    bool isToday = false;
                    if (chore.Frequency == "D")
                    {
                        isToday = true;
                    }
                    else if (isNumeric2 && n2 == dateTime2.Day)
                    {
                        isToday = true;
                    }
                    else if (chore.Frequency.Contains(dateTime2.DayOfWeek.ToString().Substring(0, 2)))
                    {
                        isToday = true;
                    }
                    if (isToday)
                    {
                        List<List<object>> todayList = mainScreen.home.Calendar.GetDaysOccasions(dateTime2, typeof(Housework));
                        bool skip = false;
                        foreach (List<Object> occasion in todayList)
                        {
                            Housework housework = (Housework)occasion[0];
                            if (housework.Name == chore.Name)
                            {
                                listBox_ChoreEvent.Items.Add(chore.Name + " : [" + dateTime2.DayOfWeek + " | " + dateTime2.ToShortDateString() + "]");
                                skip = true;
                                break;
                            }
                        }
                        if (!skip)
                            listBox_Chores.Items.Add(chore.Name + " : [" + dateTime2.DayOfWeek + " | " + dateTime2.ToShortDateString() + "]");

                    }
                }
            }
        }

        private void ShowHouseworkDescription(object sender, EventArgs e)
        {
            ClearShowBox();
            if (((ListBox)sender).SelectedIndex == -1) return;
            ListBox listbox = (ListBox)sender;
            int index = listbox.SelectedIndex;
             if (listBox_Today != listbox)
             {
                 listBox_Today.SelectedIndex = -1;
             }
             if (listBox_TodayEvent != listbox)
             {
                 listBox_TodayEvent.SelectedIndex = -1;
             }
             if (listBox_ChoreEvent != listbox)
             {
                 listBox_ChoreEvent.SelectedIndex = -1;
             }
             if (listBox_Chores != listbox)
             {
                 listBox_Chores.SelectedIndex = -1;
             }
            if (listbox == null || listbox.SelectedIndex == -1) return;

            string listBoxName = listbox.SelectedItem.ToString();
            if (listBoxName.IndexOf(':') != -1)
                listBoxName = listBoxName.Substring(0, (listBoxName.IndexOf(':') - 1));

            foreach (Chore chore in chores)
            {
                if (chore.Name == listBoxName)
                {
                    showChore = chore;
                    showChoreName = listbox.SelectedItem.ToString();
                    showChoreListBox = (ListBox)sender;

                    label_ShowName.Text = "Name: " + chore.Name;
                    label_ShowDescription.Text = "Description: " + chore.Description;
                    if(chore.Questions.Count > 0)
                        label_ShowQuestion1.Text = "Question 1: " + chore.Questions[0].Substring(1);
                    if(chore.Questions.Count > 1)
                    label_ShowQuestion2.Text = "Question 2: " + chore.Questions[1].Substring(1);
                    if (chore.Questions.Count > 2)
                        label_ShowQuestion3.Text = "Question 3: " + chore.Questions[2].Substring(1);
                    label_ShowType.Text = "Type: " + chore.Type;


                    string frequency = "";
                    var isNumeric = int.TryParse(chore.Frequency, out int n);
                    if (chore.Frequency == "D")
                    {
                        frequency = "Daily";
                    }
                    else if (isNumeric)
                    {
                        frequency = "Every " + n + ". day of the month";
                    }
                    else
                    {
                        frequency = "Every";
                        if (chore.Frequency.Contains("Mo"))
                            frequency += " Monday,";
                        if (chore.Frequency.Contains("Tu"))
                            frequency += " Tuesday,";
                        if (chore.Frequency.Contains("We"))
                            frequency += " Wednesday,";
                        if (chore.Frequency.Contains("Th"))
                            frequency += " Thursday,";
                        if (chore.Frequency.Contains("Fr"))
                            frequency += " Friday,";
                        if (chore.Frequency.Contains("Sa"))
                            frequency += " Saturday,";
                        if (chore.Frequency.Contains("Su"))
                            frequency += " Sunday,";
                    }
                    label_ShowFrequency.Text = "Frequency: " + frequency;

                    button_ChooseChore.Enabled = true;
                    button_DontDoIt.Enabled = false;
                    dontDoItHousework = null;

                }
            }

            if(listbox == listBox_ChoreEvent || listbox == listBox_TodayEvent)
            {
                button_ChooseChore.Enabled = false;
                int startpos;
                int length;
                DateTime dateTime;
                if (listbox == listBox_ChoreEvent)
                {
                    startpos = showChoreName.IndexOf("|") + 1;
                    length = showChoreName.IndexOf("]") - startpos;
                    dateTime = DateTime.Parse(showChoreName.Substring(startpos, length));
                }
                else
                {
                    dateTime = DateTime.Now;
                }

                List<List<object>> list = mainScreen.home.Calendar.GetDaysOccasions(dateTime, typeof(Housework));
                foreach (List<Object> occasion in list)
                {
                    Housework housework = (Housework)occasion[0];
                    if (housework.Name == listBoxName)
                    {
                        label_ShowDateTime.Text = "Date" + ((DateTime)occasion[1]).ToString(" dddd, d/MM/yy \n HH:mm - ") +((DateTime)occasion[2]).ToString(" HH:mm");
                        var nickname = ((Person)occasion[3]).Nickname;
                        label_ShowPerson.Text = "Person: " + nickname;
                        if (nickname == mainScreen.User.Nickname)
                        {
                            label_ShowPerson.Text += " (You)";
                            button_ChooseChore.Enabled = true;
                            button_DontDoIt.Enabled = true;
                            dontDoItHousework = occasion;

                        }
                        if(housework.Answers.Count > 0 )
                            label_ShowAnswer1.Text = housework.Answers[0];
                        if (housework.Answers.Count > 1)
                            label_ShowAnswer2.Text = housework.Answers[1];
                        if (housework.Answers.Count > 2)
                            label_ShowAnswer3.Text = housework.Answers[2];
                    }
                }
            }
            

        }

        private void button_ChooseChore_Click(object sender, EventArgs e)
        {
            label_Finished.Hide();
            if (showChoreName.IndexOf(":") == -1)
            {
                radioButton_Now.Checked = true;
                radioButton_ChooseTime.Enabled = true;
                radioButton_Now.Enabled = true;

                dateTimePicker_ChooseTime.Value = DateTime.Now;
                dateTimePicker_ChooseTime.MinDate = DateTime.Now;
            }
            else
            {
                radioButton_ChooseTime.Checked = true;
                radioButton_ChooseTime.Enabled = true;
                radioButton_Now.Enabled = false;

                dateTimePicker_ChooseTime.Value = DateTime.Now;
                dateTimePicker_ChooseTime.MinDate = DateTime.Now.Date;
            }
            if (showChore.Questions.Count > 0)
            {
                textBox_Question1.ReadOnly = false;
                label_Question1.Text = showChore.Questions[0].Substring(1);
                if(showChore.Questions[0].ElementAt(0) == '1')
                {
                    label_Question1.Text += " [Optional]";
                }
                else
                    label_Question1.Text += " [Required]";
            }
            else
            {
                label_Question1.Text = "Question 1";
                label_Question2.Text = "Question 2";
                label_Question3.Text = "Question 3";
                textBox_Question1.ReadOnly = true;
                textBox_Question2.ReadOnly = true;
                textBox_Question3.ReadOnly = true;
            }
            
            if (showChore.Questions.Count > 1)
            {
                textBox_Question2.ReadOnly = false;
                label_Question2.Text = showChore.Questions[1].Substring(1);
                if (showChore.Questions[1].ElementAt(0) == '1')
                {
                    label_Question2.Text += " [Optional]";
                }
                else
                    label_Question2.Text += " [Required]";
            }
            else
            {
                label_Question2.Text = "Question 2";
                label_Question3.Text = "Question 3";
                textBox_Question2.ReadOnly = true;
                textBox_Question3.ReadOnly = true;
            }
            if (showChore.Questions.Count > 2)
            {
                textBox_Question3.ReadOnly = false;
                label_Question3.Text = showChore.Questions[2].Substring(1);
                if (showChore.Questions[2].ElementAt(0) == '1')
                {
                    label_Question3.Text += " [Optional]";
                }
                else
                    label_Question3.Text += " [Required]";
            }
            else
            {
                label_Question3.Text = "Question 3";
                textBox_Question3.ReadOnly = true;
            }

            label_ChosenDescription.Text = label_ShowDescription.Text;
            label_ChosenName.Text = label_ShowName.Text;
            label_ChosenType.Text = label_ShowType.Text;

            chosenChore = showChore;
            chosenChoreName = showChoreName;
            chosenChoreListBox = showChoreListBox;

            

            button_DoIt.Enabled = true;

        }

        private void button_DoIt_Click(object sender, EventArgs e)
        {
            
            label_DoItError.Text = "";
            label_DoItError.Visible = false;
            label_Finished.Hide();

            if (chosenChore == null)
            {
                label_DoItError.Visible = true;
                label_DoItError.Text = "You have not chosen a chore!";
                return;
            }

            List<string> answers = new List<string>();

            if (label_Question1.Text.EndsWith("[Required]"))
            {
                if(textBox_Question1.Text.Trim() == "")
                {
                    label_DoItError.Visible = true;
                    label_DoItError.Text = "The Answer can't be empty!";
                    return;
                }
                answers.Add(textBox_Question1.Text);
            }
            else if (label_Question1.Text.EndsWith("[Optional]"))
            {
                if (textBox_Question1.Text.Trim() == "")
                {
                    textBox_Question1.Text = "Not Answered";
                }
                answers.Add(textBox_Question1.Text);
            }
            if (label_Question2.Text.EndsWith("[Required]"))
            {
                if (textBox_Question2.Text.Trim() == "")
                {
                    label_DoItError.Visible = true;
                    label_DoItError.Text = "The Answer can't be empty!";
                    return;
                }
                answers.Add(textBox_Question2.Text);
            }
            else if (label_Question2.Text.EndsWith("[Optional]"))
            {
                if (textBox_Question2.Text.Trim() == "")
                {
                    textBox_Question2.Text = "Not Answered";
                }
                answers.Add(textBox_Question2.Text);
            }
            if (label_Question3.Text.EndsWith("[Required]"))
            {
                if (textBox_Question3.Text.Trim() == "")
                {
                    label_DoItError.Visible = true;
                    label_DoItError.Text = "The Answer can't be empty!";
                    return;
                }
                answers.Add(textBox_Question3.Text);
            }
            else if (label_Question3.Text.EndsWith("[Optional]"))
            {
                if (textBox_Question3.Text.Trim() == "")
                {
                    textBox_Question3.Text = "Not Answered";
                }
                answers.Add(textBox_Question3.Text);
            }

            if (dateTimePicker_Duration.Value.TimeOfDay.TotalMinutes == 0)
            {
                label_DoItError.Visible = true;
                label_DoItError.Text = "The duration can't be zero!";
                return;
            }
            

            Housework housework = new Housework(answers,chosenChore);
            housework.AddToDatabase();
            mainScreen.home.Houseworks.Add(housework);
            label_Finished.Text = "Your housework has been added!";

            int startpos = chosenChoreName.IndexOf("|");

            if(startpos == -1)
            {
                chosenChoreListBox.Items.Remove(chosenChoreName);
                DateTime startDateTime = DateTime.Now.Date;
                startDateTime = startDateTime.AddMinutes(dateTimePicker_ChooseTime.Value.TimeOfDay.TotalMinutes);
                if (radioButton_Now.Checked) startDateTime = DateTime.Now;               
                DateTime endDateTime = startDateTime.AddMinutes(dateTimePicker_Duration.Value.TimeOfDay.TotalMinutes);
                mainScreen.home.Calendar.AddOccasions(housework, startDateTime, endDateTime, mainScreen.User);

                listBox_TodayEvent.Items.Add(housework.Name + " : (" + startDateTime.ToString("HH:mm") + " > " + endDateTime.ToString("HH:mm") + ")");

            }
            else 
            {
                startpos++;
                chosenChoreListBox.Items.Remove(chosenChoreName);
                int length = chosenChoreName.IndexOf("]") - startpos;
                DateTime startDateTime = DateTime.Parse(chosenChoreName.Substring(startpos, length));
                startDateTime = startDateTime.AddMinutes(dateTimePicker_ChooseTime.Value.TimeOfDay.TotalMinutes);
                DateTime endDateTime = startDateTime.AddMinutes(dateTimePicker_Duration.Value.TimeOfDay.TotalMinutes);
                mainScreen.home.Calendar.AddOccasions(housework, startDateTime, endDateTime, mainScreen.User);

                listBox_ChoreEvent.Items.Add(housework.Name + " : [" + startDateTime.DayOfWeek + " | " + startDateTime.ToShortDateString() + "]");
            }

            ClearChosenChore();
        }

        private void ClearChosenChore()
        {
            label_ChosenDescription.MaximumSize = new Size((int)(groupBox_Chosen.ClientSize.Width * 0.90), 0);
            label_ChosenDescription.Text = "Description: ";
            label_ChosenName.Text = "Name: ";
            label_ChosenType.Text = "Type: ";

            label_Question1.Text = "Question 1";
            label_Question2.Text = "Question 2";
            label_Question3.Text = "Question 3";
            textBox_Question1.Text = "";
            textBox_Question2.Text = "";
            textBox_Question3.Text = "";
            textBox_Question1.ReadOnly = true;
            textBox_Question2.ReadOnly = true;
            textBox_Question3.ReadOnly = true;

            radioButton_Now.Checked = true;
            radioButton_Now.Enabled = true;

            dateTimePicker_Duration.Value = new DateTime(2000, 1, 1, 1, 30, 0);
            dateTimePicker_ChooseTime.Value = DateTime.Now;

            button_DoIt.Enabled = false;
        }

        private void ClearShowBox()
        {
            label_ShowDescription.MaximumSize = new Size((int)(groupBox_ChooseChore.ClientSize.Width*0.90), 0);
            label_ShowFrequency.MaximumSize = new Size((int)(groupBox_ChooseChore.ClientSize.Width * 0.90), 0);
            label_ShowAnswer1.MaximumSize = new Size((int)(groupBox_ChooseChore.ClientSize.Width * 0.90), 0);
            label_ShowAnswer2.MaximumSize = new Size((int)(groupBox_ChooseChore.ClientSize.Width * 0.90), 0);
            label_ShowAnswer3.MaximumSize = new Size((int)(groupBox_ChooseChore.ClientSize.Width * 0.90), 0);
            string nan = "";
            label_ShowName.Text = "Name: " + nan;
            label_ShowType.Text = "Type: ";
            label_ShowDescription.Text = "Description: " + nan;
            label_ShowFrequency.Text = "Frequency: " + nan;
            label_ShowQuestion1.Text = "Question 1: " + nan;
            label_ShowQuestion2.Text = "Question 3: " + nan;
            label_ShowQuestion3.Text = "Question 2: " + nan;
            label_ShowAnswer1.Text = "Answer 1: " + nan;
            label_ShowAnswer2.Text = "Answer 2: " + nan;
            label_ShowAnswer3.Text = "Answer 3: " + nan;
            label_ShowDateTime.Text = "Date: " + nan;
            label_ShowPerson.Text = "Person: " + nan;

        }

       

        private void dateTimePicker_Duration_ValueChanged(object sender, EventArgs e)
        {
            DateTime duration = dateTimePicker_Duration.Value;
            if(duration.TimeOfDay.TotalMinutes < 5)
            {
                dateTimePicker_Duration.Value = new DateTime(2000, 1, 1, 0, 5, 0);
            }
            else if(duration.TimeOfDay.TotalHours > 12)
            {
                dateTimePicker_Duration.Value = new DateTime(2000, 1, 1, 12, 0, 0);
            }
        }

        private void dateTimePicker_ChooseTime_ValueChanged(object sender, EventArgs e)
        {
            DateTime duration = dateTimePicker_ChooseTime.Value;
            if (duration.Hour == 23 && duration.Minute > 40)
            {
                DateTime max = new DateTime(2000, 1, 1, 23, 40, 0);
                if (DateTime.Now.Hour == 23 && DateTime.Now.Minute > max.Minute)
                    dateTimePicker_ChooseTime.Value = DateTime.Now;
                else
                    dateTimePicker_ChooseTime.Value = max;
            }

        }

        private void button_DontDoIt_Click(object sender, EventArgs e)
        {
            if(dontDoItHousework != null)
            {
                Housework housework = (Housework)dontDoItHousework[0];
                housework.RemoveFromDatabase();
                mainScreen.home.Calendar.DeleteOccasion(dontDoItHousework);
                FillListBoxes();
                ClearShowBox();
                dontDoItHousework = null;
            }
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            label_Finished.Hide();
            ClearChosenChore();
        }

        private void CreateHousework_VisibleChanged(object sender, EventArgs e)
        {
            label_Finished.Hide();
        }
    }
}
