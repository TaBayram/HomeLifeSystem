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
    public partial class NotePaper : UserControl
    {
        Note note;

        public Note Note { get => note; set => note = value; }

        public NotePaper(Note note)
        {
            InitializeComponent();
            this.Note = note;
            Write();
            Coloring();

            contextMenuStrip1.Renderer = new ToolStripProfessionalRenderer(new MenuColorTable());

        }

        private void Coloring()
        {
            var random = new Random();
            int randomPanel1 = random.Next(5, 20);
            int randomPanel2 = random.Next(10, 40);
            Color randomColor = GlobalColorConstants.GetRandomColor(120, 256);


            Color mainRandomColor = randomColor;
            Color panelRandomColor = Color.FromArgb(randomColor.R - randomPanel1, randomColor.G - randomPanel1, randomColor.B - randomPanel1);
            Color panel2RandomColor = Color.FromArgb(randomColor.R - randomPanel2, randomColor.G - randomPanel2, randomColor.B - randomPanel2);
            this.BackColor = mainRandomColor;
            this.panel_1.BackColor = panelRandomColor;
            this.panel_2.BackColor = panelRandomColor;
            this.panel_4.BackColor = panel2RandomColor;



        }

        private void Write()
        {
            label_Author.Text = Note.AuthorName;
            label_CreatedDate.Text = Note.CreatedDate.ToShortDateString();

            double totalDays = Math.Round((Note.ExpiringDate - DateTime.Now).TotalDays,2);
            double totalHours = Math.Round((Note.ExpiringDate - DateTime.Now).TotalHours, 2);
            double totalMinutes = Math.Round((Note.ExpiringDate - DateTime.Now).TotalMinutes, 2);
            if (totalDays >= 1)
                label_RemainingDays.Text = "Remaining: " + Math.Round(totalDays).ToString() + " Days";
            else if (totalDays < 1 && totalHours >= 1)
                label_RemainingDays.Text = "Remaining: " + Math.Round(totalHours).ToString() + " Hours";
            else
            {
                label_RemainingDays.Text = "Remaining: " + Math.Round(totalMinutes).ToString() + " Minutes";
            }
            label_Text.Text = Note.Text;
            label_Title.Text = Note.Title;
        }

        public void EnableMenuStrip()
        {
            this.ContextMenuStrip = contextMenuStrip1;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Note.RemoveFromDatabase();
            this.Controls.Remove(this);
            Dispose();
        }

        public void RefreshExpire()
        {
            if(note.HasExpired(false)) this.Parent.Controls.Remove(this);

            double totalDays = Math.Round((Note.ExpiringDate - DateTime.Now).TotalDays, 2);
            double totalHours = Math.Round((Note.ExpiringDate - DateTime.Now).TotalHours, 2);
            double totalMinutes = Math.Round((Note.ExpiringDate - DateTime.Now).TotalMinutes, 2);
            if (totalDays >= 1)
                label_RemainingDays.Text = "Remaining: " + Math.Round(totalDays).ToString() + " Days";
            else if (totalDays < 1 && totalHours >= 1)
                label_RemainingDays.Text = "Remaining: " + Math.Round(totalHours).ToString() + " Hours";
            else
            {
                label_RemainingDays.Text = "Remaining: " + Math.Round(totalMinutes).ToString() + " Minutes";
            }
        }
    }
}
