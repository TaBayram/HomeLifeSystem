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
    public partial class PeopleContainer : UserControl
    {
        MainScreen mainScreen;

        public PeopleContainer(MainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            PeopleContainer_VisibleChanged(null, null);
            this.Dock = DockStyle.Fill;

        }

        private void PeopleContainer_VisibleChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            Home home = mainScreen.home;
            foreach(Person person in home.Household)
            {
                PersonContainer personContainer = new PersonContainer(person);
                if(home.CreatorID != mainScreen.User.ID || home.CreatorID == person.ID)
                {
                    personContainer.RemoveContextMenu();
                }
                personContainer.Parent = flowLayoutPanel1;
                personContainer.Show();
            }
        }


    }


}
