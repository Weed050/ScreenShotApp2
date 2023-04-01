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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScreenShotApp));
            textBoxDisplay = new TextBox();
            button2 = new Button();
            button = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // textBoxDisplay
            // 
            textBoxDisplay.BackColor = Color.LightGray;
            textBoxDisplay.Location = new Point(152, 152);
            textBoxDisplay.Name = "textBoxDisplay";
            textBoxDisplay.Size = new Size(318, 27);
            textBoxDisplay.TabIndex = 1;
            textBoxDisplay.TextAlign = HorizontalAlignment.Center;
            textBoxDisplay.TextChanged += textBoxDisplay_TextChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(256, 185);
            button2.Name = "button2";
            button2.Size = new Size(214, 29);
            button2.TabIndex = 2;
            button2.Text = "Take a screen shot";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button
            // 
            button.BackColor = Color.Silver;
            button.ForeColor = Color.Black;
            button.Location = new Point(12, 187);
            button.Name = "button";
            button.Size = new Size(238, 29);
            button.TabIndex = 3;
            button.Text = "Select folder";
            button.UseVisualStyleBackColor = false;
            button.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(458, 136);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(25, 155);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 5;
            label1.Text = "Enter a directory:";
            // 
            // ScreenShotApp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(482, 226);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(button);
            Controls.Add(button2);
            Controls.Add(textBoxDisplay);
            ForeColor = Color.Transparent;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ScreenShotApp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Screen Shot App";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBoxDisplay;
        private Button button2;
        private Button button;
        private PictureBox pictureBox1;
        private Label label1;
    }
}