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
namespace FinalProjectForm.Forms
{
    public partial class Login : Form
    {
            
        //Database related object
        private DBSQL mySQL;
        public Tasks NewTask;
        private WorkManger mainForm = null;
        public Login(Form callingForm)
        {
            InitializeComponent();
            mainForm = callingForm as WorkManger;
            //Setting sql connection parameters
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;

        }
        private bool Secses = false;

        public bool SecsessLoggdin
        {
            get { return Secses; }
            set { Secses = value; }
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            try
            {

                if (passtb.Text.Length>0 && pnumtb.Text.Length > 0) // make sure all texts boxes are filld
            {
                Users testsubject = mySQL.GetUserData(Convert.ToInt32(pnumtb.Text));
                if(Convert.ToInt32(passtb.Text) == testsubject.Password)// compare user input with database
                {// password is correct:
                    GeneralCodeHelper.curentUser = testsubject; // passing the logged in user info to static var for upcoming use
                                                                //mainForm.HideAllBtns(GeneralCodeHelper.curentUser.Level); // showing back the relevent buttons to the user
                        SecsessLoggdin = true;
                        this.Close();
                } else
                {// password is incorrect:
                 // user number or password is incorrect
                        SecsessLoggdin = false;
                    }
            } else
            {
                    // missing input
                    SecsessLoggdin = false;
                    ErrHandler.ErrShow(101, "ישנם שדות ריקים");
                }
            }
            catch (Exception)
            {
                SecsessLoggdin = false;
                ErrHandler.ErrShow(102, "שם משתמש או סיסמא לא נכונים");
            }
        }




    }
}
