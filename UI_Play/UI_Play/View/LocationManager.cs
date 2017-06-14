using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Play
{
    /**
     * This class set primary location of objects
     **/
    class LocationManager
    {
        static int Width, Height;
        static int startXpos, startYpos;
        static int space;
        static int margin = 30;
        static public int Y1, Y2;

        static public void GetFormsValue(int _Width, int _Height)
        {
            Width = _Width;
            Height = _Height;
        }

        /*Set flow text label location*/
        static public void SetLabelLocation(Label _label1,Label _label2,Label _temp)
        {
            startYpos = (Height / 6);
            if (_label1.Width <= Width)
            {
                startXpos = (Width - _label1.Width) / 2;
            }
            else
            {
                startXpos = margin;
            }
            _label1.Location = new Point(startXpos, startYpos);

            startYpos = _label1.Bottom + _label1.Size.Height;
            if (_label2.Width <= Width)
            {
                startXpos = (Width - _label2.Width) / 2;
            }
            else
            {
                startXpos = margin;
            }
            _label2.Location = new Point(startXpos, startYpos);

            startXpos = Width;
            _temp.Location = new Point(startXpos, startYpos);

            Y1 = _label1.Location.Y;
            Y2 = _label2.Location.Y;
        }

        static public void SetNext(Label _label1, Label _label2, Label _temp)
        {
            startYpos = _label1.Location.Y;
            if (_label1.Width <= Width)
            {
                startXpos = (Width - _label1.Width) / 2;
            }
            else
            {
                startXpos = margin;
            }
            _label1.Location = new Point(startXpos, startYpos);

            startYpos = _label2.Location.Y;
            if (_label2.Width <= Width)
            {
                startXpos = (Width - _label2.Width) / 2;
            }
            else
            {
                startXpos = margin;
            }
            _label2.Location = new Point(startXpos, startYpos);

            startXpos = Width;
            _temp.Location = new Point(startXpos, startYpos);
        }

        /*Set music progress bar location*/
        static public void SetProgressBarLocation(ProgressBar progressbar, Label _label1, Label _label2)
        {
            progressbar.Width = (Width - (_label1.Width + _label2.Width + 80));
            progressbar.Height = _label1.Height;
            startXpos = (Width - progressbar.Width) / 2;
            startYpos = (Height / 5) * 4;
            progressbar.Location = new Point(startXpos, startYpos);

            startXpos = (startXpos - _label1.Width) / 2;
            space = startXpos;
            _label1.Location = new Point(startXpos, startYpos);

            startXpos = Width - (startXpos + _label2.Width);
            _label2.Location = new Point(startXpos, startYpos);
        }

        /*Set stream state label location*/
        static public void SetSongDataLocation(Label _label1, Label _label2, Label _label3)
        {
            startXpos = space;
            startYpos = (Height / 7) * 5;
            _label1.Location = new Point(startXpos, startYpos);

            startXpos = (Width - _label2.Width) / 2;
            _label2.Location = new Point(startXpos, startYpos);

            startXpos = Width - (space + _label3.Width);
            _label3.Location = new Point(startXpos, startYpos);
        }

        static public void SetBlackLocation(Label label1, Label label2, Label black1, Label black2, bool isFirst)
        {
            if(isFirst)
            {
                black1.Location = new Point(label1.Left, label1.Bottom);
                black2.Location = new Point(label2.Left, label2.Bottom);
            }
            else
            {
                black1.Location = new Point(label1.Left, black1.Location.Y);
                black2.Location = new Point(label2.Left, black2.Location.Y);
            }
        }
    }
}
