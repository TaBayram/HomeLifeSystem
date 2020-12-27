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

namespace HomeLifeSystem
{
    public partial class CalendarInformationPopUp : UserControl
    {

        List<object> occasion;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public CalendarInformationPopUp(List<object> occasion)
        {
            InitializeComponent();
            this.occasion = occasion;

            var activity = occasion[0];
            DateTime startingDateTime = (DateTime)occasion[1];
            DateTime endingDateTime = (DateTime)occasion[2];
            Person person = (Person)occasion[3];
            

            
            label_Info2.Text = person.Nickname;
            label_Info3.Text = startingDateTime.ToString("HH:mm dd/MM/yyyy");
            label_Info4.Text = endingDateTime.ToString("HH:mm dd/MM/yyyy");

            label_Title2.Text = "Creator:";
            label_Title3.Text = "Starting Date:";
            label_Title4.Text = "Ending Date:";

            pictureBox1.Parent = this;
            this.Controls.SetChildIndex(pictureBox1, 0);

            Type type = activity.GetType();
            label_Activity.Text = type.Name;
            if (type == typeof(BusyTime))
            {
                BusyTime busyTime = (BusyTime)activity;

                label_Info1.Text = busyTime.Name;
                label_Info5.Text = busyTime.Type;

                pictureBox1.Image = imageList1.Images[0];

                label_Title1.Text = "Name:";
                label_Title5.Text = "Type:";

            }
            else if (type == typeof(Event))
            {
                Event @event = (Event)activity;

                label_Info1.Text = @event.Name;
                label_Info5.Text = @event.Type;

                pictureBox1.Image = imageList1.Images[1];

                label_Title1.Text = "Name:";
                label_Title5.Text = "Type:";

            }
            else if (type == typeof(Request))
            {
                Request request = (Request)activity;

                label_Info1.Text = request.Name;
                label_Info5.Text = request.AccepterName;
                label_Info6.Text = request.Description;

                pictureBox1.Image = imageList1.Images[3];

                label_Title1.Text = "Name:";
                label_Title5.Text = "Accepter:";
                label_Title6.Text = "Description:";

            }
            else if (type == typeof(Housework))
            {
                Housework housework = (Housework)activity;

                label_Info1.Text = housework.Name;
                label_Info5.Text = housework.Type;
                label_Info6.Text = housework.Description;

                pictureBox1.Image = imageList1.Images[2];

                label_Title1.Text = "Name:";
                label_Title5.Text = "Type:";
                label_Title6.Text = "Description:";

                string[] questions = { "", "", "" };
                string[] answers = { "", "", "" };
                for(int i = 0; i < housework.Answers.Count; i++)
                {
                    answers[i] = housework.Answers[i];
                }
                for (int i = 0; i < housework.Questions.Count; i++)
                {
                    questions[i] = housework.Questions[i];
                }



                label_Info7.Text = answers[0];
                label_Info8.Text = answers[1];
                label_Info9.Text = answers[2];

                label_Title7.Text = questions[0];
                label_Title8.Text = questions[1];
                label_Title9.Text = questions[2];

            }

            GiveAllChildsDrag(this);
            Coloring();

        }

        private void GiveAllChildsDrag(Control control)
        {
            foreach (Control item in control.Controls)
            {
                if (!item.Name.StartsWith("btn"))
                    item.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CalendarInformationPopUp_MouseMove);
                if (item.Controls != null)
                    GiveAllChildsDrag(item);
            }
        }


        private void Coloring()
        {
            contextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());

            //this.BackColor = GlobalColorConstants.sideBackgroundColor;

            Color color = GlobalColorConstants.GetShadeColor(GlobalColorConstants.GetOccasionColor(occasion[0], 0), 50);
            this.BackColor = color;
            color = GlobalColorConstants.GetShadeColor(GlobalColorConstants.GetOccasionColor(occasion[0], 0), -125);
            this.ForeColor = color;


        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Parent.Controls.Remove(this);
        }

        private void CalendarInformationPopUp_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
