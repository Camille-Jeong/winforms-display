using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Display_Play
{
    class ProgressBarManager
    {
        static int count_B, count_G, count_S;  //Button clicked, gap(in interval), Second(in interval)
        static int gap;                        //set progressbar increase cycle
        static int length_s;                   //length.text second
        static public int state_s;             //state.text second
        static public bool mode = true;

        static ProgressBar ProgressBar;
        static Label PlayingTime;
        static Label RemainingTime;

        static public void GetFormsValue(ProgressBar _progressBar, Label _pt, Label _rt)
        {
            ProgressBar = _progressBar;
            PlayingTime = _pt;
            RemainingTime = _rt;
        }

        static public void SetDefault(int _length_s)
        {
            count_B = 0;
            count_G = 0;
            count_S = 0;
            length_s = _length_s;
            if (length_s < 3600)
                mode = true;
            else
                mode = false;
            state_s = 0;
            gap = length_s / 10;
            ProgressBar.Value = 0;
            PlayingTime.Text = CheckLength(state_s);
            RemainingTime.Text = CheckLength(length_s);
        }

        static public bool TimerTick()
        {
            bool _return = false;
            count_G++;
            count_S++;

            if (count_G >= gap)
            {
                count_G = 0;
                ProgressBar.Value++;
            }

            if (count_S == 10)
            {
                count_S = 0;

                if (state_s == length_s)
                {
                    state_s = 0;
                    ProgressBar.Value = 0;
                    count_B = 0;
                    _return = true;
                }
                else
                    state_s += 1;

                PlayingTime.Text = CheckLength(state_s);
                RemainingTime.Text = CheckLength(length_s - state_s);
            }

            return _return;
        }

        static public bool Start()
        {
            bool _return = false;
            count_B++;
            if (count_B == 1)
            {
                state_s = 1;
                PlayingTime.Text = CheckLength(state_s);
                RemainingTime.Text = CheckLength(length_s - state_s);
                _return = true;
            }
            if (count_B % 2 == 1)
            {
                
                _return = true;
            }
            else
            {
                _return = false;
            }
            return _return;
        }

        static public string CheckLength(int length)
        {
            string _return;
            if (mode)
                _return = TimeSpan.FromSeconds(length).ToString(@"mm\:ss");
            else
                _return = TimeSpan.FromSeconds(length).ToString(@"hh\:mm\:ss");
            return _return;
        } 
    }
}
