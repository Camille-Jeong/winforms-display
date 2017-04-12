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
        static int startXpos, startYpos;
        static int space;

        static public void GetFormsValue(int width, int height)
        {
            Width = width;
            Height = height;

        }

        static public void SetLabelLocation(Label label)
        {
            if (label.Name == "Artist")
                startYpos = (Height / 5);
            else
                startYpos = (Height / 7) * 3;
            if (label.Width <= Width)
            {
                startXpos = (Width - label.Width) / 2;
            }
            else
            {
                startXpos = 0;
            }
            label.Location = new Point(startXpos, startYpos);
        }

        static public void SetProgressBarLocation(ProgressBar progressbar, Label _label1, Label _label2)
        {
            progressbar.Width = (Width - (_label1.Width + _label2.Width + 80));
            startXpos = (Width - progressbar.Width) / 2;
            startYpos = (Height / 5) * 4;
            progressbar.Location = new Point(startXpos, startYpos);

            startXpos = (startXpos - _label1.Width) / 2;
            space = startXpos;
            _label1.Location = new Point(startXpos, startYpos);

            startXpos = Width - (startXpos + _label2.Width);
            _label2.Location = new Point(startXpos, startYpos);
        }

        static public void SetStatusLabelsLocation(Label _label1, Label _label2, Label _label3)
        {
            startXpos = space;
            startYpos = (Height / 7) * 5;
            _label1.Location = new Point(startXpos, startYpos);

            startXpos = (Width - _label2.Width) / 2;
            _label2.Location = new Point(startXpos, startYpos);

            startXpos = Width - (space + _label3.Width);
            _label3.Location = new Point(startXpos, startYpos);
        }
    }
}
