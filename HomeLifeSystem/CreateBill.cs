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
    public partial class CreateBill : UserControl
    {
        MainScreen mainScreen;
        Bill bill = null;
        ViewList viewList;

        public CreateBill(MainScreen mainScreen)
        {
            InitializeComponent();

            this.mainScreen = mainScreen;
            Coloring();
        }

        private void Coloring()
        {
            this.BackColor = GlobalColorConstants.mainGroupBoxColor;

            this.button1.BackColor = GlobalColorConstants.minorButtonColor;
            this.button1.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            this.button1.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

            this.button_CreateBill.BackColor = GlobalColorConstants.minorButtonColor;
            this.button_CreateBill.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            this.button_CreateBill.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;

            textBox_Currency.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox_Name.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            numericUpDown_Cost.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            comboBox_Type.BackColor = GlobalColorConstants.minorComboColor;

            dateTimePicker_PaymentDue.CalendarTitleBackColor = GlobalColorConstants.minorTextBoxInnerColor;          


        }


        internal void EditMode(Bill bill, ViewList viewList)
        {
            this.viewList = viewList;
            this.bill = bill;
            textBox_Name.Text = bill.Name;
            textBox_Currency.Text = bill.Currency;
            numericUpDown_Cost.Value = bill.Cost;
            comboBox_Type.SelectedItem = bill.Type;
            dateTimePicker_PaymentDue.Value = bill.PaymentDue;

            if (bill.Frequency == 1) checkBox_Yearly.Checked = true;

            button_CreateBill.Text = "Save Changes";

        }


        private void button_AddBill_Click(object sender, EventArgs e)
        {
            label_Error.Text = "";
            label_Error.Hide();
            label_Finished.Hide();

            if (textBox_Name.Text == "")
            {
                label_Error.Text = "Name can't be empty";
                label_Error.Show();
                return;
            }
            else if (textBox_Currency.Text == "")
            {
                label_Error.Text = "Currency can't be empty";
                label_Error.Show();
                return;
            }
            else if (comboBox_Type.SelectedIndex == -1)
            {
                label_Error.Text = "Type can't be empty";
                label_Error.Show();
                return;
            }
            int frequency = 0;

            if (checkBox_Yearly.Checked) frequency = 1;


            string name = textBox_Name.Text;
            string type = comboBox_Type.SelectedItem.ToString();
            int cost = (int)numericUpDown_Cost.Value;
            string currency = textBox_Currency.Text;
            DateTime paymentDue = dateTimePicker_PaymentDue.Value;

            if(this.bill == null)
            {
                Bill bill = new Bill(name, type, cost, currency, paymentDue, frequency, mainScreen.home.ID);
                mainScreen.home.Bills.Add(bill);
                label_Finished.Text = "Bill Created Successfully!";
               
            }
            else
            {
                bill.Name = textBox_Name.Text;
                bill.Currency = textBox_Currency.Text;
                bill.Cost = (int)numericUpDown_Cost.Value ;
                bill.Type = comboBox_Type.SelectedItem.ToString();
                bill.PaymentDue = dateTimePicker_PaymentDue.Value;

                Database.BillTableUpdate(bill);
                this.Parent.Controls.Remove(this);
                viewList.DrawObjects();
                label_Finished.Text = "Bill Updated Successfully!";

            }

            label_Finished.Show();

        }

        private void checkBox_Yearly_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox_Yearly.Checked) dateTimePicker_PaymentDue.CustomFormat = ("dd/MM");
            else dateTimePicker_PaymentDue.CustomFormat = ("dd");
        }

        private void ClearBoxes()
        {
            Control control = groupBox1;
            foreach (TextBox textBox in control.Controls.OfType<TextBox>())
            {
                textBox.Text = "";
            }

            foreach (ComboBox comboBox in control.Controls.OfType<ComboBox>())
            {
                comboBox.SelectedIndex = -1;
            }

            numericUpDown_Cost.Value = numericUpDown_Cost.Minimum;

            dateTimePicker_PaymentDue.Value = dateTimePicker_PaymentDue.MinDate;
            checkBox_Yearly.Checked = true;

        }




        private void button1_Click(object sender, EventArgs e)
        {
            label_Finished.Hide();
            if (bill == null)
            {
                ClearBoxes();
            }
            else
            {
                this.Parent.Controls.Remove(this);
                viewList.DrawObjects();
            }
        }

        private void CreateBill_VisibleChanged(object sender, EventArgs e)
        {
            label_Finished.Hide();
        }
    }
}
