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
namespace FinalProjectForm.MyControls.FormMenu
{
    public partial class IAF_Menu : UserControl
    {
        List<IAF_Button> listitems = new List<IAF_Button>(); // create general list of tasksview
        public IAF_Menu()
        {
            InitializeComponent();
        }

        private void IAF_Menu_Paint(object sender, PaintEventArgs e)
        {
            AddBtn();
            AddBtn();
            AddBtn();
            AddBtn();
        }
        int itmco = 0;
        public void AddBtn()
        {
            listitems.Add(new IAF_Button());
            listitems[itmco].Width = flowLayoutPanel1.Width - 25;
            flowLayoutPanel1.Controls.Add(listitems[itmco]); // adds to the panel
            itmco++;
        }
    }
}
