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
        int Mode = 0;
        int space = 200;
        int length = 4000;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Artist.Text = "Justin Bieber";
            Title.Text = "Love Yourself (PURPOSE : The Movement)";

            //Artist.Text = "Beauty and the Beast(Beauty and the Beast.OST)";
            //Title.Text = "Ariana Grande && John Legend(Beauty and the Beast.OST)";

            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;

            SetMode();
            SetMarquee();
            SetProgressBar();
            SetDefaultUI(length);
        }
        private void SetDefaultUI(int _length)
        {
            LocationManager.GetFormsValue(this.Width, this.Height);
            LocationManager.SetLabelLocation(Artist);
            LocationManager.SetLabelLocation(Title);
            LocationManager.SetProgressBarLocation(ProgressBar,PlayingTime,RemainingTime);
            LocationManager.SetStatusLabelsLocation(Bitwidth,SamplingRate,FileFormat);
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
            MarqueeManager.GetFormsValue(this.Width, this.Height, temp);
            if (Mode != 0)
            {
                MarqueeManager.SetDefault(space);
            }

        }

        private void SetProgressBar()
        {
            ProgressBarManager.GetFormsValue(ProgressBar, PlayingTime, RemainingTime);
            ProgressBarManager.SetDefault(length);
        }

        private void ProgressBar_Click(object sender, EventArgs e)
        {
            if (ProgressBarManager.Start())
            {
                timer1.Start();
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                SetDefaultUI(length);
            }
               
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MarqueeManager.TimerTick(Mode, Artist, Title);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ProgressBarManager.TimerTick())
            {
                timer1.Stop();
                timer2.Stop();
            }
        }
    }
}