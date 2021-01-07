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
    public partial class CreateHome : UserControl
    {
        List<Room> rooms = new List<Room>();
        string name;
        string address;
        MainScreen form;
        Person user;

        public CreateHome(MainScreen form, Person user)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.form = form;
            this.user = user;

            Coloring();
        }

        private void Coloring()
        {
            btn_DeleteRoom.BackColor = GlobalColorConstants.minorButtonColor;
            btn_AddRoom.BackColor = GlobalColorConstants.minorButtonColor;
            btn_Cancel.BackColor = GlobalColorConstants.mainButtonColor;
            btn_Create.BackColor = GlobalColorConstants.mainButtonColor;
            

            btn_AddRoom.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            btn_AddRoom.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            btn_DeleteRoom.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            btn_DeleteRoom.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;

            btn_Cancel.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_Cancel.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;
            btn_Create.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_Create.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            tb_Address.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            tb_HomeName.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            tb_RoomName.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            comboBox_RoomType.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            listBox_Rooms.BackColor = GlobalColorConstants.minorTextBoxInnerColor; 
          


        }

       

        private void btn_AddRoom_Click(object sender, EventArgs e)
        { 
            lbl_RoomTypeError.Visible = false;
            lbl_RoomNameError.Visible = false;
            lbl_HomeNameError.Visible = false;

            if (comboBox_RoomType.SelectedIndex == -1)
            {
                lbl_RoomTypeError.Visible = true;
                lbl_RoomTypeError.Text = "Room type can't be nothing!";
                return;
            }

            string type = comboBox_RoomType.Text;
            string name;
            if (tb_RoomName.Text.Trim() != "")
            {
                if(IsTheNameUnique(tb_RoomName.Text))
                    name = tb_RoomName.Text;
                else
                {
                    lbl_RoomNameError.Visible = true;
                    lbl_RoomNameError.Text = "The name already exists!";
                    return;
                }
            }
            else
            {
                name = FindAvailableRoomName(type, 0);
            }
            Room newRoom = new Room(name, type);
            listBox_Rooms.Items.Add(name + $"({type})");
            rooms.Add(newRoom);
            
        }

        private string FindAvailableRoomName(string type, int number)
        {
            string name = type;
            if (number != 0) name += " " + number;
            foreach (Room room in rooms)
            {
                if (room.Name.StartsWith(name))
                {
                    name = FindAvailableRoomName(type, number+1);
                }
            }
            return name;
        }
        private bool IsTheNameUnique(string name)
        {
            foreach (Room room in rooms)
            {
                if (room.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            lbl_HomeNameError.Visible = false;
            lbl_RoomListError.Visible = false;

            if (tb_HomeName.Text == null || tb_HomeName.Text.Trim() == "")
            {
                lbl_HomeNameError.Visible = true;
                lbl_HomeNameError.Text = "Name can't be empty!";
                return;
            }
            if (listBox_Rooms.Items.Count == 0)
            {
                lbl_RoomListError.Visible = true;
                lbl_RoomListError.Text = "Please put rooms!";
                return;
            }

            name = tb_HomeName.Text;
            
            if (tb_Address.Text != "") 
            {
                address = tb_Address.Text;
            }
            else 
                address = " ";


            name = tb_HomeName.Text;
            Home home = new Home(user, name, rooms,address);

            form.ShowHomeSidebar(home);
            
            
            this.Parent.Controls.Remove(this);
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            form.HideFindingHome(false);
            this.Parent.Controls.Remove(this);
            
        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {
            if (listBox_Rooms.SelectedIndex != -1)
            {
                rooms.RemoveAt(listBox_Rooms.SelectedIndex);
                listBox_Rooms.Items.Remove(listBox_Rooms.SelectedItems[0]);
            }
        }
    }
}
