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
            this.Artist.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.Artist.ForeColor = System.Drawing.Color.White;
            this.Artist.Location = new System.Drawing.Point(12, 261);
            this.Artist.Name = "Artist";
            this.Artist.Size = new System.Drawing.Size(1291, 120);
            this.Artist.TabIndex = 0;
            this.Artist.Text = "Bob Marley && The Wailers";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Title.ForeColor = System.Drawing.Color.White;
            this.Title.Location = new System.Drawing.Point(219, 423);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(945, 120);
            this.Title.TabIndex = 1;
            this.Title.Text = "No Woman No Cry";
            // 
            // temp
            // 
            this.temp.AutoSize = true;
            this.temp.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F);
            this.temp.ForeColor = System.Drawing.Color.White;
            this.temp.Location = new System.Drawing.Point(1194, 423);
            this.temp.Name = "temp";
            this.temp.Size = new System.Drawing.Size(338, 120);
            this.temp.TabIndex = 3;
            this.temp.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1544, 809);
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
    }
}

