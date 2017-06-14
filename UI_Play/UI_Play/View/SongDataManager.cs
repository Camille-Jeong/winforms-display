using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Play
{
    /**
     * This class manage status label text which from server
     **/
    class SongDataManager
    {
        static Label BitWidth, SamplingRate, FileFormat;

        static public void GetFormsValue(Label _BW, Label _SR, Label _FF)
        {
            BitWidth = _BW;
            SamplingRate = _SR;
            FileFormat = _FF;
        }

        static public void SetData(string _BW, string _SR, string _FF)
        {
            BitWidth.Text = _BW + "bit";
            SamplingRate.Text = (Convert.ToDouble(_SR) / 1000).ToString() + "Khz";
            FileFormat.Text = _FF;
        }
    }
}
