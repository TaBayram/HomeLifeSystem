using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeLifeSystem
{
    public static class GlobalColorConstants
    {
        //Main Stuff
        public static Color mainBackgroundColor = new Color();
        public static Color mainButtonColor = new Color();
        public static Color mainButtonOverColor = new Color();
        public static Color mainButtonDownColor = new Color();
        public static Color mainTextBoxInnerColor = new Color();
        public static Color mainForeColor = new Color();


        //Side Stuff
        public static Color sideBackgroundColor = new Color();
        public static Color sideButtonColor = new Color();
        public static Color sideButtonOverColor = new Color();
        public static Color sideButtonDownColor = new Color();
        public static Color sideTextBoxInnerColor = new Color();
        public static Color sideForeColor = new Color();


        //Misc Stuff
        public static Color minorButtonColor = new Color();
        public static Color minorButtonOverColor = new Color();
        public static Color minorButtonDownColor = new Color();
        public static Color minorTextBoxInnerColor = new Color();
        public static Color minorComboColor = new Color();

        public static Color minorGroupBoxColor = new Color();
        public static Color mainGroupBoxColor = new Color();

        public static Color minorListBoxColor = new Color();
        public static Color mainListBoxColor = new Color();


        public static Color signScreenButtonColor = new Color();
        public static Color signScreenTextBoxInnerColor = new Color();
        public static Color noteHolderBackgroundColor = new Color();
        public static Color aeroBlueColor = new Color();

        public static Color calendarThisDay = new Color();
        public static Color calendarOtherDay = new Color();
        public static Color calendarBackground = new Color();

        public static Color houseworkMainColor = new Color();
        public static Color BillMainColor = new Color();
        public static Color RequestMainColor = new Color();
        public static Color EventMainColor = new Color();
        public static Color BusyTimeMainColor = new Color();
        public static Color FreeTimeMainColor = new Color();


        //header
        public static Color headerBackGroundColor = new Color();
        public static Color headerButtonColor = new Color();



        //MenuStrip

        public static Color menuStrip = Color.FromArgb(245, 246, 255);
        public static Color menuSelected = Color.FromArgb(225, 226, 235);
        public static Color dropDownBackgroundColor = Color.FromArgb(206, 208, 235);
        public static Color borderWhole = Color.FromArgb(225, 226, 235);
        public static Color itemSelected = Color.FromArgb(189, 193, 242);


        //Non Color Attributes

        private static Random random = new Random();


        static GlobalColorConstants()
        {
            mainBackgroundColor = Color.FromArgb(226, 230, 243);
            mainButtonColor = Color.FromArgb(218, 236, 214);
            mainButtonOverColor = Color.FromArgb(168, 245, 164);
            mainButtonDownColor = Color.FromArgb(185, 255, 184);
            mainTextBoxInnerColor = Color.FromArgb(208, 220, 220);
            mainForeColor = Color.FromArgb(0, 0, 75);
            mainListBoxColor = Color.FromArgb(220, 243, 252);
            mainGroupBoxColor = Color.FromArgb(230, 236, 255);

            sideBackgroundColor = Color.FromArgb(226, 236, 243);
            sideButtonColor = Color.FromArgb(218, 242, 214);
            sideButtonOverColor = Color.FromArgb(158, 250, 154);
            sideButtonDownColor = Color.FromArgb(175, 255, 174);
            sideTextBoxInnerColor = Color.FromArgb(208, 226, 220);
            sideForeColor = Color.FromArgb(0, 15, 75);


            minorButtonColor = Color.FromArgb(191, 227, 215);
            minorButtonOverColor = Color.FromArgb(151, 232, 175);
            minorButtonDownColor = Color.FromArgb(171, 237, 195);
            minorTextBoxInnerColor = Color.FromArgb(237, 247, 245);
            minorComboColor = Color.FromArgb(175, 213, 206);
            minorListBoxColor = Color.FromArgb(213, 239, 242);
            minorGroupBoxColor = Color.FromArgb(213, 237, 242);


            headerBackGroundColor = Color.FromArgb(235, 236, 255);
            headerButtonColor = Color.FromArgb(245, 246, 255);

            signScreenButtonColor = Color.FromArgb(157, 224, 144);
            signScreenTextBoxInnerColor = Color.FromArgb(199, 237, 191);

            noteHolderBackgroundColor = Color.FromArgb(160, 187, 187);

            aeroBlueColor = Color.FromArgb(197, 252, 227);


            calendarThisDay = Color.FromArgb(208, 245, 236);
            calendarOtherDay = Color.FromArgb(203, 233, 224);
            calendarBackground = Color.FromArgb(234, 223, 245);


            menuStrip = Color.FromArgb(245, 246, 255);
            menuSelected = Color.FromArgb(225, 226, 235);
            dropDownBackgroundColor = Color.FromArgb(206, 208, 235);
            borderWhole = Color.FromArgb(225, 226, 235);
            itemSelected = Color.FromArgb(189, 193, 242);


            houseworkMainColor = Color.FromArgb(61, 129, 255);
            BillMainColor = Color.FromArgb(25, 255, 61);
            RequestMainColor = Color.FromArgb(239, 255, 61);
            EventMainColor = Color.FromArgb(158, 255, 61);
            BusyTimeMainColor = Color.FromArgb(255, 110, 61);
            FreeTimeMainColor = Color.FromArgb(75, 250, 250);



            // DarkMode();

        }


        public static void DarkMode()
        {
            Type type = typeof(GlobalColorConstants);
            FieldInfo[] fields = type.GetFields(BindingFlags.Static | BindingFlags.Public);

            foreach (FieldInfo fi in fields)
            {
                if (fi.GetValue(null).GetType() != typeof(Color)) continue;

                Color color = (Color)fi.GetValue(null);

                double r = color.R;
                double g = color.G;
                double b = color.B;

                color = Color.FromArgb((int)(r/2), (int)(g / 1.5), (int)(b / 1.25));

                fi.SetValue(null, color);

            }

            mainForeColor = Color.Green;
            sideForeColor = Color.Blue;
            

        }


        public static Color GetRandomColor(int min=0, int max=256)
        {
            if (min < 0 || max > 256) return Color.White;
            if (max < min) return Color.White;
            int randomR = random.Next(min, max);
            int randomG = random.Next(min, max);
            int randomB = random.Next(min, max);

            Color color = Color.FromArgb(randomR, randomG, randomB);


            return color;

        }
        public static Color GetRandomColor(int Rmin = 0, int Rmax = 256, int Gmin = 0, int Gmax = 256, int Bmin = 0, int Bmax = 256)
        {
            if (Rmin < 0 || Rmax > 256 || Gmin < 0 || Gmax > 256 || Bmin < 0 || Bmax > 256) return Color.White;
            
            int randomR = random.Next(Rmin, Rmax);
            int randomG = random.Next(Gmin, Gmax);
            int randomB = random.Next(Bmin, Bmax);

            Color color = Color.FromArgb(randomR, randomG, randomB);


            return color;

        }




        public static Color GetOccasionColor(object activity, int dayDifference, int hourDifference = 0)
        {
            Color color = Color.White;

            if (activity.GetType() == typeof(Housework))
            {
                color = houseworkMainColor;
            }
            else if (activity.GetType() == typeof(Bill))
            {
                color = BillMainColor;
            }
            else if (activity.GetType() == typeof(Request))
            {
                color = RequestMainColor;
            }
            else if (activity.GetType() == typeof(Event))
            {
                color = EventMainColor;
            }
            else if (activity.GetType() == typeof(BusyTime))
            {
                color = BusyTimeMainColor;
            }
            else if (activity.GetType() == typeof(FreeTime))
            {
                color = FreeTimeMainColor;
            }

            if (dayDifference != 0)
            {
                if(dayDifference < 0)
                {
                    color = Color.FromArgb(color.R / 2, color.G / 2, color.B / 2);
                }
                else
                {
                    if (dayDifference > 15) dayDifference = 15;

                    int redBonus = (color.R * dayDifference * 2) / 100;
                    int greenBonus = (color.G * dayDifference * 2) / 100;
                    int blueBonus = (color.B * dayDifference * 2) / 100;

                    int red = (color.R + redBonus); if (red > 255) red = 255;
                    int green = (color.G + greenBonus); if (green > 255) green = 255;
                    int blue = (color.B + blueBonus); if (blue > 255) blue = 255;

                    color = Color.FromArgb(red, green, blue);
                }

            }
            else if(hourDifference != 0)
            {
                if (hourDifference < 0)
                {
                    color = Color.FromArgb((int)(color.R / 1.25), (int)(color.G / 1.25), (int)(color.B / 1.25));
                }
                else
                {
                    if (hourDifference > 24) hourDifference = 24;

                    int redBonus = (color.R * hourDifference/2) / 100;
                    int greenBonus = (color.G * hourDifference/2) / 100;
                    int blueBonus = (color.B * hourDifference/2) / 100;

                    int red = (color.R + redBonus); if (red > 255) red = 255;
                    int green = (color.G + greenBonus); if (green > 255) green = 255;
                    int blue = (color.B + blueBonus); if (blue > 255) blue = 255;

                    color = Color.FromArgb(red, green, blue);
                }
            }


            return color;
        }

        public static Color GetShadeColor(Color color, int scale)
        {

            int redBonus = color.R + scale;
            int greenBonus = color.G + scale;
            int blueBonus = color.B +scale;


            int red =  redBonus; if (red > 255) red = 255; if (red < 0) red = 0;
            int green =  greenBonus; if (green > 255) green = 255; if (green < 0) green = 0;
            int blue =  blueBonus; if (blue > 255) blue = 255; if (blue < 0) blue = 0;

            color = Color.FromArgb(red, green, blue);



            return color;
        }



    }





    class MenuColorTable : ProfessionalColorTable
    {
        Color menuStrip = GlobalColorConstants.menuStrip;
        Color menuSelected = GlobalColorConstants.menuSelected;
        Color dropDownBackgroundColor = GlobalColorConstants.dropDownBackgroundColor;
        Color borderWhole = GlobalColorConstants.borderWhole;
        Color itemSelected = GlobalColorConstants.itemSelected;
        public MenuColorTable()
        {
            // see notes
            base.UseSystemColors = false;
        }

        //COLOR OF THE BORDER WHOLE 
        public override System.Drawing.Color MenuBorder
        {
            get { return borderWhole; }
        }

        //COLOR OF THE DROP DOWN BACKGROUND
        public override System.Drawing.Color ToolStripDropDownBackground
        {
            get { return dropDownBackgroundColor; }
        }

        //COLOR OF THE SELECTED ITEM BORDER
        public override System.Drawing.Color MenuItemBorder
        {
            get { return itemSelected; }
        }

        //COLOR OF THE ITEM BUTTON WHEN YOU HOVER
        public override Color MenuItemSelected
        {
            get { return itemSelected; }
        }

        //COLOR OF THE MENU HOVER
        public override Color MenuItemSelectedGradientBegin
        {
            get { return menuSelected; }
        }
        public override Color MenuItemSelectedGradientEnd
        {
            get { return menuSelected; }
        }

        //COLOR OF THE MENU BAR ON HEADER
        public override Color MenuStripGradientBegin
        {
            get { return menuStrip; }
        }
        public override Color MenuStripGradientEnd
        {
            get { return menuStrip; }
        }


        //COLOR OF THE MENU WHEN YOU OPEN THE DROPDOWN
        public override Color MenuItemPressedGradientBegin
        {
            get { return dropDownBackgroundColor; }
        }
        public override Color MenuItemPressedGradientEnd
        {
            get { return dropDownBackgroundColor; }
        }

        //LEFT SQUARE FOR ICON
        public override Color ImageMarginGradientBegin
        {
            get { return dropDownBackgroundColor; }
        }
        public override Color ImageMarginGradientMiddle
        {
            get { return dropDownBackgroundColor; }
        }
        public override Color ImageMarginGradientEnd
        {
            get { return dropDownBackgroundColor; }
        }


    }


}