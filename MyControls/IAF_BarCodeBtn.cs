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
    public partial class IAF_BarCodeBtn : UserControl
    {
        public IAF_BarCodeBtn()
        {
            InitializeComponent();
        }

        [Category("New Events")]
        public delegate void ButtonPressedEvent(object sender, EventArgs e);
        public event ButtonPressedEvent OnButtonPressedEvent;
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = FinalProjectForm.Properties.Resources.barcode_pressed;
            if (OnButtonPressedEvent != null)
            {
                OnButtonPressedEvent(this,e);
            }
            
        }

        private void PictureBox1_MouseHover(object sender, EventArgs e)
        {
            pictureBox1.Image = FinalProjectForm.Properties.Resources.barcode_Hover;
        }

        private void PictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.Image = FinalProjectForm.Properties.Resources.barcode_None;
        }
    }
}
