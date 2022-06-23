using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testMySQLConnection;
using FinalProjectForm.DataObjects;
using FinalProjectForm.Forms;
using FinalProjectForm.InterfaceClases;


//David tzur
//Yaniv avikzer

namespace FinalProjectForm.Forms
{
    public partial class WorkStations : Form
    {

        private DBSQL DbC;
        private bool button2WasClicked = false;
        private bool button4WasClicked = false;

        public WorkStations()
        {

            InitializeComponent();
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            DbC = DBSQL.Instance;
            LoadWorkers(); //intial the worker list from data base to workers check box
            LoadworkList();//intial the work list from data base to data grid view

        }

        
        private void LoadWorkers() // shows the workers list from data base to checkbox
        {
            Worker[] workers;
            workers = DbC.GetWorkersFromDb();

            
            for (int i = 0; i < workers.Length; i++)
            {
                checkedWorkersListBox.Items.Add(workers[i].Worker_id + "-" + workers[i].Worker_name);
                checkedWorkerListBox2.Items.Add(workers[i].Worker_id + "-" + workers[i].Worker_name);

            }

        }

        private void insertWorkList() // inserting work detail to data base
        {
            string names = "";
            string work_desc = "";
            string status = "לא בוצע";
            string classWork="";
            int qunNum=0,usedquan=0,orderquan=0;


            if(button2WasClicked)
            {
                mitkanInsertData(names, work_desc, status, classWork);

            }




            if(button4WasClicked)
            {

                yezorInsertData(names, work_desc, status, classWork, qunNum, usedquan, orderquan);

            }
           
            
        }

        private void yezorInsertData(string names, string work_desc, string status, string classWork, int qunNum, int usedquan, int orderquan)
        {
            if (engineSn2.Text == "" || statusCheckedCombo.SelectedIndex <= 0 || checkedWorkerListBox2.CheckedItems.Count <= 0)
            {
                MessageBox.Show("ישנם שדות ריקים");
            }
            else
            {
                classWork = "yezor";
                if (statusCheckedCombo.Items[statusCheckedCombo.SelectedIndex].ToString() == "בוצע")
                {
                    status = "בוצע";
                }
                for (int i = 0; i < checkedWorkerListBox2.CheckedItems.Count; i++)
                {
                    names += checkedWorkerListBox2.CheckedItems[i].ToString();
                    if (checkedWorkerListBox2.CheckedItems.Count > i + 1)
                    {
                        names += ", ";
                    }


                }
                for (int i = 0; i < workListchecker2.CheckedItems.Count; i++)
                {
                    work_desc += workListchecker2.CheckedItems[i].ToString();
                    if (workListchecker2.CheckedItems.Count > i + 1)
                    {
                        work_desc += ", ";
                    }



                    string str = workListchecker2.CheckedItems[i].ToString();


                    ShopList[] shoplist;
                    string[] spearator = { "החלפת " };
                    string[] strlist = str.Split(spearator, StringSplitOptions.RemoveEmptyEntries);
                    string str1 = strlist[0];
                    shoplist = DbC.GetLogisticFromDb();

                    upDatequan(shoplist, str1, qunNum, orderquan, usedquan);

                    

                }
                WorkList worklist = new WorkList(engineSn2.Text, names, deadLineDate2.Text, work_desc, status, classWork);
                DbC.InsertWorkListToDB(worklist);
            }
        }

        private void upDatequan(ShopList[] shoplist, string str1, int qunNum, int orderquan, int usedquan)
        {
            for (int f = 0; f < shoplist.Length; f++)
            {
                string wtf = shoplist[f].Product_desc;
                if (str1 == wtf)
                {
                    qunNum = shoplist[f].QuantityAvailable - 1;
                    usedquan = shoplist[f].Quantityused + 1;
                    orderquan = 10 - qunNum;

                    DbC.UpdateToNewQuantity(qunNum, usedquan, orderquan, str1);
                }
            }
        }

        private void mitkanInsertData(string names, string work_desc, string status, string classWork)
        {
            
            classWork = "mitkan";
            if (SNumberText.Text == "" || checkedRuningList.SelectedItems.Count <= 0 || checkedWorkersListBox.CheckedItems.Count <= 0)
            {
                MessageBox.Show("ישנם שדות ריקים");
            }
            else
            {
                if (checkBoxCombomitkan.Items[checkBoxCombomitkan.SelectedIndex].ToString() == "בוצע")
                {
                    status = "בוצע";
                }
                for (int i = 0; i < checkedWorkersListBox.CheckedItems.Count; i++)
                {
                    names += checkedWorkersListBox.CheckedItems[i].ToString();
                    if (checkedWorkersListBox.CheckedItems.Count > i + 1)
                    {
                        names += ", ";
                    }

                }
                for (int i = 0; i < checkedRuningList.CheckedItems.Count; i++)
                {
                    work_desc += checkedRuningList.CheckedItems[i].ToString();
                    if (checkedRuningList.CheckedItems.Count > i + 1)
                    {
                        work_desc += ", ";
                    }

                }

                WorkList worklist = new WorkList(SNumberText.Text, names, DeadlineDate.Text, work_desc, status, classWork);
                DbC.InsertWorkListToDB(worklist);
            }

            
        }

        private void LoadworkList() // shows the work list in data gridview when initial this func
        {
            iaF_DataGrid1.ClearList();
            iaF_DataGrid2.ClearList();
            WorkList[] worklist;
            worklist = DbC.GetWorkListFromDb();
            try
            {
                for (int i = 0; i < worklist.Length; i++)
                {
                    if (worklist[i].Status == "לא בוצע" && worklist[i].ClassWork == "mitkan")
                    {
                        
                        iaF_DataGrid1.Add(worklist[i]);
                    }
                    if (worklist[i].Status == "לא בוצע" && worklist[i].ClassWork == "yezor")
                    {

                        iaF_DataGrid2.Add(worklist[i]);
                    }
                }
            }
            catch
            {
                //no work to load
            }


        }



        private void button2_Click(object sender, EventArgs e)// button fill detail to datagridview and save it in data base
        {
            button2WasClicked = true;
            insertWorkList();
            LoadworkList();

        }


        private void UpDateBTN_Click(object sender, EventArgs e)// button change info in rows by using update func 
        {
            //UpDateDataGView(SNumberText.Text);
            DbC.UpdateIfWorkDone(SNumberText.Text, checkBoxCombomitkan.SelectedText);
            LoadworkList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4WasClicked = true;
            insertWorkList();
            LoadworkList();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DbC.UpdateIfWorkDone(engineSn2.Text, statusCheckedCombo.SelectedText);
            LoadworkList();
        }


    }
}
