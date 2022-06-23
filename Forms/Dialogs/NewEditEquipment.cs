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
using FinalProjectForm.InterfaceClases;
using FinalProjectForm.DataObjects;

namespace FinalProjectForm.Forms.Dialogs
{
    public partial class NewEditEquipment : Form
    {
        private DBSQL mySQL;
        private bool Edm=false;

        public bool EditMode
        {
            get { return Edm; }
            set { Edm = value; }
        }

        public NewEditEquipment(Equipment ShowInfo =null)
        {
            InitializeComponent();
            //Load data base stuff
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            if (ShowInfo != null) {
                //fill all filds from Equipment obj if in edit mode
                Exbtn.Text = "עדכן";
                serialnumber.Enabled = false;
                iafnumber.Enabled = false;
                serialnumber.Text = ShowInfo.SerialNumber.ToString();
                iafnumber.Text = ShowInfo.IAFnumber.ToString();
                expirationdate.Value = ShowInfo.ExpirationDate;
                description.Text = ShowInfo.Description;
                department.Text = ShowInfo.Department;

            }
        }

        private void Exbtn_Click(object sender, EventArgs e)
        {
            Equipment EquipmentUpdate = new Equipment();
            EquipmentUpdate.SerialNumber = Convert.ToInt32(serialnumber.Text);
            EquipmentUpdate.IAFnumber = Convert.ToInt32(iafnumber.Text);
            EquipmentUpdate.Department = department.Text;
            EquipmentUpdate.ExpirationDate = expirationdate.Value;
            EquipmentUpdate.Description = description.Text;
            if (!EditMode)
            {//new mode
                mySQL.InsertNewEquipment(EquipmentUpdate, false);
            }
            else
            {//edit mode
                mySQL.InsertNewEquipment(EquipmentUpdate, true);
            }
            this.Dispose();
        }

        private Decimal CameraScanner()
        {
            BarCodeReader BarCodeScanner = new BarCodeReader();
            BarCodeScanner.ShowDialog();
            //MessageBox.Show(tsts.ScanedBarCode);
            try
            {
                return Convert.ToDecimal(BarCodeScanner.ScanedBarCode);
            }
            catch (Exception)
            {
                ErrHandler.ErrShow(1000, "שגיאה בקריאת בר-קוד!");
            }
            return 0;
        }

        private void Scan_Click(object sender, EventArgs e)
        {
          
        }
        private void ScanIAFB_OnButtonPressedEvent(object sender, EventArgs e)
        {
            iafnumber.Value = CameraScanner();
        }

        private void IaF_BarCodeBtn1_OnButtonPressedEvent(object sender, EventArgs e)
        {
            serialnumber.Value = CameraScanner();
        }
    }
}
