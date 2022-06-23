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
//Yaniv Avikzer
//David Tzur
namespace FinalProjectForm
{
        //[DesignerCategory("Yaniv&David")]
        public partial class SingleTaskView : UserControl
    {
        private string maint;
        private int flag;
        private int defulth;
        private int mainsize = 44;
        private int openupsize = 80;
        private Color MainColor = Color.FromArgb(255, 51, 51, 76);//blue
        private Color Type2Color = Color.FromArgb(255, 255, 155, 61);//2 = Quality - orange
        private Color Type3Color = Color.FromArgb(255, 255, 66, 66);//3 = Safety - red
        private Color closed;
        private Color opend;
        private bool IFin;
        private string tsid;
        private Color IfinColor = Color.FromArgb(255, 9, 129, 0);//green
        private int TaskT=0;
        private int Umode;
        public Tasks MyTask = new Tasks();

        public int UserMode
        {
            // this will set what buttons the user will see
            // 0 = Regular user
            // 1 = Super user
            get { return Umode; }
            set { Umode = value; if (value == 0) iaFbtn11.Visible = false; }
        }


        public int TypeNum // set the color of the object based on the type
        {
            get { return TaskT; }
            set { TaskT = value; }
        }


        [Category("New UI Props")]
        public Color FinishedTaskColor
        {
            get { return IfinColor; }
            set { IfinColor = value; }
        }

        [Category("New UI Props")]
        //[Description("")]
        //[DefaultValue("")]
        public string TaskID // adds the task id property
        {

            get { return tsid; }
            set { tsid = value; Taskid.Text = value; }
        }

        [Category("New UI Props")]
        public bool IsFinished// color green if true
        {
            get { return IFin; }
            set { IFin = value; this.Invalidate(); }
        }
        private string Dued;
        private string myVar;
        private int SInterval=1; // default speed is 1 millisecond (fast)
        [Category("New UI Props")]
        public int SpeedInterval
        {
            get { return SInterval; }
            set { SInterval = value; }
        }
        [Category("New UI Props")]
        public string SubText
        {
            get { return myVar; }
            set { myVar = value; Stext.Text = value ;
               // openupsize = Stext.Height;
                //dDate.Text = Stext.Height+"";
            }
        }
        [Category("New UI Props")]
        public string DueDate
        {
            get { return Dued; }
            set { Dued = value;
                dDate.Text = value;
            }
        }
        [Category("New UI Props")]
        public string  MainText
        {
            get { return maint; }
            set {maint = value; label1.Text = value; }
        }

            public SingleTaskView(Tasks obj)
        {
            InitializeComponent();
            this.Height = mainsize;
            flag = 0;
            defulth = this.Height;
            this.closed = MainColor;
            this.opend = ControlPaint.Light(MainColor);
            MyTask = obj;
            //this.DoubleBuffered = true;
        }
  
        private void TasksView_Load(object sender, EventArgs e)
        {
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            
            
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
                //this.Height = default;
                //button1.Text = "Show";
                //flag = 0;
            }
        }
        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void TasksView_Click(object sender, EventArgs e)
        {
            openclose();
        }

        private void IaFbtn11_Load(object sender, EventArgs e)
        {
            
        }
        //[Category("New UI Events")]
        //public event EventHandler EditBtnClick
        //{
        //    add { iaFbtn11.Click += value; }
        //    remove { iaFbtn11.Click -= value;}
        //}

        private void Button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void TableLayoutPanel1_Click(object sender, EventArgs e)
        {
            openclose();
        }

        private void TasksView_Paint(object sender, PaintEventArgs e)
        {

            if (IFin)
            {
                //MainColor = IfinColor;
                //this.closed = MainColor;
                this.BackColor = IfinColor;
                //this.opend = ControlPaint.Light(MainColor);
            } else
            {
                //0 = Maintenance
                //1 = Quality
                //2 = Safety
                if (TypeNum==1) this.BackColor = Type2Color;
                if(TypeNum==2) this.BackColor = Type3Color;
            }
        }

        private void Stext_Click(object sender, EventArgs e)
        {

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
        //Setting up new event so we can use the info button from the outside
        [Category("New Events")]
        public delegate void InfoButtonPressedEvent(object sender, EventArgs e);
        public event InfoButtonPressedEvent OnInfoButtonPressedEvent;
        private void IaF_InfoBtn1_OnButtonPressedEvent(object sender, EventArgs e)
        {
            if (OnInfoButtonPressedEvent != null)
            {
                OnInfoButtonPressedEvent(this, e); // passing the event
            }
        }
    }
}
