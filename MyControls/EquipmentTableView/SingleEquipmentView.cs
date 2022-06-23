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
        public partial class SingleEquipmentView : UserControl
    {
        private string maint;
        private int flag;
        private int defulth;
        private int mainsize = 44;
        private int openupsize = 80;
        private Color MainColor = Color.FromArgb(255, 51, 51, 76);//blue
        private Color ExpierdColor = Color.Red;
        private Color closed;
        private Color opend;
        private int Sl;
        private int iafSl;
        private DateTime ExDate;
        private String Dp;
        [Category("New UI Props")]
        public String MeDepartment
        {
            get { return Dp; }
            set { Dp = value; department.Text = value; }
        }
        [Category("New UI Props")]
        public DateTime MeExpirationdate
        {
            get { return ExDate; }
            set { ExDate = value; expirationdate.Text = value.ToShortDateString(); }
        }


        [Category("New UI Props")]
        public int MeIafnumber
        {
            get { return iafSl; }
            set { iafSl = value; iafnumber.Text = value.ToString(); }
        }

        [Category("New UI Props")]
        public int MeSerialnumber
        {
            get { return Sl; }
            set { Sl = value; serialnumber.Text = value.ToString(); }
        }


        private int SInterval=1; // defult speed is 1 milisecond (fast)
        [Category("New UI Props")]
        public int SpeedInterval
        {
            get { return SInterval; }
            set { SInterval = value; }
        }
        
        [Category("New UI Props")]
        public string MeDescription
        {
            get { return maint; }
            set {maint = value; description.Text = value; }
        }

            public SingleEquipmentView(Equipment obj)
        {
            InitializeComponent();
            this.Height = mainsize;
            flag = 0;
            defulth = this.Height;
            this.closed = MainColor;
            this.opend = ControlPaint.Light(MainColor);
            MeDescription = obj.Description;
            MeSerialnumber = obj.SerialNumber;
            MeIafnumber = obj.IAFnumber;
            MeExpirationdate = obj.ExpirationDate;
            MeDepartment = obj.Department;
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
            DateTime Exp = Convert.ToDateTime(expirationdate.Text);
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
        public delegate void UpkeepButtonPressedEvent(object sender, EventArgs e);
        public event UpkeepButtonPressedEvent OnUkButtonPressedEvent;
        private void IaF_upkeepBtn1_OnButtonPressedEvent(object sender, EventArgs e)
        {
            if (OnUkButtonPressedEvent != null)
            {
                OnUkButtonPressedEvent(this, e); // passing the event
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


    }
}
