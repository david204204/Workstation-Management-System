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
    public partial class NewEditHr : Form
    {
        private DBSQL mySQL;
        private bool Edm=false;

        public bool EditMode
        {
            get { return Edm; }
            set { Edm = value; }
        }
        private int Pelid;
        private int hrid;

        public int HRIDholder
        {
            get { return hrid; }
            set { hrid = value; }
        }

        public int Personalid
        {
            get { return Pelid; }
            set { Pelid = value; useridnum.Text = value.ToString(); }
        }

        public NewEditHr(Hr ShowInfo =null)
        {
            InitializeComponent();
            //Load data base stuff
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        
                if (ShowInfo != null)
                {
                    //fill all filds from Hr obj if in edit mode
                    Exbtn.Text = "עדכן";
                    HRIDholder = ShowInfo.hrid;
                    useridnum.Enabled = false; // uneditble fileds when in edit mode
                    useridnum.Text = ShowInfo.PersonalID.ToString();
                    typeofactive.Text = ShowInfo.Type.ToString();
                    Fromdate.Value = ShowInfo.From_Date;
                    Todate.Value = ShowInfo.To_Date;
                    description.Text = ShowInfo.Description;

                }
 

        }

        private void Exbtn_Click(object sender, EventArgs e)
        {
            Hr HRUpdate = new Hr();
            HRUpdate.hrid = HRIDholder;
            HRUpdate.PersonalID = Convert.ToInt32(useridnum.Text);
            HRUpdate.Type = typeofactive.Text;
            HRUpdate.From_Date = Fromdate.Value;
            HRUpdate.To_Date = Todate.Value;
            HRUpdate.Description = description.Text;
            if (!EditMode)
            {//new mode
                mySQL.InsertNewHrRow(HRUpdate, false);
            }
            else
            {//edit mode
                mySQL.InsertNewHrRow(HRUpdate, true);
            }
            this.Dispose();
        }

    }
}
