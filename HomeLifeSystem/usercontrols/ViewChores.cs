using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace HomeLifeSystem
{
    public partial class ViewChores : UserControl
    {
        List<Chore> chores;
        MainScreen mainScreen;

        TextBox[] editedQuestions = new TextBox[3];
        RadioButton[] editedRadioButtonDisabled = new RadioButton[3];
        RadioButton[] editedRadioButtonOptional = new RadioButton[3];
        RadioButton[] editedRadioButtonRequired = new RadioButton[3];
        public ViewChores(MainScreen mainScreen)
        {
            InitializeComponent();

            this.mainScreen = mainScreen;
            this.chores = mainScreen.home.Chores;
            this.Dock = DockStyle.Fill;

            editedQuestions[0] = textBox_EditQuestion1;
            editedQuestions[1] = textBox_EditQuestion2;
            editedQuestions[2] = textBox_EditQuestion3;

            editedRadioButtonDisabled[0] = radioButton_EditQuestion1Disabled;
            editedRadioButtonDisabled[1] = radioButton_EditQuestion2Disabled;
            editedRadioButtonDisabled[2] = radioButton_EditQuestion3Disabled;

            editedRadioButtonOptional[0] = radioButton_EditQuestion1Optional;
            editedRadioButtonOptional[1] = radioButton_EditQuestion2Optional;
            editedRadioButtonOptional[2] = radioButton_EditQuestion3Optional;

            editedRadioButtonRequired[0] = radioButton_EditQuestion1Required;
            editedRadioButtonRequired[1] = radioButton_EditQuestion2Required;
            editedRadioButtonRequired[2] = radioButton_EditQuestion3Required;

            EnterChore();

            Coloring();
        }

        private void Coloring()
        {
            button_ApplyChanges.BackColor = GlobalColorConstants.minorButtonColor;
            button_ApplyChanges.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            button_ApplyChanges.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;

            button_CancelChanges.BackColor = GlobalColorConstants.minorButtonColor;
            button_CancelChanges.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            button_CancelChanges.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;

            button_DeleteChore.BackColor = GlobalColorConstants.minorButtonColor;
            button_DeleteChore.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            button_DeleteChore.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;

            btn_AddChore.BackColor = GlobalColorConstants.minorButtonColor;
            btn_AddChore.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            btn_AddChore.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;

            btn_EditChore.BackColor = GlobalColorConstants.minorButtonColor;
            btn_EditChore.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            btn_EditChore.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;

            comboBox_EditType.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            comboBox_Type.BackColor = GlobalColorConstants.minorTextBoxInnerColor;

            listBox_Chores.BackColor = GlobalColorConstants.minorTextBoxInnerColor;

            radioButton_Daily.BackColor = GlobalColorConstants.minorComboColor;
            radioButton_EditDaily.BackColor = GlobalColorConstants.minorComboColor;
            radioButton_EditMonthly.BackColor = GlobalColorConstants.minorComboColor;
            radioButton_EditWeekly.BackColor = GlobalColorConstants.minorComboColor;
            radioButton_Monthly.BackColor = GlobalColorConstants.minorComboColor;
            radioButton_Weekly.BackColor = GlobalColorConstants.minorComboColor;

            checkBox_EditFriday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_EditMonday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_EditSaturday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_EditSunday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_EditThursday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_EditTuesday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_EditWednesday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_Friday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_Monday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_Saturday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_Sunday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_Thursday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_Tuesday.BackColor = GlobalColorConstants.minorComboColor;
            checkBox_Wednesday.BackColor = GlobalColorConstants.minorComboColor;
            
            numericUpDown_EditMonthly.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            numericUpDown_Monthly.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Description.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_EditDescription.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_EditName.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_EditQuestion1.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_EditQuestion2.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_EditQuestion3.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Name.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Question1.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Question2.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Question3.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
           



        }

        private void EnterChore()
        {
            foreach (Chore chore in mainScreen.home.Chores)
            {
                listBox_Chores.Items.Add(chore.Name);
            }
        }

        private void QuestionRadioButtonChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            TextBox textBox = textBox_Question1;

            if(radioButton.Parent == groupBox_Q1)
            {
                textBox = textBox_Question1;
            }
            else if(radioButton.Parent == groupBox_Q2)
            {
                textBox = textBox_Question2;
            }
            else if(radioButton.Parent == groupBox_Q3)
            {
                textBox = textBox_Question3;
            }
            else if (radioButton.Parent == groupBox_EditQuestion1)
            {
                textBox = textBox_EditQuestion1;
            }
            else if (radioButton.Parent == groupBox_EditQuestion2)
            {
                textBox = textBox_EditQuestion2;
            }
            else if (radioButton.Parent == groupBox_EditQuestion3)
            {
                textBox = textBox_EditQuestion3;
            }
            if (radioButton.Text.EndsWith("Disabled"))
            {
                if (radioButton.Checked)
                {
                    textBox.ReadOnly = true;
                }
                else
                {
                    textBox.ReadOnly = false;
                }
            }

        }

        private void btn_AddChore_Click(object sender, EventArgs e)
        {
            lbl_AddChoreError.Visible = false;
            lbl_AddChoreError.Text = "";
            label_FinishedNew.Hide();

            
            if (comboBox_Type.SelectedIndex == -1)
            {
                lbl_AddChoreError.Visible = true;
                lbl_AddChoreError.Text = "Chore type can't be empty!";
                return;
            }
            if (textBox_Description.Text.Trim() == "")
            {
                lbl_AddChoreError.Visible = true;
                lbl_AddChoreError.Text = "Chore description can't be empty!";
                return;
            }

            if(radioButton_Question1Disabled.Checked == false && textBox_Question1.Text.Trim() == "")
            {
                lbl_AddChoreError.Visible = true;
                lbl_AddChoreError.Text = "Question 1 is empty! Either disable it or add a question.";
                return;
            }
            if (radioButton_Question2Disabled.Checked == false && textBox_Question2.Text.Trim() == "")
            {
                lbl_AddChoreError.Visible = true;
                lbl_AddChoreError.Text = "Question 2 is empty! Either disable it or add a question.";
                return;
            }
            if (radioButton_Question3Disabled.Checked == false && textBox_Question3.Text.Trim() == "")
            {
                lbl_AddChoreError.Visible = true;
                lbl_AddChoreError.Text = "Question 3 is empty! Either disable it or add a question.";
                return;
            }
            string name;
            string type = comboBox_Type.Text;
            if (textBox_Name.Text.Trim() != "")
            {
                if (IsTheNameUnique(textBox_Name.Text))
                    name = textBox_Name.Text;
                else
                {
                    lbl_AddChoreError.Visible = true;
                    lbl_AddChoreError.Text = "The name already exists!";
                    return;
                }
            }
            else
            {
                name = FindAvailableChoreName(type, 0);
            }


            List<string> questionList = new List<string>();

            if (radioButton_Question1Optional.Checked)
            {
                questionList.Add("1" + textBox_Question1.Text);
            }
            else if (radioButton_Question1Required.Checked)
            {
                questionList.Add("0" + textBox_Question1.Text);
            }
            if (radioButton_Question2Optional.Checked)
            {
                questionList.Add("1" + textBox_Question2.Text);
            }
            else if (radioButton_Question2Required.Checked)
            {
                questionList.Add("0" + textBox_Question2.Text);
            }
            if (radioButton_Question3Optional.Checked)
            {
                questionList.Add("1" + textBox_Question3.Text);
            }
            else if (radioButton_Question3Required.Checked)
            {
                questionList.Add("0" + textBox_Question3.Text);
            }

            string frequency = "";
            if (radioButton_Daily.Checked)
            {
                frequency = "D";
            }
            else if (radioButton_Monthly.Checked)
            {
                frequency = numericUpDown_Monthly.Value.ToString();
            }
            else if (radioButton_Weekly.Checked)
            {
                if (checkBox_Monday.Checked)
                    frequency += "Mo";
                if (checkBox_Tuesday.Checked)
                    frequency += "Tu";
                if (checkBox_Wednesday.Checked)
                    frequency += "We";
                if (checkBox_Thursday.Checked)
                    frequency += "Th";
                if (checkBox_Friday.Checked)
                    frequency += "Fr";
                if (checkBox_Saturday.Checked)
                    frequency += "Sa";
                if (checkBox_Sunday.Checked)
                    frequency += "Su";
            }


            Chore chore = new Chore(name, type, textBox_Description.Text, frequency,questionList,mainScreen.home.ID);
            chore.AddToDatabase();

            chores.Add(chore);

            label_FinishedNew.Text = "Chore Added Succesfully!";
            label_FinishedNew.Show();

            listBox_Chores.Items.Add(chore.Name);

            ClearGroupBox(groupBox_NewChore);

            

        }

        private string FindAvailableChoreName(string type, int number)
        {
            string name = type;
            if (number != 0) name += " " + number;
            foreach (Chore chore in chores)
            {
                if (chore.Name.StartsWith(name))
                {
                    name = FindAvailableChoreName(type, number + 1);
                }
            }
            return name;
        }
        private bool IsTheNameUnique(string name)
        {
            foreach (Chore chore in chores)
            {
                if (chore.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

        Chore editChore = null;

        internal List<Chore> Chores { get => chores; set => chores = value; }

        private void btn_EditChore_Click(object sender, EventArgs e)
        {
            
            if(listBox_Chores.SelectedIndex != -1)
            {
                foreach (Chore chore in chores)
                {
                    if (chore.Name == listBox_Chores.SelectedItem.ToString())
                    {
                        editChore = chore;
                        textBox_EditName.Text = chore.Name;
                        textBox_EditDescription.Text = chore.Description;
                        comboBox_EditType.SelectedItem = chore.Type;
                        
                        List<string> questions = chore.Questions;
                        for (int i = 0; i < questions.Count; i++)
                        {
                            if (questions[i].StartsWith("1"))
                            {
                                editedRadioButtonOptional[i].Checked = true;
                            }
                            else
                            {
                                editedRadioButtonRequired[i].Checked = true;
                            }
                            editedQuestions[i].Text = questions[i].Substring(1);

                        }

                        string frequency = chore.Frequency;
                        var isNumeric = int.TryParse(frequency, out int n);
                        if (frequency == "D")
                        {
                            radioButton_EditDaily.Checked = true;
                        }
                        else if (isNumeric)
                        {
                            radioButton_EditMonthly.Checked = true;
                            numericUpDown_EditMonthly.Value = n;
                        }
                        else
                        {
                            radioButton_EditWeekly.Checked = true;
                            if (frequency.Contains("Mo"))
                                checkBox_EditMonday.Checked = true;
                            else
                                checkBox_EditMonday.Checked = false;
                            if (frequency.Contains("Tu"))
                                checkBox_EditTuesday.Checked = true;
                            else
                                checkBox_EditTuesday.Checked = false;
                            if (frequency.Contains("We"))
                                checkBox_EditWednesday.Checked = true;
                            else
                                checkBox_EditWednesday.Checked = false;
                            if (frequency.Contains("Th"))
                                checkBox_EditThursday.Checked = true;
                            else
                                checkBox_EditThursday.Checked = false;
                            if (frequency.Contains("Fr"))
                                checkBox_EditFriday.Checked = true;
                            else
                                checkBox_EditFriday.Checked = false;
                            if (frequency.Contains("Sa"))
                                checkBox_EditSaturday.Checked = true;
                            else
                                checkBox_EditSaturday.Checked = false;
                            if (frequency.Contains("Su"))
                                checkBox_EditSunday.Checked = true;
                            else
                                checkBox_EditSunday.Checked = false;

                        }
                        label_FinishedSelected.Hide();
                        break;
                    }
                }

            }
        }

        private void button_ApplyChanges_Click(object sender, EventArgs e)
        {
            if (editChore != null)
            {
                label_EditError.Visible = false;
                label_EditError.Text = "";
                label_FinishedSelected.Hide();
                string previousName = editChore.Name;


                if (comboBox_EditType.SelectedIndex == -1)
                {
                    label_EditError.Visible = true;
                    label_EditError.Text = "Chore type can't be empty!";
                    return;
                }
                if (textBox_EditDescription.Text.Trim() == "")
                {
                    label_EditError.Visible = true;
                    label_EditError.Text = "Chore description can't be empty!";
                    return;
                }

                if (radioButton_EditQuestion1Disabled.Checked == false && textBox_EditQuestion1.Text.Trim() == "")
                {
                    label_EditError.Visible = true;
                    label_EditError.Text = "Question 1 is empty! Either disable it or add a question.";
                    return;
                }
                if (radioButton_EditQuestion2Disabled.Checked == false && textBox_EditQuestion2.Text.Trim() == "")
                {
                    label_EditError.Visible = true;
                    label_EditError.Text = "Question 2 is empty! Either disable it or add a question.";
                    return;
                }
                if (radioButton_EditQuestion3Disabled.Checked == false && textBox_EditQuestion3.Text.Trim() == "")
                {
                    label_EditError.Visible = true;
                    label_EditError.Text = "Question 3 is empty! Either disable it or add a question.";
                    return;
                }
                string name;
                string type = comboBox_EditType.Text;
                if (textBox_EditName.Text.Trim() != "")
                {
                    if (IsTheNameUnique(textBox_EditName.Text) || textBox_EditName.Text == previousName)
                        name = textBox_EditName.Text;
                    else
                    {
                        label_EditError.Visible = true;
                        label_EditError.Text = "The name already exists!";
                        return;
                    }
                }
                else
                {
                    name = FindAvailableChoreName(type, 0);
                }


                List<string> questionList = new List<string>();

                if (radioButton_EditQuestion1Optional.Checked)
                {
                    questionList.Add("1" + textBox_EditQuestion1.Text);
                }
                else if (radioButton_EditQuestion1Required.Checked)
                {
                    questionList.Add("0" + textBox_EditQuestion1.Text);
                }
                if (radioButton_EditQuestion2Optional.Checked)
                {
                    questionList.Add("1" + textBox_EditQuestion2.Text);
                }
                else if (radioButton_EditQuestion2Required.Checked)
                {
                    questionList.Add("0" + textBox_EditQuestion2.Text);
                }
                if (radioButton_EditQuestion3Optional.Checked)
                {
                    questionList.Add("1" + textBox_EditQuestion3.Text);
                }
                else if (radioButton_EditQuestion3Required.Checked)
                {
                    questionList.Add("0" + textBox_EditQuestion3.Text);
                }

                string frequency = "";
                if (radioButton_EditDaily.Checked)
                {
                    frequency = "D";
                }
                else if (radioButton_EditMonthly.Checked)
                {
                    frequency = numericUpDown_Monthly.Value.ToString();
                }
                else if (radioButton_EditWeekly.Checked)
                {
                    if (checkBox_EditMonday.Checked)
                        frequency += "Mo";
                    if (checkBox_EditTuesday.Checked)
                        frequency += "Tu";
                    if (checkBox_EditWednesday.Checked)
                        frequency += "We";
                    if (checkBox_EditThursday.Checked)
                        frequency += "Th";
                    if (checkBox_EditFriday.Checked)
                        frequency += "Fr";
                    if (checkBox_EditSaturday.Checked)
                        frequency += "Sa";
                    if (checkBox_EditSunday.Checked)
                        frequency += "Su";
                }


                editChore.Name = name;
                editChore.Type = type;
                editChore.Description = textBox_EditDescription.Text;
                editChore.Questions = questionList;
                editChore.Frequency = frequency;

                editChore.UpdateInDatabase();

                label_FinishedSelected.Text = "Changes Saved Succesfully!";
                label_FinishedSelected.Show();


                for (int i = 0; i < listBox_Chores.Items.Count; i++)
                {
                    if (listBox_Chores.Items[i].ToString() == previousName)
                    {
                        listBox_Chores.Items[i] = editChore.Name;
                        break;
                    }
                }
                ClearGroupBox(groupBox_SelectedChore);
                editChore = null;
            }

        }

        private void button_DeleteChore_Click(object sender, EventArgs e)
        {
            if (listBox_Chores.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("You can not restore it after you delete it", "Delete Chore", MessageBoxButtons.OKCancel);
                if (dialogResult == DialogResult.OK)
                {
                    foreach (Chore chore in chores)
                    {
                        if (chore.Name == listBox_Chores.SelectedItem.ToString())
                        {
                            if(chore == editChore)
                            {
                                ClearGroupBox(groupBox_SelectedChore);
                            }
                            chores.Remove(chore);
                            chore.RemoveFromDatabase();
                            listBox_Chores.Items.Remove(listBox_Chores.SelectedItem);
                            break;
                        }
                    }


                }
                else if (dialogResult == DialogResult.Cancel)
                {
                }
            }
        }

        public void ClearGroupBox(GroupBox control)
        {
            foreach (TextBox textBox in control.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }
            
            foreach (ComboBox comboBox in control.Controls.OfType<ComboBox>())
            {
                comboBox.SelectedIndex = -1;
            }
            foreach (CheckBox CheckBox in control.Controls.OfType<CheckBox>())
            {
                CheckBox.Checked = false;
            }
            foreach (RadioButton radioButton in control.Controls.OfType<RadioButton>())
            {
                if (radioButton.Text == "Disabled")
                {
                    radioButton.Checked = true;
                }
                if (radioButton.Text == "Daily")
                {
                    radioButton.Checked = true;
                }
            }
            foreach (GroupBox groupBox in control.Controls.OfType<GroupBox>())
            {
                if (groupBox.Controls != null)
                    ClearGroupBox(groupBox);
            }

        }

        private void button_CancelChanges_Click(object sender, EventArgs e)
        {
            label_FinishedSelected.Hide();
            label_EditError.Hide();
            ClearGroupBox(groupBox_SelectedChore);
            editChore = null;
        }

        private void checkBox_WeeklyAddChore_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_Weekly.Checked = true;

            if(checkBox_Friday.Checked && checkBox_Monday.Checked && checkBox_Saturday.Checked && checkBox_Sunday.Checked && checkBox_Thursday.Checked &&
                checkBox_Tuesday.Checked && checkBox_Wednesday.Checked)
            {
                radioButton_Daily.Checked = true;
            }
        }

        private void checkBox_WeeklyEditChore_CheckedChanged(object sender, EventArgs e)
        {
            radioButton_EditWeekly.Checked = true;

            if (checkBox_EditFriday.Checked && checkBox_EditMonday.Checked && checkBox_EditSaturday.Checked && checkBox_EditSunday.Checked 
                && checkBox_EditThursday.Checked && checkBox_EditTuesday.Checked && checkBox_EditWednesday.Checked)
            {
                radioButton_EditDaily.Checked = true;
            }
        }

        private void numericUpDown_Monthly_ValueChanged(object sender, EventArgs e)
        {
            radioButton_Monthly.Checked = true;
        }

        private void numericUpDown_EditMonthly_ValueChanged(object sender, EventArgs e)
        {
            radioButton_EditMonthly.Checked = true;
        }

        private void button_ResetChore_Click(object sender, EventArgs e)
        {
            label_FinishedNew.Hide();
            lbl_AddChoreError.Hide();
            ClearGroupBox(groupBox_NewChore);
        }

        private void ViewChores_VisibleChanged(object sender, EventArgs e)
        {
            label_FinishedNew.Hide();
            label_FinishedSelected.Hide();
        }
    }
}
