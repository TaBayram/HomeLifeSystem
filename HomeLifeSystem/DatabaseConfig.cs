using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

            textBox1.Text = splitpath[0].Split('=')[1].Trim();
            textBox2.Text = splitpath[1].Split('=')[1].Trim();



        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            string server = textBox1.Text;
            string database = textBox2.Text;

            string path = $"Server ={server}; Database ={database}; Trusted_Connection = True;";
            Properties.Settings.Default.connectionPath = path;
            Properties.Settings.Default.Save();

            string message = "Saved Changes Successfully";
            string title = "Saved";
            if(DialogResult.OK ==  MessageBox.Show(message, title, MessageBoxButtons.OK))
            {
                this.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
