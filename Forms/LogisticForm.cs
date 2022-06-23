using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using testMySQLConnection;
using FinalProjectForm.DataObjects;
using System.Threading.Tasks;
using FinalProjectForm.InterfaceClases;
using FinalProjectForm.MyControls.WorkShop;

namespace FinalProjectForm.Forms
{
    public partial class LogisticForm : Form
    {
        public DBSQL DbC;

        WorkList[] worklist;
        public LogisticForm()
        {
            InitializeComponent();
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            DbC = DBSQL.Instance;
            LoadLogisticList();
            
        }

        public void LoadLogisticList() // shows the work list in data gridview when initial this func
        {
            iaF_WorkShop1.ClearList();

            ShopList[] shoplist;
            int qunNum;

            shoplist = DbC.GetLogisticFromDb();
            worklist = DbC.GetWorkListFromDb();
            try
            {
                for (int i = 0; i < shoplist.Length; i++)
                {


                    iaF_WorkShop1.Add(shoplist[i]);


                }
            }
            catch
            {
                //no work to load
            }



        }


        public async Task LogisticOrderHandler()
        {
            ShopList[] order;
            order = DbC.GetLogisticFromDb();


            string str1, str2, str3, str4;
            str1 = "testforfinalproject445@gmail.com";
            str2 = "david204204204@gmail.com";
            str3 = "123456789As";


            SmtpClient clientDetail = new SmtpClient();
            clientDetail.Port = 587;
            clientDetail.Host = "smtp.gmail.com";
            clientDetail.EnableSsl = true;
            clientDetail.DeliveryMethod = SmtpDeliveryMethod.Network;
            clientDetail.UseDefaultCredentials = false;
            clientDetail.Credentials = new NetworkCredential(str1.Trim(), str3.Trim());

            MailMessage mailDeatil = new MailMessage();
            mailDeatil.From = new MailAddress(str1.Trim());
            mailDeatil.To.Add(str2.Trim());


            string stringToSpprarte = null ;
            string[] spearator = { "," };
            stringToSpprarte = iaF_WorkShop1.GetAllCheckedItems();
            string[] strlist = stringToSpprarte.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
            string masg = null;
            string formasgbox = null;
            masg += "שלום רב \n\n\n";

            for (int i=0;i<order.Length;i++)
            {
                

                
                for(int j=0;j<strlist.Length;j++)
                {
                    if (strlist[j] == order[i].Product_sn)
                    {
                        if (order[i].QuantityAvailable == 10)
                        {
                            MessageBox.Show("נמצא שאין חוסר במלאי המבוקש, אנא הזמן פריט שחסר במלאי המחלקה");
                            break;
                        }
                        else
                        {
                            mailDeatil.Subject = "הזמנת פריטים";
                            mailDeatil.IsBodyHtml = false;
                            masg += (" \n"+"נדרש לבצע הזמנה לפריט מסח''א " + order[i].Product_sn + " סה''כ כמות של יחידות " + order[i].QuantityForOrder);
                            formasgbox +=  " \n"+"נשלחה בקשה לחידוש מלאי לרכיב " + order[i].Product_desc + " עבור כמות " + order[i].QuantityForOrder;
                            //mailDeatil.Body = "שלום, נדרש לבצע הזמנה לפריט מסח''א " + order[i].Product_sn + " סה''כ כמות של יחידות " + order[i].QuantityForOrder + " תודה";
                            
                            //clientDetail.Send(mailDeatil);
                            //MessageBox.Show("נשלחה בקשה לחידוש מלאי לרכיב " + order[i].Product_desc + " עבור כמות " + order[i].QuantityForOrder);

                        }
                    }

                }
                
                
                
            }
            masg += " \n\n\n תודה רבה";
            if(masg.Length>25)
            {
                mailDeatil.Body += masg;
                clientDetail.Send(mailDeatil);
            
            
                 MessageBox.Show(formasgbox);

            }

            
        }







        private void Button1_Click(object sender, EventArgs e)
        {

            //DbC.UpdateOrder("ווסת דלק", 10);
            //iaF_WorkShop1.Refresh();
            LoadLogisticList();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {


        }

        private void TrackBar1_Scroll(object sender, EventArgs e)
        {



        }

        private void orderNow_Click(object sender, EventArgs e)
        {
            //LogisticOrderHandler(orderingComboBox.SelectedItem.ToString());
        }

        private void orderNow_Click_1(object sender, EventArgs e)
        {
            //LogisticOrderHandler(orderingComboBox.SelectedItem.ToString());
        }

        private void orderNow_Click_2(object sender, EventArgs e)
        {

            
            if (iaF_WorkShop1.GetAllCheckedItems() == "" )
            {
                ErrHandler.ErrShow(990, "עליך לבחור רכיב תחילה");
            }
            else
            {
                LogisticOrderHandler(); 

            }


        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            if (iaF_WorkShop1.GetAllCheckedItems() == "")
            {
                ErrHandler.ErrShow(990, "עליך לבחור רכיב תחילה");
            }
            else
            {
                string stringToSpprarte = null;
                string[] spearator = { "," };
                stringToSpprarte = iaF_WorkShop1.GetAllCheckedItems();
                string[] strlist = stringToSpprarte.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                for(int i=0;i<strlist.Length;i++)
                {
                    DbC.UpdateOrder(strlist[i], 10);
                }
            
                LoadLogisticList();

            }
        }
    }
}

