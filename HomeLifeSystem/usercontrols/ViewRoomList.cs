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
    public partial class ViewRoomList : UserControl
    {
        Home home;
        MainScreen mainScreen;
        List<Room> deletedRoom = new List<Room>();
        List<Room> addedRooms = new List<Room>();
        List<Room> rooms = new List<Room>();
        public ViewRoomList(MainScreen mainScreen)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.mainScreen = mainScreen;
            this.home = mainScreen.home;
            this.rooms = home.Rooms;
            


            DrawRooms();
            Coloring();

        }

        private void DrawRooms()
        {
            listBox_CurrentRooms.Items.Clear();
            listBox_DeletedRooms.Items.Clear();
            foreach (Room room in rooms)
            {
                listBox_CurrentRooms.Items.Add(room.Name + "(" + room.Type + ")");

            }
        }

        private void Coloring()
        {
            btn_AddRoom.BackColor = GlobalColorConstants.minorButtonColor;
            btn_DeleteRoom.BackColor = GlobalColorConstants.minorButtonColor;
            btn_RestoreRoom.BackColor = GlobalColorConstants.minorButtonColor;
            btn_AddRoom.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            btn_AddRoom.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            btn_DeleteRoom.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            btn_DeleteRoom.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;
            btn_RestoreRoom.FlatAppearance.MouseOverBackColor = GlobalColorConstants.minorButtonOverColor;
            btn_RestoreRoom.FlatAppearance.MouseDownBackColor = GlobalColorConstants.minorButtonDownColor;


            btn_DoneView.BackColor = GlobalColorConstants.mainButtonColor;
            btn_DoneView.FlatAppearance.MouseOverBackColor = GlobalColorConstants.mainButtonOverColor;
            btn_DoneView.FlatAppearance.MouseDownBackColor = GlobalColorConstants.mainButtonDownColor;

            listBox_CurrentRooms.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            listBox_DeletedRooms.BackColor = GlobalColorConstants.minorTextBoxInnerColor;
            comboBox_RoomType.BackColor = GlobalColorConstants.minorTextBoxInnerColor;

            tb_RoomName.BackColor = GlobalColorConstants.minorTextBoxInnerColor;

        }

        private void btn_DeleteRoom_Click(object sender, EventArgs e)
        {
            if (listBox_CurrentRooms.SelectedItems.Count > 0)
            {
                foreach (var item in listBox_CurrentRooms.SelectedItems)
                {
                    listBox_DeletedRooms.Items.Add(item);
                    
                }

                for(int i = listBox_CurrentRooms.SelectedItems.Count-1; i >= 0; i--  )
                {
                    listBox_CurrentRooms.Items.Remove(listBox_CurrentRooms.SelectedItems[i]);
                }
            }
        }

        private void btn_RestoreRoom_Click(object sender, EventArgs e)
        {
            if (listBox_DeletedRooms.SelectedItems.Count > 0)
            {
                foreach (var item in listBox_DeletedRooms.SelectedItems)
                {
                    listBox_CurrentRooms.Items.Add(item);
                    
                }

                for (int i = listBox_DeletedRooms.SelectedItems.Count - 1; i >= 0; i--)
                {
                    listBox_DeletedRooms.Items.Remove(listBox_DeletedRooms.SelectedItems[i]);
                }
            }
        }

        private void btn_AddRoom_Click(object sender, EventArgs e)
        {
            lbl_RoomTypeError.Visible = false;
            lbl_RoomListError.Visible = false;

            if (comboBox_RoomType.SelectedIndex == -1)
            {
                lbl_RoomTypeError.Visible = true;
                lbl_RoomTypeError.Text = "Room type can't be nothing!";
                return;
            }

            string type = comboBox_RoomType.Text;
            string name = type;
            if (tb_RoomName.Text.Trim() != "")
            {
                if (IsTheNameUnique(tb_RoomName.Text))
                    name = tb_RoomName.Text;
                else
                {
                    lbl_RoomListError.Visible = true;
                    lbl_RoomListError.Text = "The name already exists!";
                    return;
                }
            }
            else
            {
                name = FindAvailableRoomName(type, 0);
            }
            Room newRoom = new Room(name, type);
            listBox_CurrentRooms.Items.Add(name + $"({type})");
            addedRooms.Add(newRoom);
        }
        private string FindAvailableRoomName(string type, int number)
        {
            string name = type;
            if (number != 0) name += " " + number;
            foreach (Room room in rooms)
            {
                if (room.Name.StartsWith(name))
                {
                    name = FindAvailableRoomName(type, number + 1);
                }
            }
            foreach (Room room in addedRooms)
            {
                if (room.Name.StartsWith(name))
                {
                    name = FindAvailableRoomName(type, number + 1);
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
            foreach (Room room in addedRooms)
            {
                if (room.Name == name)
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_DoneView_Click(object sender, EventArgs e)
        {
            lbl_RoomListError.Visible = false;

            if (listBox_CurrentRooms.Items.Count == 0)
            {
                lbl_RoomListError.Visible = true;
                lbl_RoomListError.Text = "Please put rooms!";
                return;
            }


            foreach (String item in listBox_DeletedRooms.Items)
            {
                string name = item.Substring(0, item.IndexOf("("));
                foreach (Room room in rooms)
                {
                    if(room.Name == name)
                    {
                        room.RemoveFromDatabase();
                        rooms.Remove(room);
                        break;
                    }
                        
                }
                
            }
            listBox_DeletedRooms.Items.Clear();

            foreach (Room room in addedRooms)
            {
                room.HomeID = home.ID;
                room.AddToDatabase();
            }



            home.Rooms.AddRange(addedRooms);
            
            mainScreen.HideThisShowMainScreen(this);
            
        }
    }
}
