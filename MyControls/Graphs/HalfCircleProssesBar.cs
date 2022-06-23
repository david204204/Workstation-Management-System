using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FinalProjectForm.MyControls.Graphs
{
    public partial class HalfCircleProssesBar : UserControl
    {
        private Color BColor;
        private Color Scolor;
        private string txt;
        private int Pross;
        private int Thi = 10;
        private int LT = 10;

        [Category("New UI Props")]
        public string MainText
        {
            get { return txt; }
            set { txt = value; }
        }
        [Category("New UI Props")]
        public Color SecondColor
        {
            get { return Scolor; }
            set { Scolor = value; }
        }
        [Category("New UI Props")]
        public Color BaseColor
        {
            get { return BColor; }
            set { BColor = value; }
        }
        public HalfCircleProssesBar()
        {

            InitializeComponent();
            BColor = Color.Black;
            Scolor = Color.Blue;
            this.DoubleBuffered = true;
        }


        [Category("New UI Props")]
        public int LineThikness
        {
            get { return Thi; }
            set {
                Thi = value;
              
                this.Invalidate();
            }
        }
        [Category("New UI Props")]
        public int ProssesValue
        {
            get { return Pross; }
            set {
                Pross = value;
                this.Invalidate();
            }
        }



        private void HalfCircleProssesBar_Paint(object sender, PaintEventArgs e)
        {
            //Removing ugly pixels from edges
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            // Adjust for process value
            float myFloat = 1.8f;
            int Fprosses = (int)(Pross * myFloat);

            //Base Line Draw
            Pen myPen = new Pen(BColor, LT);
            int HalfHig = this.Height / 2;
            e.Graphics.DrawLine(myPen, 0, this.Height, this.Width, this.Height);
            //Circle
            Rectangle rect = new Rectangle(0 + (Thi/2), 0+ (Thi/2), this.Width- Thi, this.Height*2);
            e.Graphics.DrawArc(new Pen(new SolidBrush(Scolor), Thi), rect, 180, 180);
            e.Graphics.DrawArc(new Pen(new SolidBrush(BColor), Thi), rect, 180, 180 - Fprosses);
            //text alignment
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            // drawing text
            Font myFont = new System.Drawing.Font("Helvetica", 15, FontStyle.Italic);
            e.Graphics.DrawString(Pross + "%", myFont, new SolidBrush(BColor), this.Width / 2, this.Height / 2,sf);
            e.Graphics.DrawString(txt, myFont, new SolidBrush(BColor), this.Width / 2, this.Height - 15, sf);


        }
    }
}
