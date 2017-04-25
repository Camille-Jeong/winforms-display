namespace UI_Play
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
            this.Artist = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.SamplingRate = new System.Windows.Forms.Label();
            this.PlayingTime = new System.Windows.Forms.Label();
            this.RemainingTime = new System.Windows.Forms.Label();
            this.FileFormat = new System.Windows.Forms.Label();
            this.Bitwidth = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.Temp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.Color.White;
            this.Artist.Location = new System.Drawing.Point(-289, 167);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(2287, 232);
            this.Artist.TabIndex = 1;
            this.Artist.Text = "Bob Marley && The Wailers";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(52, 426);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1668, 232);
            this.Title.TabIndex = 2;
            this.Title.Text = "No Woman No Cry";
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar.Location = new System.Drawing.Point(318, 891);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1102, 42);
            this.ProgressBar.TabIndex = 5;
            this.ProgressBar.Value = 50;
            this.ProgressBar.Click += new System.EventHandler(this.ProgressBar_Click);
            // 
            // SamplingRate
            // 
            this.SamplingRate.AutoSize = true;
            this.SamplingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamplingRate.ForeColor = System.Drawing.Color.White;
            this.SamplingRate.Location = new System.Drawing.Point(600, 698);
            this.SamplingRate.Name = "SamplingRate";
            this.SamplingRate.Size = new System.Drawing.Size(592, 108);
            this.SamplingRate.TabIndex = 9;
            this.SamplingRate.Text = "samplingrate";
            // 
            // PlayingTime
            // 
            this.PlayingTime.AutoSize = true;
            this.PlayingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayingTime.ForeColor = System.Drawing.Color.White;
            this.PlayingTime.Location = new System.Drawing.Point(30, 864);
            this.PlayingTime.Name = "PlayingTime";
            this.PlayingTime.Size = new System.Drawing.Size(239, 85);
            this.PlayingTime.TabIndex = 10;
            this.PlayingTime.Text = "label1";
            // 
            // RemainingTime
            // 
            this.RemainingTime.AutoSize = true;
            this.RemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingTime.ForeColor = System.Drawing.Color.White;
            this.RemainingTime.Location = new System.Drawing.Point(1590, 874);
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Size = new System.Drawing.Size(239, 85);
            this.RemainingTime.TabIndex = 11;
            this.RemainingTime.Text = "label1";
            // 
            // FileFormat
            // 
            this.FileFormat.AutoSize = true;
            this.FileFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileFormat.ForeColor = System.Drawing.Color.White;
            this.FileFormat.Location = new System.Drawing.Point(1412, 698);
            this.FileFormat.Name = "FileFormat";
            this.FileFormat.Size = new System.Drawing.Size(439, 108);
            this.FileFormat.TabIndex = 12;
            this.FileFormat.Text = "fileformat";
            // 
            // Bitwidth
            // 
            this.Bitwidth.AutoSize = true;
            this.Bitwidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bitwidth.ForeColor = System.Drawing.Color.White;
            this.Bitwidth.Location = new System.Drawing.Point(55, 698);
            this.Bitwidth.Name = "Bitwidth";
            this.Bitwidth.Size = new System.Drawing.Size(369, 108);
            this.Bitwidth.TabIndex = 13;
            this.Bitwidth.Text = "bitwidth";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp.ForeColor = System.Drawing.Color.White;
            this.Temp.Location = new System.Drawing.Point(122, -80);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(0, 232);
            this.Temp.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1894, 1009);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.Bitwidth);
            this.Controls.Add(this.FileFormat);
            this.Controls.Add(this.RemainingTime);
            this.Controls.Add(this.PlayingTime);
            this.Controls.Add(this.SamplingRate);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Artist);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Artist;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label SamplingRate;
        private System.Windows.Forms.Label PlayingTime;
        private System.Windows.Forms.Label RemainingTime;
        private System.Windows.Forms.Label FileFormat;
        private System.Windows.Forms.Label Bitwidth;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label Temp;
    }
}

