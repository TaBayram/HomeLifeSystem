using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLifeSystem
{

    public partial class ViewList : Form
    {

        List<object> list;
        MainScreen mainScreen;

        public List<object> List { get => list; set => list = value; }

        public ViewList(MainScreen mainScreen, List<object> list)
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

            if(list.Count == 0)
            {
                label_Title.Text = "EMPTY";
            }
            else
                label_Title.Text = SplitStringByUppercase(list[0].GetType().ToString().Substring(list[0].GetType().ToString().IndexOf(".")+1));
            this.List = list;
            this.mainScreen = mainScreen;

            DrawObjects();
            Coloring();
        }


        private void Coloring()
        {
            
            this.BackColor = GlobalColorConstants.sideBackgroundColor;

            
        }

        public void DrawObjects()
        {
            flowLayoutPanel_List.Controls.Clear();
            foreach(object obj in List)
            {
                GenericObjectContainer genericObjectContainer = new GenericObjectContainer(this, obj);
                genericObjectContainer.Parent = flowLayoutPanel_List;
                genericObjectContainer.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string SplitStringByUppercase(string text, string separator = " ")
        {
            string newText = "";
            bool needSeparator = false;
            for (int i = 0; i < text.Length; i++)
            {
                if (char.ToUpper(text[i]) == text[i])
                {
                    if (needSeparator)
                    {
                        newText += separator;
                        needSeparator = false;
                    }
                    needSeparator = true;
                }
                newText += text[i].ToString();
            }


            return newText;
        }

        internal void RemoveObject(Bill obj)
        {
            mainScreen.home.Bills.Remove(obj);
            Database.BillTableRemove(obj);
        }

        internal void RemoveObject(BusyTime obj)
        {
            mainScreen.User.BusyTimes.Remove(obj);
            Database.BusyTimeTableRemove(obj);
        }

        internal void EditObject(Bill bill, UserControl userControl)
        {
            foreach(UserControl control in flowLayoutPanel_List.Controls)
            {
                if (userControl != control) control.Hide();
            }

            CreateBill createBill = new CreateBill(mainScreen);
            createBill.EditMode(bill, this);
            createBill.Parent = flowLayoutPanel_List;
            createBill.Show();


        }

        internal void EditObject(BusyTime busyTime, UserControl userControl)
        {

            foreach (UserControl control in flowLayoutPanel_List.Controls)
            {
                if (userControl != control) control.Hide();
            }

            CreateBusyTime createBusyTime = new CreateBusyTime(mainScreen);
            createBusyTime.EditMode(busyTime, this);
            createBusyTime.Parent = flowLayoutPanel_List;
            createBusyTime.Show();

        }
    }
}
