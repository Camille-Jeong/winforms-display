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
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.PlayingTime = new System.Windows.Forms.Label();
            this.RemainingTime = new System.Windows.Forms.Label();
            this.Marquee = new System.Windows.Forms.Timer(this.components);
            this.StatusConnection = new System.Windows.Forms.Timer(this.components);
            this.Temp = new System.Windows.Forms.Label();
            this.Black1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Black2 = new System.Windows.Forms.Label();
            this.BitWidth = new System.Windows.Forms.Label();
            this.SamplingRate = new System.Windows.Forms.Label();
            this.FileFormat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Artist
            // 
            this.Artist.AutoSize = true;
            this.Artist.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Artist.ForeColor = System.Drawing.Color.White;
            this.Artist.Location = new System.Drawing.Point(915, 151);
            this.Artist.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(674, 290);
            this.Artist.TabIndex = 1;
            this.Artist.Text = "Artist";
            // 
            // ProgressBar
            // 
            this.ProgressBar.ForeColor = System.Drawing.Color.Gainsboro;
            this.ProgressBar.Location = new System.Drawing.Point(424, 1105);
            this.ProgressBar.Margin = new System.Windows.Forms.Padding(4);
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(1469, 52);
            this.ProgressBar.TabIndex = 5;
            this.ProgressBar.Value = 50;
            // 
            // PlayingTime
            // 
            this.PlayingTime.AutoSize = true;
            this.PlayingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayingTime.ForeColor = System.Drawing.Color.White;
            this.PlayingTime.Location = new System.Drawing.Point(40, 1071);
            this.PlayingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PlayingTime.Name = "PlayingTime";
            this.PlayingTime.Size = new System.Drawing.Size(295, 107);
            this.PlayingTime.TabIndex = 10;
            this.PlayingTime.Text = "label1";
            // 
            // RemainingTime
            // 
            this.RemainingTime.AutoSize = true;
            this.RemainingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemainingTime.ForeColor = System.Drawing.Color.White;
            this.RemainingTime.Location = new System.Drawing.Point(2120, 1084);
            this.RemainingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemainingTime.Name = "RemainingTime";
            this.RemainingTime.Size = new System.Drawing.Size(295, 107);
            this.RemainingTime.TabIndex = 11;
            this.RemainingTime.Text = "label1";
            // 
            // Marquee
            // 
            this.Marquee.Interval = 1;
            this.Marquee.Tick += new System.EventHandler(this.Marquee_Tick);
            // 
            // StatusConnection
            // 
            this.StatusConnection.Interval = 1000;
            this.StatusConnection.Tick += new System.EventHandler(this.StatusConnection_Tick);
            // 
            // Temp
            // 
            this.Temp.AutoSize = true;
            this.Temp.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Temp.ForeColor = System.Drawing.Color.White;
            this.Temp.Location = new System.Drawing.Point(163, -99);
            this.Temp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Temp.Name = "Temp";
            this.Temp.Size = new System.Drawing.Size(0, 290);
            this.Temp.TabIndex = 14;
            // 
            // Black1
            // 
            this.Black1.AutoSize = true;
            this.Black1.Font = new System.Drawing.Font("Tahoma", 80F);
            this.Black1.ForeColor = System.Drawing.Color.Black;
            this.Black1.Location = new System.Drawing.Point(1620, 447);
            this.Black1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Black1.Name = "Black1";
            this.Black1.Size = new System.Drawing.Size(218, 322);
            this.Black1.TabIndex = 15;
            this.Black1.Text = " ";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Tahoma", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(980, 513);
            this.Title.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(578, 290);
            this.Title.TabIndex = 16;
            this.Title.Text = "Title";
            // 
            // Black2
            // 
            this.Black2.AutoSize = true;
            this.Black2.Font = new System.Drawing.Font("Tahoma", 80F);
            this.Black2.ForeColor = System.Drawing.Color.Black;
            this.Black2.Location = new System.Drawing.Point(1620, 786);
            this.Black2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Black2.Name = "Black2";
            this.Black2.Size = new System.Drawing.Size(218, 322);
            this.Black2.TabIndex = 17;
            this.Black2.Text = " ";
            // 
            // BitWidth
            // 
            this.BitWidth.AutoSize = true;
            this.BitWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BitWidth.ForeColor = System.Drawing.Color.White;
            this.BitWidth.Location = new System.Drawing.Point(1047, 894);
            this.BitWidth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BitWidth.Name = "BitWidth";
            this.BitWidth.Size = new System.Drawing.Size(465, 135);
            this.BitWidth.TabIndex = 18;
            this.BitWidth.Text = "bitwidth";
            // 
            // SamplingRate
            // 
            this.SamplingRate.AutoSize = true;
            this.SamplingRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SamplingRate.ForeColor = System.Drawing.Color.White;
            this.SamplingRate.Location = new System.Drawing.Point(47, 906);
            this.SamplingRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SamplingRate.Name = "SamplingRate";
            this.SamplingRate.Size = new System.Drawing.Size(746, 135);
            this.SamplingRate.TabIndex = 19;
            this.SamplingRate.Text = "samplingrate";
            // 
            // FileFormat
            // 
            this.FileFormat.AutoSize = true;
            this.FileFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileFormat.ForeColor = System.Drawing.Color.White;
            this.FileFormat.Location = new System.Drawing.Point(1942, 906);
            this.FileFormat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FileFormat.Name = "FileFormat";
            this.FileFormat.Size = new System.Drawing.Size(551, 135);
            this.FileFormat.TabIndex = 20;
            this.FileFormat.Text = "fileformat";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(2525, 1251);
            this.Controls.Add(this.FileFormat);
            this.Controls.Add(this.SamplingRate);
            this.Controls.Add(this.BitWidth);
            this.Controls.Add(this.Black2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Black1);
            this.Controls.Add(this.Temp);
            this.Controls.Add(this.RemainingTime);
            this.Controls.Add(this.PlayingTime);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.Artist);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label Artist;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label PlayingTime;
        private System.Windows.Forms.Label RemainingTime;
        private System.Windows.Forms.Timer Marquee;
        private System.Windows.Forms.Timer StatusConnection;
        private System.Windows.Forms.Label Temp;
        public System.Windows.Forms.Label Black1;
        public System.Windows.Forms.Label Title;
        public System.Windows.Forms.Label Black2;
        private System.Windows.Forms.Label BitWidth;
        private System.Windows.Forms.Label SamplingRate;
        private System.Windows.Forms.Label FileFormat;
    }
}

