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
    public partial class NewEditEquipment_UpKeep : Form
    {
        private DBSQL mySQL;
        private DateTime thisDay = DateTime.Today;
        private DateTime ExpDay;
        Equipment EquipmentToUse;
        private int LoadSetting = 0;

        private DateTime TimeAddder(DateTime startdate,string typeofinspection)
        {
            //private DateTime DayilyUpKeep = DateTime.Today;
            // adding x days to given time
            System.TimeSpan HowMuchToAdd = new System.TimeSpan();
            switch (typeofinspection)
            {
                case "חצי שנתית":
                    HowMuchToAdd = new System.TimeSpan(182, 0, 0, 0);  // half year upkeep
                    break;

                case "שנתית":
                    HowMuchToAdd = new System.TimeSpan(364, 0, 0, 0);  // yearly upkeep
                    break;

                case "יומית":
                    HowMuchToAdd = new System.TimeSpan(1, 0, 0, 0);  // daily upkeep
                    break;

                case "שבועית":
                    HowMuchToAdd = new System.TimeSpan(7, 0, 0, 0);  // weekly upkeep
                    break;

                case "חודשית":
                    HowMuchToAdd = new System.TimeSpan(30, 0, 0, 0);  // montly upkeep
                    break;

                default:
                    ErrHandler.ErrShow(900,"נא לבחור פרק זמן!");
                    break;
            }
            System.DateTime FinalAfterAddon = startdate.Add(HowMuchToAdd);// saving the add time to new var
            return FinalAfterAddon; // returing the new  time after addon
        }
        public NewEditEquipment_UpKeep(Equipment ShowInfo =null)
        {
            InitializeComponent();
            //Load data base stuff
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            TodayLbl.Text = thisDay.ToShortDateString();
            EquipmentToUse = ShowInfo;
            this.Text = ShowInfo.Description;
            Upkeepdgv.DataSource = mySQL.GetAllEquipment_upkeep(EquipmentToUse.SerialNumber, LoadSetting);
        }

        private void Exbtn_Click(object sender, EventArgs e)
        {

        }

        private void SecondPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TypeCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // changing the timespan combo box to needen types
            if (typeCB.Text == "אחזקה")
            {
                this.TimespanCB.Items.Clear();
            this.TimespanCB.Items.AddRange(new object[] {
            "חצי שנתית",
            "שנתית"});
            } else
            {
                this.TimespanCB.Items.Clear();
                this.TimespanCB.Items.AddRange(new object[] {
            "יומית",
            "שבועית",
            "חודשית"});
            }
        }

        private void Addnewupkeep_Click(object sender, EventArgs e)
        {
            Equipment_UpKeep toadd = new Equipment_UpKeep();
            // input test
            if (typeCB.Text=="" || TimespanCB.Text == "")
            {
                ErrHandler.ErrShow(901, "ישנם שדות ריקים!");
            } else
            {
                //ukid is set at database level ai
                toadd.SerialNumber = EquipmentToUse.SerialNumber;
                toadd.UpKeepType = typeCB.Text;
                toadd.TimeSpan = TimespanCB.Text;
                toadd.ExtraInfo = ExtrainfoTB.Text;
                toadd.ExpirationDate = TimeAddder(thisDay, TimespanCB.Text);
                toadd.UpKeepDate = thisDay;
                try
                {
                    mySQL.InsertNewEquipment_upkeep(toadd);
                    Upkeepdgv.DataSource = mySQL.GetAllEquipment_upkeep(EquipmentToUse.SerialNumber,LoadSetting); // refresh data
                }
                catch (Exception)
                {
                    ErrHandler.ErrShow(902, "בעיה בהוספה!");
                }
            }

            
        }

        private void TimespanCB_SelectedIndexChanged(object sender, EventArgs e)
        {
            EXPlbl.Text = TimeAddder(thisDay, TimespanCB.Text).ToShortDateString();
        }

        private void DGVshow_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadSetting = DGVshow.SelectedIndex;
            Upkeepdgv.DataSource = mySQL.GetAllEquipment_upkeep(EquipmentToUse.SerialNumber, LoadSetting);
        }
        private void Upkeepdgv_Paint(object sender, PaintEventArgs e)
        {
            Upkeepdgv.Columns[0].Width = 40; // seting the id column width
        }
    }
}
