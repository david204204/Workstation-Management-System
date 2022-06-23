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
    
    public partial class TasksViewer : Form
    {
        //Database related object
        private DBSQL mySQL;
        public Tasks NewTask;
        //Part of new UI
        private SingleTaskView[] listitems = new SingleTaskView[20];
        public TasksViewer()
        {
            InitializeComponent();
            //Setting sql connection parameters
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            FillTasksList();
        }

        private void FillTasksList()
        {
            //Loading tasks from database
            Tasks[] mytasks = mySQL.GetTasksData(GeneralCodeHelper.curentUser.personalnumber); // get tasks of the user
            tasksList1.ClearList();
            try
            {
                for (int i = 0; i < mytasks.Length; i++)
                    tasksList1.AddItem(mytasks[i]);
            }
            catch (NullReferenceException ex)
            {
                //TaskList is empty
            }
        }

        private void TableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TasksList1_InfoButtonPresedps(object sender, EventArgs e, SingleTaskView taskatuse)
        {
            //when info button is pressed
            Tasks ToShow = mySQL.GetTaskById(taskatuse.TaskID);
            ToShow.ShowTaskMsg();
        }
    }
}
