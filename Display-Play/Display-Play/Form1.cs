using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_Play
{
    public partial class Form1 : Form
    {
        int Tcnt = 0;
        int Mode = 0;
        int Status = 0;
        int WaitTime = 200; 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mode = 0;
            Artist.Text = "this is camille and duke's project";
            Title.Text = "And this is project's play view with flow text";
            setLocation(Artist);
            setLocation(Title);
            Action();
            
        }

        private void setLocation(Label label)
        {
            int startXpos;
            int startYpos;

            if(label.Width <= this.Width)
            {
                startXpos = (this.Width - label.Width) / 2;
                startYpos = label.Location.Y;
            }
            else
            {
                startXpos = 0;
                startYpos = label.Location.Y;
                if (Mode == 0 && string.Equals(label.Name, "Artist")) Mode = 1;
                else if (Mode == 0 && string.Equals(label.Name, "Title")) Mode = 2;
                else if (Mode == 1) Mode = 3;
            }
            label.Location = new Point(startXpos, startYpos);
        }

        private void Action()
        {
            Status = 0;
            if (Mode != 0)
            {
                timer1.Start();
            }
        }

        private void Move(Label label)
        {
            int xpos, ypos, _xpos;
            ypos = label.Location.Y;

            if (temp.Left == 0)
            {
                label.Location = new System.Drawing.Point(0, ypos);
                TempSetting(label);
            }
            else
            {
                xpos = label.Location.X - 1;
                _xpos = temp.Location.X - 1;
                label.Location = new System.Drawing.Point(xpos, ypos);
                temp.Location = new System.Drawing.Point(_xpos, ypos);
            }
        }

        private void TempSetting(Label label)
        {
            int xpos, ypos;
            xpos = label.Right + this.Width / 3;
            ypos = label.Location.Y;

            temp.Text = label.Text;
            temp.Location = new Point(xpos, ypos);
        }

        private bool CheckCycle(Label label)
        {
            if (label.Left == 0) return true;
            else return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Mode == 1)
            {
                if (CheckCycle(Artist))
                {
                    if(Status == 0)
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
            else if(Mode == 2)
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
            else if(Mode == 3)
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