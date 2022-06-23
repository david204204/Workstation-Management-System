using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectForm.DataObjects;
using FinalProjectForm.MyControls.CheckBoxList;
//Yaniv Avikzer
//David Tzur
namespace FinalProjectForm.MyControls
{
    public partial class IAF_CheckBoxList : UserControl
    {
        List<SingleCheckBox> listitems = new List<SingleCheckBox>(); // create general list of type SingleEquipmentView
        private int itmco=0;

        [Category("CheckBoxes")]
        [Description("add or remove")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public List<SingleCheckBox> BoxesList
        {
            get { return listitems; }
            set { listitems.Add(new SingleCheckBox(Text)); }
        }

        public int ItemsCount
        {
            get { return listitems.Count; }
        }



        public IAF_CheckBoxList()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;

        }
        public void ReLoadAll()
        {
            for (int i = 0; i < listitems.Count; i++)
            {
                if (flowLayoutPanel1.VerticalScroll.Enabled)
                {
                    listitems[i].Width = flowLayoutPanel1.Width - 25;
                }
                else
                {
                    listitems[i].Width = flowLayoutPanel1.Width - 5;
                }
                
                listitems[i].Height= 25;
                flowLayoutPanel1.Controls.Add(listitems[i]);
            }
        }
        public void ClearList() // remove all items from list
        {
            flowLayoutPanel1.Controls.Clear();
        }

        public void AddItem(String Text)// from object
        {
            listitems.Add(new SingleCheckBox(Text));
            listitems[itmco].Width = flowLayoutPanel1.Width - 5; // sets the width
            flowLayoutPanel1.Controls.Add(listitems[itmco]); // adds to the panel
            itmco++;
        }
        private void SizeSet()
        {
            // making the items of the list responsive when resized
            if (listitems.Count > 0)
            {
                if (flowLayoutPanel1.VerticalScroll.Enabled)
                {
                    for (int i = 0; i < listitems.Count; i++)
                    {
                        listitems[i].Width = flowLayoutPanel1.Width - 25;
                    }
                }
                else
                {
                    for (int i = 0; i < listitems.Count; i++)
                    {
                        listitems[i].Width = flowLayoutPanel1.Width - 5;
                    }
                }
            }
        }
        private void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            SizeSet();
        }

        private void IAF_CheckBoxList_Paint(object sender, PaintEventArgs e)
        {
            ReLoadAll();
        }
    }
}
