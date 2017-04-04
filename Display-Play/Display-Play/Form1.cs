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
        int originalArtistPos;
        int originalTitlePos;
        int Tcnt = 0;
        int Mode = 0;
        int Status = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Mode = 0;
            Artist.Text = "this is camille and duke's project";
            Title.Text = "this is example display of play view";
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
            label1.Text = Mode.ToString();
            //MvCycle = this.Width;
            if (Mode != 0)
            {
                originalArtistPos = Artist.Left;
                originalTitlePos = Title.Left;
                timer1.Start();
            }
        }

        private void Move(Label label)
        {
            int xpos, ypos;
            if(label.Right <= 0)
            {
                xpos = this.Width;
                ypos = label.Location.Y;
                label.Location = new Point(xpos, ypos);
            }
            else
            {
                xpos = label.Location.X - 1;
                ypos = label.Location.Y;
                label.Location = new System.Drawing.Point(xpos, ypos);
            }
        }

        private bool CheckCycle(Label label)
        {
            int _pos;
            if (string.Equals(label.Name, "Artist")) _pos = originalArtistPos;
            else _pos = originalTitlePos;

            if (label.Left == _pos) return true;
            else return false;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Mode == 1)
            {
                if (CheckCycle(Artist))
                {
                    if (Tcnt == 200)
                    {
                        Move(Artist);
                        Tcnt = 0;
                    }
                    else
                        Tcnt++;
                }
                else Move(Artist);
            }
            else if(Mode == 2)
            {
                if (CheckCycle(Title))
                {
                    if (Tcnt == 200)
                    {
                        Move(Title);
                        Tcnt = 0;
                    }
                    else
                        Tcnt++;
                }
                else Move(Title);
            }
            else if(Mode == 3)
            {
                if (CheckCycle(Artist))
                {
                    if(Status == 0)
                    {
                        if (Tcnt == 200)
                        {
                            Move(Artist);
                            Tcnt = 0;
                            Status = 1;
                        }
                        else
                            Tcnt++;
                    }
                    else if(Status == 1)
                    {
                        Status = 2;
                        Move(Title);
                    }
                    else
                    {
                        if (CheckCycle(Title))
                        {
                            if (Tcnt == 200)
                            {
                                Move(Artist);
                                Tcnt = 0;
                            }
                            else
                                Tcnt++;
                        }
                        else Move(Title);
                    }
                }
                else Move(Artist);
            }
        }
    }
}