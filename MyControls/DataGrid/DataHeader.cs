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
    public partial class DataHeader : UserControl
    {
        private String Jobd;
        private String Enum;
        private String Ddate;
        private String Ru;
        private String Sta;

        public DataHeader()
        {
            InitializeComponent();
        }

        [Category("New UI Props")]
        public String Status
        {
            get { return Sta; }
            set
            {
                Sta = value;
                Vlbl.Text = value;
            }
        }

        [Category("New UI Props")]
        public String EngineTesters
        {
            get { return Ru; }
            set { Ru = value; Slbl.Text = value; }
        }
        [Category("New UI Props")]
        public String DoneDate
        {
            get { return Ddate; }
            set { Ddate = value; Dlbl.Text = value; }
        }
        [Category("New UI Props")]
        public String EngineNum
        {
            get { return Enum; }
            set { Enum = value; Eid.Text = value; }
        }
        [Category("New UI Props")]
        public String JobDes
        {
            get { return Jobd; }
            set { Jobd = value; Tlbl.Text = value; }
        }
    }
}


