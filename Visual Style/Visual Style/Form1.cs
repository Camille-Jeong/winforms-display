using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Visual_Style
{
    public partial class Form1 : Form
    {
        int count_B = 0, count_G = 0, count_S = 0;  //Button clicked, gap(in interval), Second(in interval)
        int gap;                                    //set progressbar increase cycle
        int length_s = 60;                           //length.text second
        static public int state_s = 0;              //state.text second

        /*progress when Form loads*/
        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            state.Text = TimeSpan.FromSeconds(state_s).ToString();
            length.Text = TimeSpan.FromSeconds(length_s).ToString();
            gap = length_s/10;
        }

        /*primary setting*/
        public Form1()
        {
            InitializeComponent();
        }

        /*progress when Form closes*/
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        /*tick movement*/
        private void TimeStemp_Tick(object sender, EventArgs e)
        {
            count_G++;
            count_S++;

            if (count_G >= gap)
            {
                count_G = 0;
                progressBar.Value++;
            }

            if (count_S == 10)
            {
                state_s += 1;
                state.Text = TimeSpan.FromSeconds(state_s).ToString();
                count_S = 0;

                if (state_s > length_s)
                {
                    state_s = 0;
                    state.Text = TimeSpan.FromSeconds(state_s).ToString();
                    progressBar.Value = 0;
                    count_B = 0;
                    timer1.Stop();
                }
            }
        }

        /*play button clicked*/
        private void Play_Click(object sender, EventArgs e)
        {
            count_B++;
            if (count_B == 1)
            {
                state_s = 1;
                state.Text = TimeSpan.FromSeconds(state_s).ToString();
            }
            if (count_B % 2 == 1)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
        }
    }
}
