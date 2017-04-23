using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Play
{
    class MarqueeManager
    {
        static int Width, Height;
        static Label Artist, Title, Temp;
        static int Mode, Tcnt, Status, WaitTime;

        static public void GetFormsValue(int _Width, int _Height,Label _Artist, Label _Title, Label _temp)
        {
            Width = _Width;
            Height = _Height;
            Artist = _Artist;
            Title = _Title;
            Temp = _temp;
        }

        static public void SetMode()
        {
            if (Artist.Width > Width)
            {
                if (Title.Width > Width)
                    Mode = 3;
                else
                    Mode = 1;
            }
            else if (Title.Width > Width)
                Mode = 2;
            else
                Mode = 0;
        }

        static public void SetDefault(string _Artist, string _Title, int _WaitTime)
        {
            Status = 0;
            Tcnt = 0;
            Artist.Text = _Artist;
            Title.Text = _Title;
            WaitTime = _WaitTime;

            SetMode();
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
                xpos = label.Location.X - 2;
                _xpos = Temp.Location.X - 2;
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

        static public void TimerTick()
        {
            if (Mode == 1)//Artist 
            {
                if (CheckCycle(Artist))
                {
                    if (Status == 0)//start
                    {
                        TempSetting(Artist);
                        Status = 1;
                    }
                    else
                    {
                        if (Tcnt == WaitTime)
                        {
                            Move(Artist);
                            Tcnt = 0;
                        }
                        else
                            Tcnt++;
                    }
                }
                else Move(Artist);
            }
            else if (Mode == 2)
            {
                if (CheckCycle(Title))
                {
                    if (Status == 0)
                    {
                        TempSetting(Title);
                        Status = 1;
                    }
                    else
                    {
                        if (Tcnt == WaitTime)
                        {
                            Move(Title);
                            Tcnt = 0;
                        }
                        else
                            Tcnt++;
                    }
                }
                else Move(Title);
            }
            else if (Mode == 3)
            {
                if (CheckCycle(Artist))
                {
                    if (Status == 0)
                    {
                        TempSetting(Artist);
                        Status = 1;
                    }
                    else if (Status == 1)
                    {
                        if (Tcnt == WaitTime)
                        {
                            Move(Artist);
                            Tcnt = 0;
                            Status = 2;
                        }
                        else
                            Tcnt++;
                    }
                    else if (Status == 2)
                    {
                        if (Tcnt == 50)
                        {
                            Tcnt = 0;
                            Status = 3;
                        }
                        else
                            Tcnt++;
                    }
                    else if (Status == 3)
                    {
                        Status = 4;
                        TempSetting(Title);
                        Move(Title);
                    }
                    else if (Status == 4)
                    {
                        if (CheckCycle(Title))
                        {
                            Status = 0;
                        }
                        else Move(Title);
                    }
                }
                else Move(Artist);
            }
        }
    }
}
