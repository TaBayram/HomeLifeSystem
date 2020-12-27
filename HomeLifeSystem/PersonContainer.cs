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
    public partial class PersonContainer : UserControl
    {
        Person person;

        public PersonContainer(Person person)
        {
            InitializeComponent();
            this.person = person;
            Color color = GlobalColorConstants.GetRandomColor(180, 236, 140, 180, 180, 236);

            if (person.Gender == "Male")
            {
                pictureBox1.Image = imageList1.Images[1];
                color = GlobalColorConstants.GetRandomColor(120, 176, 140, 180, 200, 256);
            }
            else
            {
                pictureBox1.Image = imageList1.Images[0];
                color = GlobalColorConstants.GetRandomColor(200, 256, 140, 180, 120, 176);
            }

            Color mainRandomColor = color;
            this.BackColor = mainRandomColor;

            label_Nickname.Text = "Nickname: \t" + person.Nickname;
            label_Name.Text = "Name: \t" + person.Name;
            label_Surname.Text = "Surname: \t" + person.Surname;
            label_Birthday.Text = "Birthday: \t" + person.Birthday.ToString("dd/MM/yyyy");


            contextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
        }

        public void RemoveContextMenu()
        {
            this.Controls.Remove(contextMenuStrip1);
            this.ContextMenuStrip = null;
        }

        private void kickToolStripMenuItem_Click(object sender, EventArgs e)
        {
            person.LeaveHome(null);
            this.Parent.Controls.Remove(this);
        }
    }
}
