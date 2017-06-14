using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualEffects;
using VisualEffects.Easing;
using VisualEffects.Animations.Effects;
using UI_Play.View;
using UI_Play.Animation;

namespace UI_Play
{
    public partial class Form1 : Form
    {
        //Get Moniter's Width and Height
        int _Width = SystemInformation.VirtualScreen.Width;
        int _Height = SystemInformation.VirtualScreen.Height;

        int WaitTime, _SongId;
        string _PP;

        string Adress = "192.168.137.241";

        Data data;
        Status status;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Make Form Maximize and remove MenuBar
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;

            this.Width = _Width;
            this.Height = _Height;

            SetManagers();

            GetData();
            SetData();
            SetLocation();

            StatusConnection.Start();
        }

        private void SetManagers()
        {
            SocketManager.ConnectMPD(Adress);
            MarqueeManager.GetFormsValue(Width, Height, Artist, Title, Temp);
            SongDataManager.GetFormsValue(BitWidth, SamplingRate, FileFormat);
            ProgressBarManager.GetFormsValue(ProgressBar, PlayingTime, RemainingTime);
            LocationManager.GetFormsValue(this.Width, this.Size.Height);
            BlacksManager.GetFormsValue(Black1, Black2);
        }

        //We will change SetData() to Comunicate() that get Data from TCP socket communication.

        private void GetData()
        {
            data = DataManager.GetData();
            status = StatusManager.GetStatus();

            _SongId = status.SongID;
            _PP = status.PP;
        }
        private void SetData()
        {
            WaitTime = 200;

            MarqueeManager.SetData(data.Artist, data.Title, WaitTime);
            SongDataManager.SetData(data.BitWidth, data.SamplingRate, data.FileFormat);
            ProgressBarManager.SetData(data.Length, status.Time);
            BlacksManager.SetBlack(Artist,Title);
        }

        private void SetLocation()
        {
            LocationManager.SetLabelLocation(Artist, Title, Temp);
            LocationManager.SetProgressBarLocation(ProgressBar, PlayingTime, RemainingTime);
            LocationManager.SetSongDataLocation(BitWidth, SamplingRate, FileFormat);
            LocationManager.SetBlackLocation(Artist, Title, Black1, Black2, true);
        }

        private async void StatusConnection_Tick(object sender, EventArgs e)
        {
            status = StatusManager.GetStatus();
            if (_SongId != status.SongID)
            {
                GetData();

                SocketManager.Comunicate("stop");
                Marquee.Stop();
                SetLocation();

                AnimationManager.SinkLabel(Artist, Title, Black1.Top, Black2.Top);
                await Task.Delay(500);

                SetData();
                LocationManager.SetNext(Artist, Title, Temp);
                BlacksManager.SetBlack(Artist, Title);
                LocationManager.SetBlackLocation(Artist, Title, Black1, Black2, false);

                await Task.Delay(500);

                AnimationManager.RiseLabel(Artist, Title, LocationManager.Y1, LocationManager.Y2);
                await Task.Delay(500);

                SocketManager.Comunicate("play");
            }
            else
            {
                ProgressBarManager.SetValue(status.Time);
                if (status.PP.Equals("pause"))
                {
                    Marquee.Stop();
                    SetLocation();
                }
                else if (status.PP.Equals("play"))
                {
                    if(_PP.Equals("stop"))
                    {
                        GetData();
                        SetData();
                    }
                    Marquee.Start();
                }
                else if (status.PP.Equals("stop"))
                {
                    Marquee.Stop();
                    SetLocation();
                }
            }
        }

        private void Marquee_Tick(object sender, EventArgs e)
        {
            MarqueeManager.TimerTick();
        }
    }
}
