using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectForm.MyControls.Graphs
{
    public partial class PieReadOut : UserControl
    {
        public PieReadOut()
        {
            InitializeComponent();
        }
        private string txt1;
        [Category("New UI Props")]
        public string Text1
        {
            get { return txt1; }
            set { txt1 = value; }
        }
        private string txt2;
        [Category("New UI Props")]
        public string Text2
        {
            get { return txt2; }
            set { txt2 = value; }
        }
        private string txt3;
        [Category("New UI Props")]
        public string Text3
        {
            get { return txt3; }
            set { txt3 = value; }
        }

        
        private PieChart mypie = new PieChart();
        [Category("New UI Props")]
        public PieChart MyLovlyPie
        {
            get { return mypie; }
            set { mypie = value; }
        }


        private void PieReadOut_Paint(object sender, PaintEventArgs e)
        {
            
                
                
            Rectangle rect1 = new Rectangle(this.Width-20 , this.Height-20 , 20, 20 );
            Rectangle rect2 = new Rectangle(this.Width-20 , this.Height/2 -(20/2) , 20, 20 );
            Rectangle rect3 = new Rectangle(this.Width-20 , 0 , 20, 20 );
            e.Graphics.FillRectangle(new SolidBrush(mypie.BaseColor), rect1);
            e.Graphics.FillRectangle(new SolidBrush(mypie.SecondColor), rect2);
            e.Graphics.FillRectangle(new SolidBrush(mypie.TirdColor), rect3);
         //text alignment
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            // drawing text
            Font myFont = new System.Drawing.Font("Helvetica", 13, FontStyle.Bold);
            e.Graphics.DrawString(txt1, myFont, new SolidBrush(mypie.TirdColor), this.Width /2, 10, sf);
            e.Graphics.DrawString(txt3, myFont, new SolidBrush(mypie.BaseColor), this.Width/2, this.Height-10, sf);
            e.Graphics.DrawString(txt2, myFont, new SolidBrush(mypie.SecondColor), this.Width / 2, this.Height / 2 , sf);

        }
    }
}
