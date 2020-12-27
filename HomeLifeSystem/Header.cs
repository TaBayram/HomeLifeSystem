using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.ComponentModel.Design.Serialization;
using System.Runtime.CompilerServices;

namespace HomeLifeSystem
{

    public partial class Header : UserControl
    {
        Form form;
        public Header(Form obj)
        {
            InitializeComponent();

            this.BackColor = GlobalColorConstants.headerBackGroundColor;
            tableLayoutPanel1.BackColor = GlobalColorConstants.headerBackGroundColor;
            btn_Close.BackColor = GlobalColorConstants.headerButtonColor;
            btn_Maximize.BackColor = GlobalColorConstants.headerButtonColor;
            btn_Minimize.BackColor = GlobalColorConstants.headerButtonColor;
  
            menuStrip_Home.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());
            menuStrip_Person.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());

            this.StatusUpdated += new EventHandler(MyEventHandlerFunction_StatusUpdated);
            form = obj;
            this.Dock = DockStyle.Fill;

            form.FormClosed += new FormClosedEventHandler(btn_Close_Click);


            giveAllChildsDrag(this);
           
        }
        
        private void Header_Load(object sender, EventArgs e)
        {

        }
        //
        private void giveAllChildsDrag(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if(!item.Name.StartsWith("btn"))
                    item.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Header_MouseDown);
                if (item.Controls != null)
                    giveAllChildsDrag(item);
            }
        }
        //Notifying Parents
        public event EventHandler StatusUpdated;
        private void Header_MouseDown(object sender,MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (this.StatusUpdated != null)
                    this.StatusUpdated("drag", new EventArgs());
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            if(sender is Button)
                form.Close();  
            if (Application.OpenForms.Count == 0)
                Application.Exit();

        }

        private void btn_Maximize_Click(object sender, EventArgs e)
        {
            if (this.StatusUpdated != null)
                this.StatusUpdated("max", new EventArgs());
        }

        private void btn_Minimize_Click(object sender, EventArgs e)
        {
            if (this.StatusUpdated != null)
                this.StatusUpdated("min", new EventArgs());
        }


        //DRAG THINGY

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //Parent handler
        public void MyEventHandlerFunction_StatusUpdated(object sender, EventArgs e)
        {

            if (sender.ToString() == "drag")
            {
                ReleaseCapture();
                SendMessage(form.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
            else if (sender.ToString() == "max")
            {
                if (form.WindowState == FormWindowState.Normal)
                    form.WindowState = FormWindowState.Maximized;
                else form.WindowState = FormWindowState.Normal;
            }
            else if (sender.ToString() == "min")
            {
                form.WindowState = FormWindowState.Minimized;
            }
        }

        public void DeleteMaximizeButton()
        {
            btn_Maximize.Enabled = false;
            btn_Maximize.BackgroundImage = null;
           
        }

       public void ChangeName(string nm)
        {
            lb_Name.Text = nm;
        }

        public void ChangeAppTextSize(float size)
        {
            label_HomeLife.Font = new System.Drawing.Font(label_HomeLife.Font.Name, size);
        }
        public void ChangeAppText(string name)
        {
            label_HomeLife.Text = name;
        }

        public void DeleteMenuStrip()
        {
            splitContainer1.Visible = false;
            splitContainer1.Enabled = false;
            this.Controls.Remove(splitContainer1);
            /*menuStrip_Home.Visible = false;
            menuStrip_Home.Enabled = false;*/
        }



        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void leaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = (MainScreen)form;
            mainScreen.showLeaveHome();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = (MainScreen)form;
            mainScreen.User.SignOut(mainScreen);
        }

        private void informationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = (MainScreen)form;
            mainScreen.btn_PersonalInformation_Click(sender, e);
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = (MainScreen)form;
            mainScreen.CreateBill(sender, e);
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = (MainScreen)form;
            mainScreen.ViewBill(sender, e);
        }

        private void busyTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainScreen mainScreen = (MainScreen)form;
            mainScreen.ViewBusyTime(sender, e);
        }
    }
}
