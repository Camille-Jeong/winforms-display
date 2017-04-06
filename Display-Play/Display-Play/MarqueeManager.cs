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
        static int Tcnt;
        static int Status;
        static int WaitTime;

        static public void GetFormsValue(int width, int height, Label _temp)
        {
            Width = width;
            Height = height;
            Temp = _temp;
        }

        static public void SetDefault(int _waitTime)
        {
            Status = 0;
            Tcnt = 0;
            WaitTime = _waitTime;

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

        static public void TimerTick(int Mode, Label Artist, Label Title)
        {
            if (Mode == 1)
            {
                if (CheckCycle(Artist))
                {
                    if (Status == 0)
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
