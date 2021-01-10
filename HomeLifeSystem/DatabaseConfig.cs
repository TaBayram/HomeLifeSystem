using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLifeSystem
{
    public partial class DatabaseConfig : Form
    {
        public DatabaseConfig()
        {
            InitializeComponent();

            string[] splitpath = Properties.Settings.Default.connectionPath.Split(';');
            //"Server = GREENANGEL; Database = HomeLife; Trusted_Connection = True;"

            textBox_Server.Text = splitpath[0].Split('=')[1].Trim();
            textBox_Database.Text = splitpath[1].Split('=')[1].Trim();



        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            try
            {
                string server = textBox_Server.Text.Trim();
                string database = textBox_Database.Text.Trim();
                string filePath = textBox_Path.Text.Trim();
                string userName = textBox_UserName.Text.Trim();
                string userPassword = textBox_UserName.Text.Trim();

                if (string.IsNullOrWhiteSpace(server))
                {
                    Database.DatabaseErrorBox("Server name is null");
                    return;
                }
                if (string.IsNullOrWhiteSpace(database))
                {
                    Database.DatabaseErrorBox("database name is null");
                    return;
                }
                if (string.IsNullOrWhiteSpace(filePath))
                {
                    Database.DatabaseErrorBox("file path is null");
                    return;
                }




                string path;
                string masterPath;

                if (checkBox1.Checked)
                {
                    path = $"Server ={server}; Database ={database}; Trusted_Connection = True;";
                    masterPath = $"Server ={server}; Database =master; Trusted_Connection = True;";

                }
                else
                {
                    path = $"Server ={server}; Database ={database};User Id={userName};Password={userPassword};";
                    masterPath = $"Server ={server}; Database =master;User Id={userName};Password={userPassword};";
                    Database.WriteConfigParameter("userid", userName);
                    Database.WriteConfigParameter("userpassword", userPassword);

                }

                Properties.Settings.Default.connectionPath = path;
                Properties.Settings.Default.Save();

                Database.WriteConfigParameter("server", server);
                Database.WriteConfigParameter("database", database);
                Database.WriteConfigParameter("path", filePath);
                Database.WriteConfigParameter("connectionPath", path);

        



                string scriptpath = Database.ReadConfigParameter("scriptpath");

                if (!File.Exists(scriptpath))
                {
                    throw new Exception("Setup file doesn't exist");
                    
                }
                string sqlScript = File.ReadAllText(scriptpath);


                sqlScript = sqlScript.Replace("{databaseName}", database);
                sqlScript = sqlScript.Replace("{primaryFilePath}", filePath + "\\" + database + ".mdf");
                sqlScript = sqlScript.Replace("{logFilePath}", filePath + "\\" + database + "_log.ldf");





                bool cont = Database.CreateDatabase(sqlScript, masterPath);
                if (!cont) return;

                string message = "Configuration is completed!";
                string title = "Success";
                if (DialogResult.OK == MessageBox.Show(message, title, MessageBoxButtons.OK))
                {
                    this.Close();
                }

            }
            catch(Exception exception)
            {
                Database.DatabaseErrorBox(exception.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            var checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                textBox_UserName.Enabled = false;
                textBox_UserPassword.Enabled = false;
            }
            else
            {
                textBox_UserName.Enabled = true;
                textBox_UserPassword.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if(folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_Path.Text = folderBrowserDialog.SelectedPath;
            }
        }
    }
}
