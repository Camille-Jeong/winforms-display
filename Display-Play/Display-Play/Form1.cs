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
            Artist.Text = "Justin Bieber";
            Title.Text = "Love Yourself (PURPOSE : The Movement)";

            SetMode();
            SetDefaultUI();
            SetMarquee();
            
        }
        private void SetDefaultUI()
        {
            LocationManager.GetFormsValue(this.Width, this.Height);
            LocationManager.SetLabelLocation(Artist);
            LocationManager.SetLabelLocation(Title);
        }

        private void SetMode()
        {
            if (Artist.Width > this.Width)
            {
                if (Title.Width > this.Width)
                    Mode = 3;
                else
                    Mode = 1;
            }
            else if (Title.Width > this.Width)
                Mode = 2;
            else
                Mode = 0;
        }

        private void SetMarquee()
        {
            Status = 0;
            MarqueeManager.GetFormsValue(this.Width, this.Height, temp);
            if (Mode != 0)
            {
                timer1.Start();
            }

        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(Mode == 1)
            {
                if (MarqueeManager.CheckCycle(Artist))
                {
                    if(Status == 0)
                    {
                        MarqueeManager.TempSetting(Artist);
                        Status = 1;
                    }
                    else
                    {
                        if (Tcnt == WaitTime)
                        {
                            MarqueeManager.Move(Artist);
                            Tcnt = 0;
                        }
                        else
                            Tcnt++;
                    }                    
                }
                else MarqueeManager.Move(Artist);
            }
            else if(Mode == 2)
            {
                if (MarqueeManager.CheckCycle(Title))
                {
                    if (Status == 0)
                    {
                        MarqueeManager.TempSetting(Title);
                        Status = 1;
                    }
                    else
                    {
                        if (Tcnt == WaitTime)
                        {
                            MarqueeManager.Move(Title);
                            Tcnt = 0;
                        }
                        else
                            Tcnt++;
                    }
                }
                else MarqueeManager.Move(Title);
            }
            else if(Mode == 3)
            {
                if (MarqueeManager.CheckCycle(Artist))
                {
                    if (Status == 0)
                    {
                        MarqueeManager.TempSetting(Artist);
                        Status = 1;
                    }
                    else if (Status == 1)
                    {
                        if (Tcnt == WaitTime)
                        {
                            MarqueeManager.Move(Artist);
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
                        MarqueeManager.TempSetting(Title);
                        MarqueeManager.Move(Title);
                    }
                    else if (Status == 4)
                    {
                        if (MarqueeManager.CheckCycle(Title))
                        {
                            Status = 0;
                        }
                        else MarqueeManager.Move(Title);
                    }
                }
                else MarqueeManager.Move(Artist);
            }
        }
    }
}