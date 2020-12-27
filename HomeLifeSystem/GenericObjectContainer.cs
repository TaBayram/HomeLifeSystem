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
    public partial class GenericObjectContainer : UserControl
    {
        ViewList viewList;
        object obj;
        string objectType= "";

        public GenericObjectContainer(ViewList viewList, object obj)
        {
            InitializeComponent();


            toolTip_Info1.SetToolTip(textBox_Name, "Name");

            this.viewList = viewList;
            this.obj = obj;

            ObjectType(obj);
            Coloring();
        }

        private void Coloring()
        {
            this.BackColor = GlobalColorConstants.GetRandomColor(180, 200, 200, 256, 200, 256);

            textBox_Name.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            textBox_Info1.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            textBox_Info2.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            textBox_Info3.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            textBox_Info4.BackColor = GlobalColorConstants.sideTextBoxInnerColor;
            textBox_Info5.BackColor = GlobalColorConstants.sideTextBoxInnerColor;

            contextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());

        }

        private void ObjectType(object obj)
        {
            Type type = obj.GetType();

            if(type == typeof(Bill))
            {
                ShowBill((Bill)obj);
                objectType = "Bill";
            }
            else if(type == typeof(BusyTime))
            {
                ShowBusyTime((BusyTime)obj);
                objectType = "Busy Time";
            }
            toolTip_Info1.ToolTipTitle = objectType;
        }

        private void ShowBill(Bill bill)
        {
            pictureBox1.Image = imageList.Images[0];

            textBox_Name.Text = bill.Name;
            textBox_Info1.Text = bill.Type;
            textBox_Info2.Text = bill.Cost + bill.Currency;

            if(bill.Frequency == 0)
            {
                textBox_Info3.Text = "Monthly";
                textBox_Info4.Text = bill.PaymentDue.ToString("dd");
            }
            else
            {
                textBox_Info3.Text = "Yearly";
                textBox_Info4.Text = bill.PaymentDue.ToString("dd/MM");
            }

            toolTip_Info1.SetToolTip(textBox_Info1, "Type");
            toolTip_Info1.SetToolTip(textBox_Info2, "Cost");
            toolTip_Info1.SetToolTip(textBox_Info3, "Frequency");
            toolTip_Info1.SetToolTip(textBox_Info4, "Payment Due");
            


        }

        private void ShowBusyTime(BusyTime busyTime)
        {
            pictureBox1.Image = imageList.Images[1];

            textBox_Name.Text = busyTime.Name;
            textBox_Info1.Text = busyTime.Type;
            string formatted = (DateTime.Today + busyTime.StartTime).ToString("hh:mm");
            textBox_Info2.Text = formatted;
            formatted = (DateTime.Today + busyTime.EndTime).ToString("hh:mm");
            textBox_Info3.Text = formatted;

            string frequency = viewList.SplitStringByUppercase(busyTime.Frequency, ", ");

            textBox_Info4.Text = frequency;
            textBox_Info5.Text = busyTime.Description;

            toolTip_Info1.SetToolTip(textBox_Info1, "Type");
            toolTip_Info1.SetToolTip(textBox_Info2, "Starting Time");
            toolTip_Info1.SetToolTip(textBox_Info3, "Ending Time");
            toolTip_Info1.SetToolTip(textBox_Info4, "Frequency");
            toolTip_Info1.SetToolTip(textBox_Info5, "Description");

        }




        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string text = "Are you sure you want to delete?";
            string title = "Delete " + objectType;
            DialogResult dialogResult = MessageBox.Show(text, title, MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                Type type = obj.GetType();
                if (type == typeof(Bill))
                {
                    Database.BillTableRemove((Bill)obj);
                    viewList.RemoveObject((Bill)obj);

                }
                else if (type == typeof(BusyTime))
                {
                    Database.BusyTimeTableRemove((BusyTime)obj);
                    viewList.RemoveObject((BusyTime)obj);
                }

                this.Parent.Controls.Remove(this);
                this.Dispose();

            }
            else if (dialogResult == DialogResult.Cancel)
            {
                return;
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Type type = obj.GetType();
            if (type == typeof(Bill))
            {
                viewList.EditObject((Bill)obj,this);

            }
            else if (type == typeof(BusyTime))
            {
                viewList.EditObject((BusyTime)obj,this);
            }

        }
    }
}
