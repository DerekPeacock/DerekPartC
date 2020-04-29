namespace WindowsFormsPartC.Unit5
{
    partial class FlyMeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlyMeForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.stopRadioButton = new System.Windows.Forms.RadioButton();
            this.startRadioButton = new System.Windows.Forms.RadioButton();
            this.quitButton = new System.Windows.Forms.Button();
            this.copterPictureBox = new System.Windows.Forms.PictureBox();
            this.animationTimer = new System.Windows.Forms.Timer(this.components);
            this.speedNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copterPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.stopRadioButton);
            this.panel1.Controls.Add(this.startRadioButton);
            this.panel1.Location = new System.Drawing.Point(15, 505);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 63);
            this.panel1.TabIndex = 2;
            // 
            // stopRadioButton
            // 
            this.stopRadioButton.AutoSize = true;
            this.stopRadioButton.Location = new System.Drawing.Point(170, 21);
            this.stopRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.stopRadioButton.Name = "stopRadioButton";
            this.stopRadioButton.Size = new System.Drawing.Size(75, 30);
            this.stopRadioButton.TabIndex = 1;
            this.stopRadioButton.Text = "Stop";
            this.stopRadioButton.UseVisualStyleBackColor = true;
            this.stopRadioButton.CheckedChanged += new System.EventHandler(this.stopStartAnimation);
            // 
            // startRadioButton
            // 
            this.startRadioButton.AutoSize = true;
            this.startRadioButton.Checked = true;
            this.startRadioButton.Location = new System.Drawing.Point(28, 21);
            this.startRadioButton.Margin = new System.Windows.Forms.Padding(6);
            this.startRadioButton.Name = "startRadioButton";
            this.startRadioButton.Size = new System.Drawing.Size(76, 30);
            this.startRadioButton.TabIndex = 0;
            this.startRadioButton.TabStop = true;
            this.startRadioButton.Text = "Start";
            this.startRadioButton.UseVisualStyleBackColor = true;
            this.startRadioButton.CheckedChanged += new System.EventHandler(this.stopStartAnimation);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(925, 515);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(130, 53);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitForm);
            // 
            // copterPictureBox
            // 
            this.copterPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.copterPictureBox.Location = new System.Drawing.Point(160, 80);
            this.copterPictureBox.Name = "copterPictureBox";
            this.copterPictureBox.Size = new System.Drawing.Size(100, 117);
            this.copterPictureBox.TabIndex = 4;
            this.copterPictureBox.TabStop = false;
            // 
            // animationTimer
            // 
            this.animationTimer.Enabled = true;
            this.animationTimer.Tick += new System.EventHandler(this.updateImage);
            // 
            // speedNumericUpDown
            // 
            this.speedNumericUpDown.Location = new System.Drawing.Point(430, 530);
            this.speedNumericUpDown.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.speedNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedNumericUpDown.Name = "speedNumericUpDown";
            this.speedNumericUpDown.Size = new System.Drawing.Size(73, 32);
            this.speedNumericUpDown.TabIndex = 5;
            this.speedNumericUpDown.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.speedNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.speedNumericUpDown.ValueChanged += new System.EventHandler(this.changeSpeed);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 532);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 26);
            this.label1.TabIndex = 6;
            this.label1.Text = "Speed";
            // 
            // FlyMeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 611);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.speedNumericUpDown);
            this.Controls.Add(this.copterPictureBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FlyMeForm";
            this.Text = "Derek\'s Fly With Me";
            this.Load += new System.EventHandler(this.LoadImages);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.copterPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton stopRadioButton;
        private System.Windows.Forms.RadioButton startRadioButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.PictureBox copterPictureBox;
        private System.Windows.Forms.Timer animationTimer;
        private System.Windows.Forms.NumericUpDown speedNumericUpDown;
        private System.Windows.Forms.Label label1;
    }
}