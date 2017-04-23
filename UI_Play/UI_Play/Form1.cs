using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Play
{
    public partial class Form1 : Form
    {
        //Get Moniter's Width and Height
        int _Width = SystemInformation.VirtualScreen.Width;
        int _Height = SystemInformation.VirtualScreen.Height;

        string _Artist, _Title;
        int Length, WaitTime, IsPause = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Make Form Maximize and remove MenuBar
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            //
            this.Width = _Width;
            this.Height = _Height;

            SetManagers();
            SetData();
            SetLocation(Length);
        }

        private void SetManagers()
        {
            MarqueeManager.GetFormsValue(Width, Height, Artist, Title, Temp);
            ProgressBarManager.GetFormsValue(ProgressBar, PlayingTime, RemainingTime);
            LocationManager.GetFormsValue(this.Width, this.Size.Height);
        }

        //We will change SetData() to GetData() that get Data from TCP socket communication.
        private void SetData()
        {
            Length = 30;
            WaitTime = 200;
            _Artist = "Justin Bieber";
            _Title = "Test Love Yourself (PURPOSE : The Movement)";
            MarqueeManager.SetDefault(_Artist, _Title, WaitTime);
            ProgressBarManager.SetDefault(Length);
        }

        private void SetLocation(int _length)
        {
            LocationManager.SetLabelLocation(Artist);
            LocationManager.SetLabelLocation(Title);
            LocationManager.SetProgressBarLocation(ProgressBar, PlayingTime, RemainingTime);
            LocationManager.SetStatusLabelsLocation(Bitwidth, SamplingRate, FileFormat);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            MarqueeManager.TimerTick();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (ProgressBarManager.TimerTick())
            {
                timer1.Stop();
                timer2.Stop();
            }
        }

        //We will change this Func to use HW Button
        private void ProgressBar_Click(object sender, EventArgs e)
        {
            if (IsPause % 2 == 0)
            {
                timer1.Start();
                ProgressBarManager.Start(IsPause);
                timer2.Start();
            }
            else
            {
                timer1.Stop();
                timer2.Stop();
                SetLocation(Length);
            }
            IsPause = IsPause + 1;
        }
    }
}
