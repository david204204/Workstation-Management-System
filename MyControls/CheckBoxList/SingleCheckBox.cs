using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectForm.MyControls.CheckBoxList
{
    public partial class SingleCheckBox : UserControl
    {
        public SingleCheckBox()
        {
            InitializeComponent();
        }
        public SingleCheckBox(String Text)
        {
            InitializeComponent();
            MeText = Text;
        }
        [Category("New UI Props")]
        public bool CheckedStatus
        {
            get { return iaF_CheckBox1.Checked; }
            set { iaF_CheckBox1.Checked = value; }
        }
        private String Te;
        [Category("New UI Props")]
        public String MeText 
        {
            get { return Te; }
            set { Te = value; Title.Text=value; }
        }


    }
}
