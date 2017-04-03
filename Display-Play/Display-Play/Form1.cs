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
        public Form1()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Artist.Text = "i love camille so much. i will marry with her";
            Title.Text = "i love camille so much. i will marry with her";
            setLocation(Artist);
            setLocation(Title);
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
                timer.Start();
            }
            label.Location = new Point(startXpos, startYpos);
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
    }
}
