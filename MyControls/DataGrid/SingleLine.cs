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
//David Tzur
//Yaniv Avikzer
namespace FinalProjectForm
{
    //[DesignerCategory("Yaniv&David")]
    public partial class SingleLine : UserControl
    {
        private String Jobd;
        private int Enum;
        private DateTime Ddate;
        private String Ru;
        private bool Sta;
        private int flag;
        private int defulth;
        private int mainsize = 44;
        private int openupsize = 80;
        private Color closed;
        private Color opend;
        private Color MainColor = Color.FromArgb(255, 51, 51, 76);//blue
        private Color ExpierdColor = Color.FromArgb(255, 51, 51, 76);//blue

        public SingleLine()
        {
            InitializeComponent();

        }
        private int SInterval = 1; // defult speed is 1 milisecond (fast)
        [Category("New UI Props")]
        public int SpeedInterval
        {
            get { return SInterval; }
            set { SInterval = value; }
        }

        private bool boolconvertor(string tobool)
        {
            if (tobool == "בוצע") { return true; }
            return false;
        }

        [Category("New UI Props")]
        public bool Status
        {
            get { return Sta; }
            set
            {
                Sta = value;
                if (value) { Vlbl.Text = "בוצע"; } else { Vlbl.Text = "לא בוצע"; }
            }
        }
        [Category("New UI Props")]
        public String EngineTesters
        {
            get { return Ru; }
            set { Ru = value; Slbl.Text = value; }
        }
        [Category("New UI Props")]
        public DateTime DoneDate
        {
            get { return Ddate; }
            set { Ddate = value; Dlbl.Text = value.ToShortDateString(); }
        }
        [Category("New UI Props")]
        public int EngineNum
        {
            get { return Enum; }
            set { Enum = value; Eid.Text = value.ToString(); }
        }
        [Category("New UI Props")]
        public String JobDes
        {
            get { return Jobd; }
            set { Jobd = value; Tlbl.Text = value; }
        }

        public SingleLine(WorkList obj)
        {
            InitializeComponent();
            this.Height = mainsize;
            flag = 0;
            defulth = this.Height;
            EngineNum = obj.Engine_sn;
            JobDes = obj.Maintenance_desc;
            DoneDate = obj.Deadline_date;
            EngineTesters = obj.Worker_name;
            Status = boolconvertor(obj.Status);
            this.opend = ControlPaint.Light(MainColor);
            this.closed = MainColor;
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

        private void CloseSmooth_Tick_1(object sender, EventArgs e)
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

        private void OpenSmooth_Tick_1(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                if (this.Height < openupsize)
                {
                    this.Height += 3;
                }
                else
                {
                    flag = 1;
                    OpenSmooth.Enabled = false;
                }
                //button1.Text = "Hide";
            }
        }

        



        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {
            openclose();
        }


    }
}
