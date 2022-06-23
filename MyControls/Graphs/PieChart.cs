using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

namespace FinalProjectForm.MyControls.Graphs
{
    public partial class PieChart : UserControl
    {
        private Color BColor;
        private Color Scolor;
        private Color Tcolor;
        private int Pross2;
        private int Pross;
        private int Thi = 0;
        private int LT = 0;

        [Category("New UI Props")]
        public Color TirdColor
        {
            get { return Tcolor; }
            set { Tcolor = value; this.Invalidate(); }
        } 
        [Category("New UI Props")]
        public Color SecondColor
        {
            get { return Scolor; }
            set { Scolor = value; this.Invalidate(); }
        }
        [Category("New UI Props")]
        public Color BaseColor
        {
            get { return BColor; }
            set { BColor = value; this.Invalidate(); }
        }
        public PieChart()
        {

            InitializeComponent();
            BColor = Color.Black;
            Scolor = Color.Blue;
            Tcolor = Color.Black;
            this.DoubleBuffered = true; // More Buffer to stop flickering 
        }



        [Category("New UI Props")]
        public int LineThikness
        {
            get { return Thi; }

        }
        [Category("New UI Props")]
        public int Part1
        {
            get { return Pross; }
            set {
                Pross = value;
                this.Invalidate(); // raise paint event
          }
        }
        [Category("New UI Props")]
        public int Part2
        {
            get { return Pross2; }
            set
            {
                Pross2 = value;
                this.Invalidate(); // raise paint event
            }
        }


        private float mx;
        [Category("New UI Props")]
        public float Maximum
        {
            get { return mx; }
            set { mx = value; this.Invalidate(); }
        }
      

        private void HalfCircleProssesBar_Paint(object sender, PaintEventArgs e)
        {
            //Removing ugly pixels from edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            //e.Graphics.TextRenderingHint = TextRenderingHint.ClearTypeGridFit;
            float myFloat = 3.6f;
            float MaxAngle = 360;
            float tmp = MaxAngle / mx;
            float tmp2 = MaxAngle / mx;
            // Adjust for process value
            float Fprosses = (int)(tmp * Pross);
            float Fprosses2 = (int)(tmp2 * Pross2);
            //Base Line Draw
            Pen myPen = new Pen(Color.Black, LT);
            int HalfHig = this.Height / 2;
            //Pie
            SolidBrush ColorOne = new SolidBrush(Color.FromArgb(255, 51, 51, 76));
            Rectangle rect = new Rectangle(0 + (Thi/2), 0+ (Thi/2), this.Height - 2, this.Height - 2);
            //e.Graphics.DrawPie(new Pen(new SolidBrush(Scolor), Thi), rect, 360, 360); // outline
            e.Graphics.FillPie(new SolidBrush(Scolor), rect, 360, 360);
                e.Graphics.FillPie(new SolidBrush(BColor), rect, MaxAngle, MaxAngle - Fprosses); // moving pie part
                e.Graphics.FillPie(new SolidBrush(Tcolor), rect, MaxAngle, Fprosses2); // moving pie part 2

            
        }
    }
}
