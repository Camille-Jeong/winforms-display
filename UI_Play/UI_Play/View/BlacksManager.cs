using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI_Play.View
{
    class BlacksManager
    {
        static Label Black1, Black2;
        static public void GetFormsValue(Label black1, Label black2)
        {
            Black1 = black1;
            Black2 = black2;
        }

        static public void SetBlack(Label label1, Label label2)
        {
            Black1.ForeColor = Color.Black;
            Black2.ForeColor = Color.Black;

            Black1.Text = label1.Text;
            Black2.Text = label2.Text;
        }
    }
}