using FinalProjectForm.DataObjects;
using FinalProjectForm.Forms.Dialogs;
using FinalProjectForm.InterfaceClases;
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
namespace FinalProjectForm.Forms
{
    
    public partial class EquipmentForm : Form
    {
        private DBSQL mySQL;
        public EquipmentForm()
        {
            InitializeComponent();
            //Setting sql connection parameters
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            FillEquipmentList();
        }
        private void FillEquipmentList(int Dep = 0)
        {
            //Loading tasks from database
            Equipment[] myEquipment;
            myEquipment = mySQL.GetEquipmentData();
            equipmentList1.ClearList();
            try
            {
                // fill task list
                for (int i = 0; i < myEquipment.Length; i++)
                    equipmentList1.AddItem(myEquipment[i]);
            }
            catch (NullReferenceException)
            {
                //myEquipment is empty
            }
        }

        private void EquipmentList1_EditButtonPresedps(object sender, EventArgs e, SingleEquipmentView Equipmentatuse)
        {
            // Edit Equipment via edit btn
            Equipment ToEdit = mySQL.GetEquipmentById(Equipmentatuse.MeSerialnumber);
            NewEditEquipment NewEditEDialog = new NewEditEquipment(ToEdit);
            NewEditEDialog.EditMode = true;
            NewEditEDialog.ShowDialog();
            FillEquipmentList();
        }

        private void NewEq_Click_1(object sender, EventArgs e)
        {
            // adding new New Equipment
            NewEditEquipment NewEditEDialog = new NewEditEquipment();
            //NewEditEDialog.EditMode=false;
            NewEditEDialog.ShowDialog();
            FillEquipmentList();
        }

        private void SeEq_Click(object sender, EventArgs e)
        {
            SearchEquipment SearchE = new SearchEquipment();
            SearchE.ShowDialog();
            equipmentList1.ClearList();
            try
            {
                // fill task list
                for (int i = 0; i < SearchE.MyEquipment.Length; i++)
                    equipmentList1.AddItem(SearchE.MyEquipment[i]);
            }
            catch (NullReferenceException)
            {
                //myEquipment is empty
            }
        }

        private void EquipmentList1_UpKeepButtonPresedps(object sender, EventArgs e, SingleEquipmentView Equipmentatuse)
        {
            // Opening upkeep dialog
            Equipment ToEdit = mySQL.GetEquipmentById(Equipmentatuse.MeSerialnumber);
            NewEditEquipment_UpKeep NewUpkeepDialog = new NewEditEquipment_UpKeep(ToEdit);
            NewUpkeepDialog.ShowDialog();
            
        }

        private void ExelExport_Click(object sender, EventArgs e)
        {
            GeneralCodeHelper.ExportExel_SwitchFunction(equipmentList1.MyItemsList);
        }


    }
}
