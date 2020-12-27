using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLifeSystem
{
    public partial class PersonalInformation : Form
    {
        Person person;
        bool signedUp = false;
        MainScreen mainScreen;
        public PersonalInformation(Person person,MainScreen mainScreen)
        {
            InitializeComponent();

            Header header = new Header(this);
            this.Controls.Add(header);
            header.Parent = splitContainer_Main.Panel1;
            header.Show();
            header.DeleteMaximizeButton();
            header.ChangeAppTextSize(8);
            header.ChangeAppText("Home Life");
            header.DeleteMenuStrip();

            this.mainScreen = mainScreen;
            this.person = person;
            Coloring();
            FillInformation();
        }

        private void Coloring()
        {
            this.BackColor = GlobalColorConstants.sideBackgroundColor;
            this.panel_Control.BackColor = GlobalColorConstants.mainBackgroundColor;

            this.button_Cancel.BackColor = GlobalColorConstants.sideButtonColor;
            this.button_Cancel.FlatAppearance.MouseDownBackColor = GlobalColorConstants.sideButtonDownColor;
            this.button_Cancel.FlatAppearance.MouseOverBackColor = GlobalColorConstants.sideButtonOverColor;

            this.button_SaveChanges.BackColor = GlobalColorConstants.sideButtonColor;
            this.button_SaveChanges.FlatAppearance.MouseDownBackColor = GlobalColorConstants.sideButtonDownColor;
            this.button_SaveChanges.FlatAppearance.MouseOverBackColor = GlobalColorConstants.sideButtonOverColor;

            this.button_DeleteAccount.BackColor = GlobalColorConstants.sideButtonColor;
            this.button_DeleteAccount.FlatAppearance.MouseDownBackColor = GlobalColorConstants.sideButtonDownColor;
            this.button_DeleteAccount.FlatAppearance.MouseOverBackColor = GlobalColorConstants.sideButtonOverColor;

            this.button_Verify.BackColor = GlobalColorConstants.sideButtonColor;
            this.button_Verify.FlatAppearance.MouseDownBackColor = GlobalColorConstants.sideButtonDownColor;
            this.button_Verify.FlatAppearance.MouseOverBackColor = GlobalColorConstants.sideButtonOverColor;

            this.button_VerifyCancel.BackColor = GlobalColorConstants.sideButtonColor;
            this.button_VerifyCancel.FlatAppearance.MouseDownBackColor = GlobalColorConstants.sideButtonDownColor;
            this.button_VerifyCancel.FlatAppearance.MouseOverBackColor = GlobalColorConstants.sideButtonOverColor;

            this.textBox_VerifyPassword.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            this.tb_SignUpName.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            this.tb_SignUpNickname.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            this.tb_SignUpPassword.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            this.tb_SignUpSurname.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            comboBox_SignUpGender.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            dateTimePicker_SignUpBirthday.CalendarForeColor = GlobalColorConstants.sideTextBoxInnerColor;
        }

        private void FillInformation()
        {
            tb_SignUpNickname.Text = person.Nickname;
            tb_SignUpName.Text = person.Name;
            tb_SignUpSurname.Text = person.Surname;
            comboBox_SignUpGender.SelectedItem = person.Gender;
            dateTimePicker_SignUpBirthday.Value = person.Birthday;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (!signedUp)
                {
                    panel_Control.Enabled = true;
                    panel_Control.Visible = true;
                    panel_Control.BringToFront();

                }
                else
                {
                    tb_SignUpName.ReadOnly = false;
                    tb_SignUpPassword.ReadOnly = false;
                    tb_SignUpSurname.ReadOnly = false;
                    comboBox_SignUpGender.Enabled = true;
                    dateTimePicker_SignUpBirthday.Enabled = true;
                    button_DeleteAccount.Enabled = true;
                }
            }
            else
            {
                tb_SignUpName.ReadOnly = true;
                tb_SignUpPassword.ReadOnly = true;
                tb_SignUpSurname.ReadOnly = true;
                comboBox_SignUpGender.Enabled = false;
                dateTimePicker_SignUpBirthday.Enabled = false;
                button_DeleteAccount.Enabled = false;
            }
        }

        private void button_SaveChanges_Click(object sender, EventArgs e)
        {
            lbl_SignUpErrors.Visible = false;
            lbl_SignUpErrors.Text = "";
            label_Finished.Hide();

            if (checkBox1.Checked)
            {
                
                var regexItem = new Regex("^[a-zA-Z0-9 ]+$");
                if (tb_SignUpNickname.Text == null || tb_SignUpNickname.Text.Trim() == "")
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Nickname can't be empty!\n";
                    return;
                }
                else if (!regexItem.IsMatch(tb_SignUpNickname.Text))
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Nickname can't contain special characters!\n";
                    return;
                }
                else if (tb_SignUpNickname.Text.Length < 4)
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Nickname is too short!\n";
                    return;
                }
                else if (tb_SignUpName.Text == null || tb_SignUpName.Text.Trim() == "")
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Name can't be empty!\n";
                    return;
                }
                else if (!regexItem.IsMatch(tb_SignUpName.Text))
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Name can't contain special characters!\n";
                    return;
                }
                else if (tb_SignUpName.Text.Length < 3)
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Name is too short!\n";
                    return;
                }
                else if (tb_SignUpSurname.Text == null || tb_SignUpSurname.Text.Trim() == "")
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Surname can't be empty!\n";
                    return;
                }
                else if (!regexItem.IsMatch(tb_SignUpSurname.Text))
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Surname can't contain special characters!\n";
                    return;
                }
                else if (tb_SignUpSurname.Text.Length < 3)
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Surname is too short!\n";
                    return;
                }
                else if (tb_SignUpPassword.Text == null || tb_SignUpPassword.Text.Trim() == "")
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Password can't be empty!\n";
                    return;
                }
                else if (tb_SignUpPassword.Text.Length < 4)
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Password is too short!\n";
                    return;
                }
                else if (comboBox_SignUpGender.SelectedIndex == -1)
                {
                    lbl_SignUpErrors.Visible = true;
                    lbl_SignUpErrors.Text += "Gender can't be empty\n";
                    return;
                }
                string name = tb_SignUpName.Text;
                string surname = tb_SignUpSurname.Text;
                string password = tb_SignUpPassword.Text;
                string gender = comboBox_SignUpGender.SelectedItem.ToString();
                DateTime birthday = dateTimePicker_SignUpBirthday.Value;

                person.Name = name;
                person.Surname = surname;
                person.Gender = gender;
                person.Birthday = birthday;

                person.UpdateInDatabase(password);

                label_Finished.Text = "Account updated successfully";
                label_Finished.Show();

                //this.Close();
            }
            else
            {
                
            }
        }

        private void comboBox_SignUpGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(comboBox_SignUpGender.SelectedIndex == 0)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            else if (comboBox_SignUpGender.SelectedIndex == 1)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
        }

        private void button_Verify_Click(object sender, EventArgs e)
        {
            label_VerifyError.Text = "";
            label_VerifyError.Hide();

            if(textBox_VerifyPassword.Text.Length < 4)
            {
                label_VerifyError.Show();
                label_VerifyError.Text = "Password is too short!";
                return;
            }


            if (textBox_VerifyPassword.Text == person.GetPassword())
            {
                signedUp = true;
                panel_Control.Enabled = false;
                panel_Control.Visible = false;
                tb_SignUpPassword.Text = person.GetPassword();
                checkBox1_CheckedChanged(checkBox1, null);
            }
            else
            {
                label_VerifyError.Show();
                label_VerifyError.Text = "Wrong Password!";
            }
        }

        private void button_VerifyCancel_Click(object sender, EventArgs e)
        {
            panel_Control.Enabled = false;
            panel_Control.Visible = false;
            checkBox1.Checked = false;
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void button_DeleteAccount_Click(object sender, EventArgs e)
        {
            string text = "If you delete your account all your information will be removed. Are you Sure?";
            string title = "Delete Account";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(text, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                person.RemoveFromDatabase();
                person.SignOut(mainScreen);
                
            }
            else
            {
            }
        }
    }
}
