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
using FinalProjectForm.InterfaceClases;

namespace FinalProjectForm.Forms
{
    public partial class ReportsForm : Form
    {
        private DBSQL DbC;
        public ReportsForm()
        {
            InitializeComponent();
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            DbC = DBSQL.Instance;


            Tasks[] AllTasks = DbC.GetAllTasksData();
            Tasks[] AllTasksWithFinished = DbC.GetAllTasksData(1);

            pieChart1.Maximum = AllTasks.Length;
            pieChart1.Part1 = 1;
            pieChart1.Part2 = AllTasks.Length - AllTasksWithFinished.Length;
            Equipment[] EChart = DbC.SearchEquipmentData("SELECT * FROM `equipment` WHERE `expirationdate` > '@Today'");
            Equipment[] ALLEChart = DbC.GetEquipmentData();
            halfCircleProssesBar1.ProssesValue = EChart.Length / ALLEChart.Length;
        }




    }
}
