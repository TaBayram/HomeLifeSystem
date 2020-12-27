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
    public partial class CreateNote : UserControl
    {
        MainScreen mainScreen; 
        public CreateNote(MainScreen mainScreen)
        {
            InitializeComponent();
            this.mainScreen = mainScreen;
            this.dateTimePicker1.MinDate = DateTime.Now.AddHours(1);
            this.dateTimePicker1.MaxDate = DateTime.Now.AddDays(3);

            Coloring();
        }

        private void Coloring()
        {
            button_Cancel.BackColor = GlobalColorConstants.minorButtonColor;
            button_Cancel.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            button_Cancel.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonDownColor;

            button_Create.BackColor = GlobalColorConstants.minorButtonColor;
            button_Create.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            button_Create.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonDownColor;

            textBox1.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            textBox2.BackColor = GlobalColorConstants.minorTextBoxInnerColor;

            dateTimePicker1.CalendarTitleBackColor = GlobalColorConstants.minorTextBoxInnerColor;
        }

        private void button_Create_Click(object sender, EventArgs e)
        {
            label_Error.Text = "";
            label_Error.Visible = false;

            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                label_Error.Text = "Title can't be empty!";
                label_Error.Visible = true;
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                label_Error.Text = "Text can't be empty!";
                label_Error.Visible = true;
                return;
            }





            bool isItPrivate = false;
            string type = "Home";
            if(this.Parent.Name == "panel_PrivateNotes") 
            {
                isItPrivate = true;
                type = "Private";
            }
            NotePaper notePaper = new NotePaper(new Note(mainScreen.User.Name,textBox1.Text,textBox2.Text, type, dateTimePicker1.Value,mainScreen.home.ID,mainScreen.User.ID));
            notePaper.EnableMenuStrip();
            mainScreen.CreateANote(notePaper, isItPrivate);
            ClearControls();

            this.Hide();
        }

        private void button_Cancel_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = dateTimePicker1.MinDate;

            this.Hide();
        }

        private void ClearControls()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            dateTimePicker1.Value = dateTimePicker1.MinDate;
        }
    }
}
