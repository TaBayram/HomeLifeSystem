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
    public partial class CalendarFilterPopUp : UserControl
    {
        bool editMode = true;
        ViewCalendar viewCalendar;
        public CalendarFilterPopUp(ViewCalendar viewCalendar)
        {
            InitializeComponent();
            this.viewCalendar = viewCalendar;

            if (viewCalendar.Filters[1] == "0") checkBox_ShowBusyTimes.Checked = true;
            if (viewCalendar.Filters[3] == "0") checkBox_ShowEvents.Checked = true;
            if (viewCalendar.Filters[5] == "0") checkBox_ShowHouseworks.Checked = true;
            if (viewCalendar.Filters[7] == "0") checkBox_ShowRequests.Checked = true;
            if (viewCalendar.Filters[9] == "0") checkBox_ShowFreeTimes.Checked = true;

            if(checkBox_ShowBusyTimes.Checked && checkBox_ShowEvents.Checked && checkBox_ShowHouseworks.Checked && checkBox_ShowRequests.Checked)
            {
                checkBox_ShowAll.Checked = true;
            }

            editMode = false;

            Coloring();
        }
        
        private void Coloring()
        {
            this.BackColor = GlobalColorConstants.menuStrip;
        }


        private void checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (editMode) return;

            if (sender == checkBox_ShowAll)
            {
                editMode = true;
                if (checkBox_ShowAll.Checked)
                {
                    checkBox_ShowBusyTimes.Checked = true;
                    checkBox_ShowEvents.Checked = true;
                    checkBox_ShowHouseworks.Checked = true;
                    checkBox_ShowRequests.Checked = true;

                    checkBox_ShowFreeTimes.Checked = false;

                    viewCalendar.Filters[1] = "0";
                    viewCalendar.Filters[3] = "0";
                    viewCalendar.Filters[5] = "0";
                    viewCalendar.Filters[7] = "0";
                    viewCalendar.Filters[9] = "1";
                }
                else
                {
                    checkBox_ShowBusyTimes.Checked = false;
                    checkBox_ShowEvents.Checked = false;
                    checkBox_ShowHouseworks.Checked = false;
                    checkBox_ShowRequests.Checked = false;

                    checkBox_ShowFreeTimes.Checked = true;

                    viewCalendar.Filters[1] = "1";
                    viewCalendar.Filters[3] = "1";
                    viewCalendar.Filters[5] = "1";
                    viewCalendar.Filters[7] = "1";
                    viewCalendar.Filters[9] = "0";
                }

                editMode = false;
            }
            if (sender == checkBox_ShowBusyTimes)
            {
                if (((CheckBox)sender).Checked)
                {
                    viewCalendar.Filters[1] = "0";
                }
                else
                {
                    viewCalendar.Filters[1] = "1";
                }
            }
            if (sender == checkBox_ShowEvents)
            {
                if (((CheckBox)sender).Checked)
                {
                    viewCalendar.Filters[3] = "0";
                }
                else
                {
                    viewCalendar.Filters[3] = "1";
                }
            }
            if (sender == checkBox_ShowHouseworks)
            {
                if (((CheckBox)sender).Checked)
                {
                    viewCalendar.Filters[5] = "0";
                }
                else
                {
                    viewCalendar.Filters[5] = "1";
                }
            }
            if (sender == checkBox_ShowRequests)
            {
                if (((CheckBox)sender).Checked)
                {
                    viewCalendar.Filters[7] = "0";
                }
                else
                {
                    viewCalendar.Filters[7] = "1";
                }
            }
            if (sender == checkBox_ShowFreeTimes)
            {
                editMode = true;
                if (checkBox_ShowFreeTimes.Checked)
                {
                    checkBox_ShowAll.Checked = false;
                    checkBox_ShowBusyTimes.Checked = false;
                    checkBox_ShowEvents.Checked = false;
                    checkBox_ShowHouseworks.Checked = false;
                    checkBox_ShowRequests.Checked = false;

                    checkBox_ShowFreeTimes.Checked = true;

                    viewCalendar.Filters[1] = "1";
                    viewCalendar.Filters[3] = "1";
                    viewCalendar.Filters[5] = "1";
                    viewCalendar.Filters[7] = "1";
                    viewCalendar.Filters[9] = "0";
                }
                else
                {
                    viewCalendar.Filters[9] = "1";
                }

                editMode = false;
            }

            viewCalendar.FilterChange();

        }

        private void CalendarFilterPopUp_Leave(object sender, EventArgs e)
        {
            if (!this.ClientRectangle.Contains(this.PointToClient(Control.MousePosition)))
            {
                if (this.Parent == null) return;
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
