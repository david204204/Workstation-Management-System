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
    public partial class IAF_LabelSepertor : UserControl
    {
        private string _text;
        private int PD=10;
        private int TS=10;
        private int LT=1;
        private bool LLoc=true;
        [Category("New UI Props")]
        public bool LineLocation // true is up
        {
            get { return LLoc; }
            set { LLoc = value; }
        }

        [Category("New UI Props")]
        public int LineThickness
        {
            get { return LT; }
            set { LT = value; this.Invalidate(); }
        }

        [Category("New UI Props")]
        public int TextSize
        {
            get { return TS; }
            set { TS = value; label1.Font = new Font(label1.Font.Name, value, FontStyle.Bold); ; }
        }
        
        [Category("New UI Props")]
        public int PointDiamiter
        {
            get { return PD; }
            set { PD = value; label1.Padding = new Padding(0, value/2, value+(1), 0);
            this.Invalidate();
            }
        }

        [Category("New UI Props")]
        public string MainText
        {
            get { return _text; }
            set { _text = value; label1.Text = value; }
        }
        public IAF_LabelSepertor()
        {
            InitializeComponent();
        }

        private void IAFbluespacer_Load(object sender, EventArgs e)
        {

        }
        private int lineloc = 0;
        private int dotloc = 0;
        private void IAFbluespacer_Paint(object sender, PaintEventArgs e)
        {
            lineloc = PD / 2; // default value upper line
            if (!LLoc)
            {
                lineloc = this.Height - PD / 2;
                dotloc = this.Height - PD;
            }
            Pen myPen = new Pen(Color.FromArgb(255, 51, 51, 76), LT);
            SolidBrush mySolidBrush = new SolidBrush(Color.FromArgb(255, 51, 51, 76));
            e.Graphics.DrawLine(myPen, lineloc, lineloc, this.Width, lineloc);
            //draw l circle
            e.Graphics.DrawEllipse(myPen, dotloc, dotloc, PD, PD);
            e.Graphics.FillEllipse(mySolidBrush, dotloc, dotloc, PD, PD);
            //draw r circle
            int binign = this.Width - PD -1;
            e.Graphics.DrawEllipse(myPen, binign, dotloc, PD, PD);
            e.Graphics.FillEllipse(mySolidBrush, binign, dotloc, PD, PD);
            label1.Padding = new Padding(dotloc, PD / 2, PD , lineloc);
           
        }

        private void IAFbluespacer_Resize(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void IAFbluespacer_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
        }

        private void IAFbluespacer_Click(object sender, EventArgs e)
        {
            this.Invalidate();
        }


    }
}
