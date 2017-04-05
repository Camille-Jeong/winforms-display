using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_Play
{
    class MarqueeManager
    {
        static int Width, Height;
        static Label Temp;

        static public void GetFormsValue(int width, int height, Label temp)
        {
            Width = width;
            Height = height;
            Temp = temp;
        }

        static public void Move(Label label)
        {
            int xpos, ypos, _xpos;
            ypos = label.Location.Y;

            if (Temp.Left == 0)
            {
                label.Location = new System.Drawing.Point(0, ypos);
                TempSetting(label);
            }
            else
            {
                xpos = label.Location.X - 1;
                _xpos = Temp.Location.X - 1;
                label.Location = new System.Drawing.Point(xpos, ypos);
                Temp.Location = new System.Drawing.Point(_xpos, ypos);
            }
        }

        static public void TempSetting(Label label)
        {
            int xpos, ypos;
            xpos = label.Right + Width / 3;
            ypos = label.Location.Y;

            Temp.Text = label.Text;
            Temp.Location = new Point(xpos, ypos);
        }

        static public bool CheckCycle(Label label)
        {
            if (label.Left == 0) return true;
            else return false;
        }
    }
}
