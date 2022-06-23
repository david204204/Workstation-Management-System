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
//Yaniv Avikzer
//David Tzur
namespace FinalProjectForm.MyControls
{
    public partial class HrList : UserControl
    {
        List<SingleHrView> listitems = new List<SingleHrView>(); // create general list of type SingleEquipmentView
        private int itmco=0;
        private int Editbtnshow=1;
        public List<SingleHrView> MyItemsList
        {
            get { return listitems; }
        }
        [Category("New UI Props")]
        public int ShowEditBtn
        {
            get { return Editbtnshow; }
            set { Editbtnshow = value; }
        }

        public int ItemsCount
        {
            get { return itmco; }
            //set { itmco = value; }
        }
        private int SInterval = 1;
        [Category("New UI Props")]
        public int OpeningSpeed // set or get the speed of movment
        {
            get { return SInterval; }
            set { SInterval = value;
                    for (int i = 0; i < listitems.Count; i++) // applying new interval to all items in the list
                    {
                        listitems[i].SpeedInterval = value;
                    }
            }
        }


        public HrList()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }

        public void ClearList() // remove all items from list
        {
            flowLayoutPanel1.Controls.Clear();
            listitems.Clear();
            itmco = 0;
        }

        public void AddItem(Hr obj)// from object
        {
            listitems.Add(new SingleHrView(obj));
            // creats a new tasklist object and add it to the list
            listitems[itmco].Width = flowLayoutPanel1.Width - 25; // sets the width
            listitems[itmco].OnEditButtonPressedEvent += (this.EditButtonPresed);  // adding a function to the click event of edit button                                         //listitems[itmco].Anchor = AnchorStyles.Left;
            //listitems[itmco].OnInfoButtonPressedEvent += (this.InfoButtonPresed);  // adding a function to the click event of info button     
            flowLayoutPanel1.Controls.Add(listitems[itmco]); // adds to the panel
            itmco++;
        }

        [Category("New Events")]
        public delegate void EditButPressedEvent(object sender, EventArgs e, SingleHrView objuse);
        public event EditButPressedEvent EditButtonPresedps;
        public void EditButtonPresed(object sender, EventArgs e) // this is what happend wean you click the edit button
        {

            SingleHrView obttouse = sender as SingleHrView; // saving the used task to new var for passing
            //MessageBox.Show(singletask.TaskID + "!");
            if (EditButtonPresedps != null)
            {
                EditButtonPresedps(this, e, obttouse); // passing the event and the used task
            }
        }

        private void FlowLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            // making the items of the list responsive when resized
            if (itmco > 0)
            {
                for (int i = 0; i < listitems.Count; i++)
                {
                    listitems[i].Width = flowLayoutPanel1.Width - 25;
                }
                
            }
        }
    }
}
