using FinalProjectForm.InterfaceClases;
using System;
using System.Windows.Forms;
using testMySQLConnection;

namespace FinalProjectForm.Forms
{
    
    public partial class TasksSerch : Form
    {
        //Database related object
        private DBSQL mySQL;
        public Tasks NewTask;
        //Part of new UI
        private SingleTaskView[] listitems = new SingleTaskView[20];
        public TasksSerch()
        {
            InitializeComponent();
            //Setting sql connection parameters
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            //Kepping the task id not repiting
            int Maxid = mySQL.GetTaskMaxIdNumber();
            Tb_TaskID.Text = Maxid + 1 + "";
            //Loading tasks from database
            FillTasksList();
          
        }


   
        /// <summary>
        /// Creating new tasks list and fill them
        /// </summary>
        /// <param name="usernum"> The User Name</param>
        /// <param name="archaive">Archive</param>
        private void FillTasksList(int usernum=0,int archaive=0)
        {
            //Loading tasks from database
            Tasks[] mytasks;
            if (usernum > 0)
            {
                mytasks = mySQL.GetTasksData(usernum); // get USER tasks
            }
            else
            {
                mytasks = mySQL.GetAllTasksData(archaive); // get all tasks
            }
            tasksList1.ClearList();
            try
            {
                // fill task list
                for (int i = 0; i < mytasks.Length; i++)
                    tasksList1.AddItem(mytasks[i]);
            }
            catch (NullReferenceException ex)
            {
                //TaskList is empty
                ErrHandler.ErrShow(401, ex.ToString());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TasksView1_Load(object sender, EventArgs e)
        {

        }

        private void SplitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TasksForm_Load(object sender, EventArgs e)
        {
           
        }
        
        private void TasksForm_Shown(object sender, EventArgs e)
        {
            
          
        }



        private void ArcTasks_CheckedChanged(object sender, EventArgs e)
        {
            if (ArcTasks.Checked == true) {
                FillTasksList(0, 1);
            } else
            {
                FillTasksList();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }
    }
}
