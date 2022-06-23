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
namespace FinalProjectForm.Forms.Dialogs
{
    public partial class TaskEdit : Form
    {
        private DBSQL mySQL;
        public TaskEdit(Tasks ShowInfo)
        {
            InitializeComponent();
            //Load data base stuff
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            //fill all filds from tasks obj
            string typestr = ShowInfo.IntTypeToString(ShowInfo.TaskType.ToString()); // convert type to string for user display
            TaskID.Text = ShowInfo.TaskId.ToString();
            Title.Text = ShowInfo.MyTitle;
            DueDate.Value = ShowInfo.FinalDate;
            Details.Text = ShowInfo.TaskDetails;
            WorkerID.Text = ShowInfo.WorkingOn.ToString();
            TaskFinished.Text = ShowInfo.TaskDone.ToString();
            AssignedDate.Value = ShowInfo.AssignedDate;
            AssignedBy.Text = ShowInfo.AssignedBy.ToString();
            Type.Text = typestr;
            UserLevelAdjustment();
        }

        private void UserLevelAdjustment()
        {
            // Safe Keeping of task finished status
            // only users with the same or higher level of task creator can change the task status
            Users TaskCreator = new Users();
            TaskCreator = mySQL.GetUserData(Convert.ToInt32(AssignedBy.Text),"level"); // sending id of task creator to get the level
            if (GeneralCodeHelper.curentUser.Level < TaskCreator.Level)
            {
                TaskFinished.Enabled = false;
            }
            else { TaskFinished.Enabled = true; }

        }


        private void Exbtn_Click(object sender, EventArgs e)
        {
            Tasks UpdatedTask = new Tasks();
            int typeint = UpdatedTask.StringTypeToInt(Type.Text); // convert type to int
            UpdatedTask.TaskId = Convert.ToInt32(TaskID.Text);
            UpdatedTask.MyTitle = Title.Text;
            UpdatedTask.WorkingOn = Convert.ToInt32(WorkerID.Text);
            UpdatedTask.FinalDate = DueDate.Value;
            UpdatedTask.TaskDetails = Details.Text;
            UpdatedTask.TaskDone = Convert.ToBoolean(TaskFinished.Text);
            UpdatedTask.AssignedDate = AssignedDate.Value;
            UpdatedTask.AssignedBy = Convert.ToInt32(AssignedBy.Text);
            UpdatedTask.TaskType = typeint;

            mySQL.InsertNewTask(UpdatedTask, true);
            this.Dispose();
        }

        private void WorkerID_Click(object sender, EventArgs e)
        {
            //Get user id from list dialog
            PersonalNumSelector WorkerDialog = new PersonalNumSelector();
            WorkerDialog.ShowDialog();
            WorkerID.Text = WorkerDialog.UserId.ToString();
        }
    }
}
