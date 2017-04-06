namespace Display_Play
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Artist = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.temp = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.RemainingTime = new System.Windows.Forms.Label();
            this.PlayingTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Tahoma", 40.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.Color.White;
            this.Artist.Location = new System.Drawing.Point(101, 249);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(1270, 129);
            this.Artist.TabIndex = 0;
            this.Artist.Text = "Bob Marley && The Wailers";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 40.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(281, 435);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(928, 129);
            this.Title.TabIndex = 1;
            this.Title.Text = "No Woman No Cry";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Tahoma", 40.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temp.ForeColor = System.Drawing.Color.White;
            this.temp.Location = new System.Drawing.Point(1313, 585);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(0, 129);
            this.temp.TabIndex = 3;
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar.Location = new System.Drawing.Point(185, 672);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1102, 42);
            this.ProgressBar.TabIndex = 4;
            this.ProgressBar.Value = 50;
            this.ProgressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // RemainingTime
            // 
            this.RemainingTime.AutoSize = true;
            this.RemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingTime.ForeColor = System.Drawing.Color.White;
            this.RemainingTime.Location = new System.Drawing.Point(1302, 668);
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Size = new System.Drawing.Size(126, 46);
            this.RemainingTime.TabIndex = 5;
            this.RemainingTime.Text = "label1";
            // 
            // PlayingTime
            // 
            this.PlayingTime.AutoSize = true;
            this.PlayingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayingTime.ForeColor = System.Drawing.Color.White;
            this.PlayingTime.Location = new System.Drawing.Point(-2, 668);
            this.PlayingTime.Name = "PlayingTime";
            this.PlayingTime.Size = new System.Drawing.Size(126, 46);
            this.PlayingTime.TabIndex = 6;
            this.PlayingTime.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1474, 829);
            this.Controls.Add(this.PlayingTime);
            this.Controls.Add(this.RemainingTime);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.temp);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Artist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label temp;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label RemainingTime;
        private System.Windows.Forms.Label PlayingTime;
    }
}

