using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Yaniv Avikzer
//David Tzur
namespace FinalProjectForm
{
    public partial class IAF_CheckBox : UserControl
    {
        public IAF_CheckBox()
        {
            InitializeComponent();
        }

        private bool Ch=false;
        [Category("New Props")]
        public bool Checked
        {
            get { return Ch; }
            set { Ch= value; CheckUnchek(value); }
        }
        private void CheckUnchek(bool Todo)
        {
            if (!Todo)
            { // uncheck
                pictureBox1.Image = FinalProjectForm.Properties.Resources.CheckBox_None;
                Ch = false;
            }
            else
            {
                //check
                pictureBox1.Image = FinalProjectForm.Properties.Resources.CheckBox_Checked;
                Ch = true;
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (Checked)
            { // uncheck
                pictureBox1.Image = FinalProjectForm.Properties.Resources.CheckBox_None;
                Ch = false;
            } else
            {
                //check
                pictureBox1.Image = FinalProjectForm.Properties.Resources.CheckBox_Checked;
                Ch = true;
            }
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            if (!Checked)
            {
                pictureBox1.Image = FinalProjectForm.Properties.Resources.CheckBox_Hover;
            }
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e) {
        {
            if (!Checked)
                pictureBox1.Image = FinalProjectForm.Properties.Resources.CheckBox_None;
        }
        }
    }
}
