using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectForm.DataObjects;
using testMySQLConnection;
using FinalProjectForm.Forms;
using FinalProjectForm.MyControls;


namespace FinalProjectForm.MyControls.WorkShop
{
    public partial class WorkShopLine : UserControl
    {
        DBSQL DbC;
        
        private string desc;
        private int sn_num;
        private int usedquan;
        private int quan;
        private int toorder;
        private string order;
        private Color MainColor = Color.FromArgb(255, 51, 51, 76);//blue
        private Color ExpierdColor = Color.Red;
        public WorkShopLine()
        {
            InitializeComponent();
            
        }
        public WorkShopLine(ShopList obj)
        {
            InitializeComponent();
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            DbC = DBSQL.Instance;
            
            Sn_num = Convert.ToInt32(obj.Product_sn);
            Desc = obj.Product_desc;
            QuantityAvi = obj.QuantityAvailable;
            UsedQuantity = obj.Quantityused;
            Toorder = obj.QuantityForOrder;
            

        }


        [Category("New UI Props")]
        public int Toorder
        {
                    
                get { return toorder; }
                set { toorder = value; Vlbl.Text = value.ToString(); }
            

        }
        [Category("New UI Props")]
        public int UsedQuantity
        {
            get { return usedquan; }
            set { usedquan = value; Slbl.Text = value.ToString(); }
        }
        [Category("New UI Props")]
        public int QuantityAvi
        {
            get { return quan; }
            set { quan = value; Dlbl.Text = value.ToString(); }
        }
        [Category("New UI Props")]
        public int Sn_num
        {
            get { return sn_num; }
            set { sn_num = value; Eid.Text = value.ToString(); }
        }
        [Category("New UI Props")]
        public string Desc
        {
            get { return desc; }
            set { desc = value; Tlbl.Text = value; }
        }


        private void TasksView_Paint(object sender, PaintEventArgs e)
        {


            if (QuantityAvi <= 3)
            {
                this.BackColor = ExpierdColor;

            }


        }


        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            


        }
    }
}
