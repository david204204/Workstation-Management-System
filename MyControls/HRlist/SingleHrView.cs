using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectForm.Forms;
using FinalProjectForm.DataObjects;
//Yaniv Avikzer
//David Tzur
namespace FinalProjectForm
{
        //[DesignerCategory("Yaniv&David")]
        public partial class SingleHrView : UserControl
    {
        private string maint;
        private int flag;
        private int defulth;
        private int mainsize = 60;
        private int openupsize = 150;
        private Color MainColor = Color.FromArgb(255, 51, 51, 76);//blue
        private Color ExpierdColor = Color.DimGray;
        private Color closed;
        private Color opend;
        private DateTime FDate;
        private String Dp;
        [Category("New UI Props")]
        public String Type
        {
            get { return Dp; }
            set { Dp = value; Typee.Text = value; }
        }
        private DateTime TDate;


        public DateTime ToDate
        {
            get { return TDate; }
            set { TDate = value; todate.Text = value.ToShortDateString(); }
        }

        [Category("New UI Props")]
        public DateTime FromDate
        {
            get { return FDate; }
            set { FDate = value; fromdate.Text = value.ToShortDateString(); }
        }


        [Category("New UI Props")]

        private int SInterval=1; // defult speed is 1 milisecond (fast)
        [Category("New UI Props")]
        public int SpeedInterval
        {
            get { return SInterval; }
            set { SInterval = value; }
        }
        private int perid;
        public int PersonalID
        {
            get { return perid; }
            set { perid = value; }
        }
        [Category("New UI Props")]
        public string MeDescription
        {
            get { return maint; }
            set {maint = value; description.Text = value; }
        }
        private int myid;

        public int HRid
        {
            get { return myid; }
            set { myid = value; }
        }

        public SingleHrView(Hr obj)
        {
            InitializeComponent();
            this.Height = mainsize;
            flag = 0;
            defulth = this.Height;
            this.closed = MainColor;
            this.opend = ControlPaint.Light(MainColor);
            HRid = obj.hrid;
            PersonalID = obj.PersonalID;
            MeDescription = obj.Description;
            FromDate = obj.From_Date;
            ToDate = obj.To_Date;
            Type = obj.Type;

        }

        public void openclose()
        {
            
            if (flag == 0)
            {
                this.BackColor = opend;
                OpenSmooth.Interval = SInterval;
                OpenSmooth.Enabled = true;
                //this.Height = 80;
                //button1.Text = "Hide";
                //flag = 1;
            }
            else if (flag == 1)
            {
                this.BackColor = closed;
                CloseSmooth.Interval = SInterval;
                CloseSmooth.Enabled = true;
                //this.Height = defulth;
                //button1.Text = "Show";
                //flag = 0;
            }
        }
     
        private void OpenSmooth_Tick(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (this.Height < openupsize)
                {
                    this.Height+=3;
                }
                else
                {
                    flag = 1;
                    OpenSmooth.Enabled = false;
                }
                //button1.Text = "Hide";
            }

        }

        private void CloseSmooth_Tick(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (this.Height != defulth)
                {
                    this.Height -= 3;
                }
                else
                {
                    flag = 0;
                    CloseSmooth.Enabled = false;
                }
                //button1.Text = "Show";
            }
        }



        private void TasksView_Paint(object sender, PaintEventArgs e)
        {
            DateTime Today = DateTime.Today;
            DateTime Exp = Convert.ToDateTime(todate.Text);
            int resuls = DateTime.Compare(Today, Exp);
            if(resuls>0)
            {
                this.BackColor = ExpierdColor;
            }
        }
        //Setting up new event so we can use the edit button from the outside
        [Category("New Events")]
        public delegate void EditButtonPressedEvent(object sender, EventArgs e);
        public event EditButtonPressedEvent OnEditButtonPressedEvent;
        private void IaFbtn11_OnButtonPressedEvent_1(object sender, EventArgs e)
        {
            if (OnEditButtonPressedEvent != null) 
            {
                OnEditButtonPressedEvent(this, e); // passing the event
            }
        }
        
        private void TableLayoutPanel1_Click(object sender, EventArgs e)
        {
            openclose();
        }

        private void TableLayoutPanel2_Click(object sender, EventArgs e)
        {
            openclose();
        }

        private void SingleEquipmentView_Click(object sender, EventArgs e)
        {
            openclose();
        }


        private void AllTableLayout_ClickEvent(object sender, EventArgs e)
        {
            openclose();
            // one event to rule them all!
            // this event controls the opening and closing of the line
        }
        private void SingleHrView_Load(object sender, EventArgs e)
        {
      
        }
        private void AddTextChangedHandler(Control parent)
        {
            foreach (TableLayoutPanel c in parent.Controls)
            {
                if (c.GetType() == typeof(TableLayoutPanel))
                {
                    c.Click += new EventHandler(AllTableLayout_ClickEvent);
                    //c.Enabled = false;
                }
                else
                {
                    AddTextChangedHandler(c);
                }
            }
        }
        private void RecurseTLPevents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                 if(control is TableLayoutPanel)
                    control.Click += (this.AllTableLayout_ClickEvent);
                //((TableLayoutPanel)control).Click += AllTableLayout_ClickEvent();
                else
                    RecurseTLPevents(control);
            }
        }

    }
}
