using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectForm.MyControls.WorkShop;
using FinalProjectForm.DataObjects;
using FinalProjectForm.Forms;
//Yaniv Avikzer
//David Tzur
namespace FinalProjectForm.MyControls
{
    public partial class IAF_WorkShop : UserControl
    {
        
        List<WorkShopLine> listitems = new List<WorkShopLine>(); // create general list of type singletasksview
        private int itmco=0;
        public int ItemsCount
        {
            get { return itmco; }
            //set { itmco = value; }
        }
        public IAF_WorkShop()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }
        public void ClearList() // remove all items from list
        {
            flowLayoutPanel1.Controls.Clear();
        }

        public void Add(ShopList obj)// from object
        {
            listitems.Add(new WorkShopLine(obj));
            listitems[itmco].Width = flowLayoutPanel1.Width; //- 25; // sets the width
            flowLayoutPanel1.Controls.Add(listitems[itmco]); // adds to the panel
            flowLayoutPanel1.Controls.Add(listitems[0]); // adds to the panel
            
            itmco++;
        }
        private void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            // making the items of the list responsive when resized
            if (itmco > 0)
            {
                for (int i = 0; i < listitems.Count; i++)
                {
                    listitems[i].Width = flowLayoutPanel1.Width;// - 25;
                }
                
            }
        }
        private void IAF_WorkShop_Load(object sender, EventArgs e)
        {

        }

        private void workShopHeader1_Load(object sender, EventArgs e)
        {

        }
    }
}
