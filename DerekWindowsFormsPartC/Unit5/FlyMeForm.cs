using System;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit5
{
    public partial class FlyMeForm : Form
    {
        public const int VERTICAL_SPEED = 100;

        private int horizontalSpeed = 10;

        private Animation animation = new Animation(4);

        public FlyMeForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Called on using the Form_Load event handler
        /// </summary>
        private void LoadImages(object sender, EventArgs e)
        {
            string baseFileName = "../../Images/Copter/copter";
            animation.LoadImages(baseFileName);
        }

        /// <summary>
        /// Called every time the timer clock ticks
        /// </summary>
        private void updateImage(object sender, EventArgs e)
        {
            copterPictureBox.Image = animation.GetNextImage();
            
            copterPictureBox.Left += horizontalSpeed;
            
            // If the copter goes off the right hand side

            if(copterPictureBox.Left > this.Width)
            {
                copterPictureBox.Top += VERTICAL_SPEED;
                copterPictureBox.Left = -copterPictureBox.Width;
            }

            // if the copter goes off the bottom

            if(copterPictureBox.Top > this.Height - copterPictureBox.Height)
            {
                copterPictureBox.Top = VERTICAL_SPEED;
            }
        }

        private void quitForm(object sender, EventArgs e)
        {
            Close();
        }

        private void stopStartAnimation(object sender, EventArgs e)
        {
            if(stopRadioButton.Checked)
            {
                animationTimer.Enabled = false;
            }
            else
            {
                animationTimer.Enabled = true;
            }
        }
    }
}
