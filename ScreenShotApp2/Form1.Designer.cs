namespace ScreenShotApp2
{
    partial class ScreenShotApp
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxDisplay = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxDisplay
            // 
            this.textBoxDisplay.BackColor = System.Drawing.Color.LightGray;
            this.textBoxDisplay.Location = new System.Drawing.Point(12, 152);
            this.textBoxDisplay.Name = "textBoxDisplay";
            this.textBoxDisplay.Size = new System.Drawing.Size(458, 27);
            this.textBoxDisplay.TabIndex = 1;
            this.textBoxDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxDisplay.TextChanged += new System.EventHandler(this.textBoxDisplay_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Silver;
            this.button2.Location = new System.Drawing.Point(256, 185);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(214, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "Take a screen shot";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Silver;
            this.button.Location = new System.Drawing.Point(12, 187);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(238, 29);
            this.button.TabIndex = 3;
            this.button.Text = "Select folder";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(458, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // ScreenShotApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(482, 226);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBoxDisplay);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ScreenShotApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Screen Shot App";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxDisplay;
        private Button button2;
        private Button button;
        private PictureBox pictureBox1;
    }
}