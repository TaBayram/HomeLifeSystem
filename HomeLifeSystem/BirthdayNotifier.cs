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
    public partial class BirthdayNotifier : Form
    {
        public BirthdayNotifier(Person person)
        {
            InitializeComponent();
            CenterToScreen();

            Header header = new Header(this);
            this.Controls.Add(header);
            header.Parent = splitContainer_Main.Panel1;
            header.Show();
            header.DeleteMaximizeButton();
            header.ChangeAppTextSize(8);
            header.ChangeAppText("Home Life");
            header.DeleteMenuStrip();

            label_bd.Text += " " + person.Nickname +" !";

            int years = (int)(DateTime.Now - person.Birthday).TotalDays/365;

            label1.Text = "Congratulations on your " + years + ". birthday!";

            this.BackColor = GlobalColorConstants.GetRandomColor(120,256);
        }
    }
}
