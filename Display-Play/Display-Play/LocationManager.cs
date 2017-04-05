using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_Play
{
    class LocationManager
    {
        static int Width, Height;

        static public void GetFormsValue(int width, int height)
        {
            Width = width;
            Height = height;

        }

        static public void SetLabelLocation(Label label)
        {
            int startXpos;
            int startYpos;

            if (label.Width <= Width)
            {
                startXpos = (Width - label.Width) / 2;
                startYpos = label.Location.Y;
            }
            else
            {
                startXpos = 0;
                startYpos = label.Location.Y;
            }
            label.Location = new Point(startXpos, startYpos);
        }
    }
}
