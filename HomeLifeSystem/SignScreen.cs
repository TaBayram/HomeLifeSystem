using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Threading;

namespace HomeLifeSystem
{
    public partial class SignScreen : Form
    {
        public SignScreen()
        {
            InitializeComponent();
            //COLORING
            coloring();



            //Call Header
            Header header = new Header(this);
            this.Controls.Add(header);
            header.Parent = splitContainer_Main.Panel1;
            header.Show();
            header.DeleteMaximizeButton();
            header.ChangeAppTextSize(8);
            header.ChangeAppText("Home Life");
            header.DeleteMenuStrip();

            dateTimePicker_SignUpBirthday.MinDate = DateTime.Now.Date.AddYears(-100);
            dateTimePicker_SignUpBirthday.MaxDate = DateTime.Now.Date.AddYears(-6);

            if (Properties.Settings.Default.userRememberMe)
            {
                tb_SignInNickname.Text = Properties.Settings.Default.userName;
                tb_SignInPassword.Text = Properties.Settings.Default.userPassword;
            }
        }

        private void coloring()
        {
            this.ForeColor = GlobalColorConstants.mainForeColor;
            this.BackColor = GlobalColorConstants.mainBackgroundColor;

            tabPage_SignIn.BackColor = this.BackColor;
            tabPage_SignUp.BackColor = this.BackColor;

            tb_SignInNickname.BackColor = GlobalColorConstants.signScreenTextBoxInnerColor;
            tb_SignInPassword.BackColor = GlobalColorConstants.signScreenTextBoxInnerColor;
            tb_SignUpName.BackColor = GlobalColorConstants.signScreenTextBoxInnerColor;
            tb_SignUpNickname.BackColor = GlobalColorConstants.signScreenTextBoxInnerColor;
            tb_SignUpPassword.BackColor = GlobalColorConstants.signScreenTextBoxInnerColor;
            tb_SignUpSurname.BackColor = GlobalColorConstants.signScreenTextBoxInnerColor;
            comboBox_SignUpGender.BackColor = GlobalColorConstants.signScreenTextBoxInnerColor;

            btn_SignIn.BackColor = GlobalColorConstants.signScreenButtonColor;
            btn_SignUp.BackColor = GlobalColorConstants.signScreenButtonColor;

            Color color = GlobalColorConstants.signScreenButtonColor;

            btn_SignIn.FlatAppearance.MouseOverBackColor = Color.FromArgb(color.R, color.G + 10, color.B);
            btn_SignIn.FlatAppearance.MouseDownBackColor = Color.FromArgb(color.R, color.G + 30, color.B);
            btn_SignUp.FlatAppearance.MouseOverBackColor = Color.FromArgb(color.R, color.G + 10, color.B);
            btn_SignUp.FlatAppearance.MouseDownBackColor = Color.FromArgb(color.R, color.G + 30, color.B);
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            lbl_SignInNicknameError.Visible = false;
            lbl_SignInPasswordError.Visible = false;

            var regexItem = new Regex("^[a-zA-Z0-9 ]+$");
            if(tb_SignInNickname.Text == null || tb_SignInNickname.Text.Trim() == "")
            {
                lbl_SignInNicknameError.Visible = true;
                lbl_SignInNicknameError.Text = "Nickname can't be empty!";
                return;
            }
            else if (!regexItem.IsMatch(tb_SignInNickname.Text))
            {
                lbl_SignInNicknameError.Visible = true;
                lbl_SignInNicknameError.Text = "Nickname can't contain special characters!";
                return;
            }
            if (tb_SignInPassword.Text == null || tb_SignInPassword.Text.Trim() == "")
            {
                lbl_SignInPasswordError.Visible = true;
                lbl_SignInPasswordError.Text = "Password can't be empty!";
                return;
            }


            //SQL CHECK
            string result = Database.DoesPersonExist(tb_SignInNickname.Text, tb_SignInPassword.Text);


            //Sign In
            if (result == "in")
            {
                lbAppName.Text = "Signing In...";
                
                Person user = Database.GetPersonByNickname(tb_SignInNickname.Text,true);

                if (checkBox_RememberMe.Checked) {
                    Properties.Settings.Default.userName = tb_SignInNickname.Text;
                    Properties.Settings.Default.userPassword = tb_SignInPassword.Text;
                    Properties.Settings.Default.userRememberMe = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.userName = "";
                    Properties.Settings.Default.userPassword = "";
                    Properties.Settings.Default.userRememberMe = false;
                    Properties.Settings.Default.Save();
                }

                CloseThisOpenMainScreen(user);

            }
            else if (result.StartsWith("Error"))
            {
                if(result.EndsWith(" N"))
                {
                    lbl_SignInNicknameError.Visible = true;
                    lbl_SignInNicknameError.Text = result.Substring(0,result.Length-2);
                    return;
                }
                if (result.EndsWith(" P"))
                {
                    lbl_SignInPasswordError.Visible = true;
                    lbl_SignInPasswordError.Text = result.Substring(0, result.Length - 2);
                    return;
                }
            }


        }

        private void btn_SignUp_Click(object sender, EventArgs e)
        {

            lbl_SignUpErrors.Visible = false;
            lbl_SignUpErrors.Text = "";

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




            Person user = new Person(tb_SignUpNickname.Text,tb_SignUpName.Text, tb_SignUpSurname.Text, 
                comboBox_SignUpGender.SelectedItem.ToString(), dateTimePicker_SignUpBirthday.Value,tb_SignUpPassword.Text);

            CloseThisOpenMainScreen(user);

        }

        private void CloseThisOpenMainScreen(Person user)
        {
            Program.CreateMainScreen(user);
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseConfig databaseConfig = new DatabaseConfig();
            databaseConfig.ShowDialog();
        }
    }
}
