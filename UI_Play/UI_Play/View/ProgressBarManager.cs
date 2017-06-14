using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Play
{
    /**
     * This class control movement of progressbar 
     **/
    class ProgressBarManager
    {
        static int count_G, count_S;           //gap(in interval), Second(in interval)
        static int gap;                        //set progressbar increase cycle
        static int length;                   //length.text second
        static public int state_s;             //state.text second
        static public bool mode = true, _return;
        static double p_value;

        static ProgressBar ProgressBar;
        static Label PlayingTime, RemainingTime;

        static public void GetFormsValue(ProgressBar _ProgressBar, Label _Pt, Label _Rt)
        {
            ProgressBar = _ProgressBar;
            PlayingTime = _Pt;
            RemainingTime = _Rt;
        }

        static public void SetData(int _length, int state)
        {
            length = _length;

            if (length < 3600)
                mode = true;
            else
                mode = false;
            
            _return = false;

            PlayingTime.Text = CheckLength(state);
            RemainingTime.Text = CheckLength(length - state);
            p_value = ((double)state / (double)length) * 100;
            ProgressBar.Value = (int)p_value;
        }

        static public void SetValue(int state)
        {
            PlayingTime.Text = CheckLength(state);
            RemainingTime.Text = CheckLength(length - state);
            p_value = ((double)state / (double)length) * 100;
            ProgressBar.Value = (int)p_value;
        }

        static private string CheckLength(int length)
        {
            string _return;
            if (mode)
                _return = TimeSpan.FromSeconds(length).ToString(@"mm\:ss");
            else
                _return = TimeSpan.FromSeconds(length).ToString(@"hh\:mm\:ss");
            return _return;
        }

        static public bool IsFinish()
        {
            return _return;
        }
    }
}
