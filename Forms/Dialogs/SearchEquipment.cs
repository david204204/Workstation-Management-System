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
    public partial class SearchEquipment : Form
    {
        private DBSQL mySQL;


        public SearchEquipment(Equipment ShowInfo =null)
        {
            InitializeComponent();
            //Load data base stuff
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }
        private String CustomSQLCommand()//This will create a custom SQL query
        {
            int HowManyCommands = 0;
            //Command Strings to assmble the user query
            String Final = "SELECT * FROM `equipment`";
            String CommandWHERE = " WHERE ";
            //String CommandAND = " AND ";
            String CommandDescription = "`description` LIKE '" + description.Text + "'";
            String CommandDescriptionNotExsact = "`description` LIKE '%" + description.Text + "%'";
            String CommandSerialnumber = "`serialnumber` = '" + serialnumber.Text + "'";
            String CommandIafnumber = "`iafnumber` = '" + iafnumber.Text + "'";
            String CommandExpirationdate = "`expirationdate` = '" + expirationdate.Value.Year + "-" + expirationdate.Value.Month + "-" + expirationdate.Value.Day + "'";
            String CommandExpirationdatePassed = "`expirationdate` <= '" + expirationdate.Value.Year + "-" + expirationdate.Value.Month + "-" + expirationdate.Value.Day + "'";
            String CommandExpirationdateFrom = "`expirationdate` > '" + expirationdate.Value.Year + "-" + expirationdate.Value.Month + "-" + expirationdate.Value.Day + "'";
            String CommandDepartment = "`department` LIKE '" + department.Text + "'";
            String CommandDepartmentNotExsact = "`department` LIKE '%" + department.Text + "%'";

            //when the appropriate box checked add the corresponding command string
            //using two functions and one counter to decide when to add the "AND",WHERE" operators
            if (descriptionC.Checked == true) {
                if (descriptionCEX.Checked != true)
                {
                    CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                    Final = Final += CommandDescriptionNotExsact;
                }
                else
                {
                    CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                    Final = Final += CommandDescription;
                }
            }
            if (serialnumberC.Checked == true) {
                CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                Final = Final += CommandSerialnumber;
            }
            if (iafnumberC.Checked == true) {
                CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                Final = Final += CommandIafnumber;
            }
            if (expirationdateC.Checked == true) {
                if (DateFilter.SelectedIndex == 1)
                {
                    CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                    Final = Final += CommandExpirationdatePassed;
                }
                else if (DateFilter.SelectedIndex == 0)
                {
                    CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                    Final = Final += CommandExpirationdateFrom;
                }
                if(DateFilter.Text=="")
                {
                    CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                    Final = Final += CommandExpirationdate;
                }
            }
            if (departmentC.Checked == true) {
                if (departmentCEX.Checked != true)
                {
                    CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                    Final = Final += CommandDepartmentNotExsact;
                }
                else
                {
                    CustomSQLCommandAddon(ref HowManyCommands, ref Final, CommandWHERE);
                    Final = Final += CommandDepartment;
                }
            }
            return Final;
        } 

        public void CustomSQLCommandAddon(ref int counter,ref String command,String CommandAdd)
        {
            String CommandAND = " AND ";
            //decide when to add the "WHERE" & "AND" operators
            if (counter == 0)
            {
                command = command += CommandAdd;
            } else
            {
                command = command += CommandAND;
            }
            counter++;
        }

        private Equipment[] EqArr;

        public Equipment[] MyEquipment
            //This is a return array for the form
        {
            get { return EqArr; }
            set { EqArr = value; }
        }

        private void Exbtn_Click(object sender, EventArgs e)
        {
            MyEquipment = mySQL.SearchEquipmentData(CustomSQLCommand());
            //MessageBox.Show(CustomSQLCommand());
            this.Dispose();
        }

        private void FiledController(String Name)
        {
            //Enable or disable the corresponding fileds
            CheckBox ChB = this.Controls.Find(Name, true).FirstOrDefault() as CheckBox;
            var TxtB = this.Controls.Find(Name.Remove(Name.Length - 1, 1), true).FirstOrDefault();
            if (ChB.Checked)
            {
                TxtB.Enabled = true;
            }
            else
            {
                TxtB.Enabled = false;
            }
        }

        private void SerialnumberC_CheckedChanged(object sender, EventArgs e)
        {
            FiledController("SerialnumberC");
        }

        private void IafnumberC_CheckedChanged(object sender, EventArgs e)
        {
            FiledController("IafnumberC");
        }

        private void ExpirationdateC_CheckedChanged(object sender, EventArgs e)
        {
            FiledController("ExpirationdateC");
        }

        private void DescriptionC_CheckedChanged(object sender, EventArgs e)
        {
            FiledController("DescriptionC");
        }

        private void DepartmentC_CheckedChanged(object sender, EventArgs e)
        {
            FiledController("DepartmentC");
        }
    }
}
