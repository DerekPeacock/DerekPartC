namespace DerekWindowsFormsPartC
{
    partial class SketchForm
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
            this.sketchPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.quitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sketchPanel
            // 
            this.sketchPanel.BackColor = System.Drawing.Color.Snow;
            this.sketchPanel.Location = new System.Drawing.Point(100, 96);
            this.sketchPanel.Name = "sketchPanel";
            this.sketchPanel.Size = new System.Drawing.Size(868, 439);
            this.sketchPanel.TabIndex = 0;
            this.sketchPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.sketchPanel_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 46F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(259, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 75);
            this.label1.TabIndex = 1;
            this.label1.Text = "Derek\'s Etch-a-Sketch";
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(893, 580);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(151, 53);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            // 
            // SketchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tomato;
            this.ClientSize = new System.Drawing.Size(1074, 645);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sketchPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "SketchForm";
            this.Text = "Derek Sketch Form";
            this.Load += new System.EventHandler(this.SketchForm_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.paintForm);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel sketchPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button quitButton;
    }
}