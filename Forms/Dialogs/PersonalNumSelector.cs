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
namespace FinalProjectForm.Forms.Dialogs
{
    public partial class PersonalNumSelector : Form
    {
        private int returnval;
        private String titletext;

        public String MyText // used to change the form title and heder when nedeed for other uses
        {
            get { return titletext; }
            set { titletext = value; this.Text= value; this.iaF_LabelSepertor1.MainText= value; }
        }

        private string uname;

        public string UserName
        {
            get { return uname; }
            set { uname = value; }
        }


        public int UserId // return var
        {
            get { return returnval; }
            set { returnval = value; }
        }


        private DBSQL mySQL;
        public PersonalNumSelector()
        {
            InitializeComponent();
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            FillData();
        }
        DataTable mydt = new DataTable();
        private void FillData()
        {
            //populate the datagrid
            dataGridView1.AutoGenerateColumns = true;
            mydt = mySQL.GetAllUsersData();
            dataGridView1.DataSource = mydt;
            //dataGridView1.DataMember = "users";
        }

        private void Keepbtn_Click(object sender, EventArgs e)
        {
            //returning the selected user personlan number and closing
            UserId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value.ToString());
            UserName = dataGridView1.SelectedCells[1].Value.ToString();
            //Keepbtn.Text = dataGridView1.SelectedCells[0].Value.ToString();
            this.Dispose();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            //Serch the data table for a user and show results in the datagrid
            mydt.DefaultView.RowFilter = "שם LIKE '%" + textBox1.Text + "%'";
            this.dataGridView1.DataSource = mydt.DefaultView;
        }
    }
}
