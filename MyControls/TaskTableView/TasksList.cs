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
namespace FinalProjectForm.MyControls
{
    public partial class TasksList : UserControl
    {
        List<SingleTaskView> listitems = new List<SingleTaskView>(); // create general list of type singletasksview
        private int itmco=0;
        private int Editbtnshow=1;
        public List<SingleTaskView> MyItemsList
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
        public int OpeningSpeed // set or get the speed of movement
        {
            get { return SInterval; }
            set { SInterval = value;
                    for (int i = 0; i < listitems.Count; i++) // applying new interval to all items in the list
                    {
                        listitems[i].SpeedInterval = value;
                    }
            }
        }


        public TasksList()
        {
            InitializeComponent();
            flowLayoutPanel1.AutoScroll = true;
        }
        public void RemoveItem(int Index)
        {
            if (flowLayoutPanel1.Controls.Count <= 1)// last item remain so clear all the panel
            {
                flowLayoutPanel1.Controls.Clear();
            }
            else { 
                //listitems.Remove(listitems[Index]); // also remove from list
                flowLayoutPanel1.Controls.Remove(listitems[Index]);
                //itmco--;
            }
        }
        public void MarkAsDone(int index)
        {
            listitems[index].IsFinished = true;
        }
        public void ClearList() // remove all items from list
        {
            flowLayoutPanel1.Controls.Clear();
            listitems.Clear();
            itmco = 0;
        }
        public void AddItem(Tasks obj)// from object
        {
            listitems.Add(new SingleTaskView(obj) { MainText = obj.MyTitle, DueDate = obj.FinalDate.ToShortDateString(), SubText = obj.TaskDetails, TaskID = obj.TaskId + "", IsFinished = obj.TaskDone, TypeNum = obj.TaskType });
            // creates a new tasklist object and add it to the list
            if (ShowEditBtn == 0) { listitems[itmco].UserMode = 0; }
            listitems[itmco].Width = flowLayoutPanel1.Width - 25; // sets the width
            listitems[itmco].OnEditButtonPressedEvent += (this.EditButtonPresed);  // adding a function to the click event of edit button                                         //listitems[itmco].Anchor = AnchorStyles.Left;
            listitems[itmco].OnInfoButtonPressedEvent += (this.InfoButtonPresed);  // adding a function to the click event of info button     
            flowLayoutPanel1.Controls.Add(listitems[itmco]); // adds to the panel
            itmco++;
        }

        [Category("New Events")]
        public delegate void InfoButPressedEvent(object sender, EventArgs e, SingleTaskView taskatuse);
        public event InfoButPressedEvent InfoButtonPresedps;

        public void InfoButtonPresed(object sender, EventArgs e) // this is what happed wean you click the Info button
        {
            SingleTaskView singletask = sender as SingleTaskView; // saving the used task to new var for passing
            if (InfoButtonPresedps != null)
            {
                InfoButtonPresedps(this, e, singletask); // passing the event and the used task
            }
        }


        [Category("New Events")]
        public delegate void EditButPressedEvent(object sender, EventArgs e, SingleTaskView taskatuse);
        public event EditButPressedEvent EditButtonPresedps;
        public void EditButtonPresed(object sender, EventArgs e) // this is what happend wean you click the edit button
        {
            SingleTaskView singletask = sender as SingleTaskView; // saving the used task to new var for passing
            //MessageBox.Show(singletask.TaskID + "!");
            if (EditButtonPresedps != null)
            {
                EditButtonPresedps(this, e, singletask); // passing the event and the used task
            }
        }

        private void TasksList_Load(object sender, EventArgs e)
        {

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
