using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPartC.Unit5
{
    public partial class FlyMeForm : Form
    {
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

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            copterPictureBox.Image = animation.GetNextImage();
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
