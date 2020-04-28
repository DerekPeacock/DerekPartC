namespace WindowsFormsPartC
{
    partial class MenuForm
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
            this.animationRadioButton = new System.Windows.Forms.RadioButton();
            this.flyMeRadioButton = new System.Windows.Forms.RadioButton();
            this.runButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animationRadioButton
            // 
            this.animationRadioButton.AutoSize = true;
            this.animationRadioButton.Location = new System.Drawing.Point(28, 66);
            this.animationRadioButton.Name = "animationRadioButton";
            this.animationRadioButton.Size = new System.Drawing.Size(408, 30);
            this.animationRadioButton.TabIndex = 0;
            this.animationRadioButton.Text = "Task 5.1 Butterfly and Horse Animation";
            this.animationRadioButton.UseVisualStyleBackColor = true;
            // 
            // flyMeRadioButton
            // 
            this.flyMeRadioButton.AutoSize = true;
            this.flyMeRadioButton.Checked = true;
            this.flyMeRadioButton.Location = new System.Drawing.Point(28, 130);
            this.flyMeRadioButton.Name = "flyMeRadioButton";
            this.flyMeRadioButton.Size = new System.Drawing.Size(337, 30);
            this.flyMeRadioButton.TabIndex = 1;
            this.flyMeRadioButton.TabStop = true;
            this.flyMeRadioButton.Text = "Task 5.3 Fly With Me Animation";
            this.flyMeRadioButton.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(102, 570);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(121, 57);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runProgram);
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(287, 570);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(121, 57);
            this.quitButton.TabIndex = 3;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitForm);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(504, 673);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.flyMeRadioButton);
            this.Controls.Add(this.animationRadioButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MenuForm";
            this.Text = "Derek\'s Menu Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton animationRadioButton;
        private System.Windows.Forms.RadioButton flyMeRadioButton;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button quitButton;
    }
}