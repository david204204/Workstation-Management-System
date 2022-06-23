using FinalProjectForm.Forms.Dialogs;
using FinalProjectForm.InterfaceClases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testMySQLConnection;
namespace FinalProjectForm.Forms
{
    
    public partial class TasksForm : Form
    {
        //Database related object
        private DBSQL mySQL;
        public Tasks NewTask;
        //Part of new UI
        private SingleTaskView[] listitems = new SingleTaskView[int.Parse(ConfigurationManager.AppSettings["showMaxTasksElements"])];
        public TasksForm()
        {
            InitializeComponent();
            
            //Setting sql connection parameters
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
            //Kepping the task id not repiting
            TaskIndexUpdate();
            //Loading tasks from database
            FillTasksList();
            //FillUsersList(); // not needed
        }

        /// <summary>
        /// 
        /// </summary>
        private void TaskIndexUpdate()
        {
            int Maxid = mySQL.GetTaskMaxIdNumber();
            Tb_TaskID.Text = Maxid + 1 + "";
        }
        

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
            catch (NullReferenceException)
            {
                //TaskList is empty
                //ErrHandler.ErrShow(200, ex.ToString());
            }
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (isfullboxes())
            {
                //Setting up new local task object
                NewTask = new Tasks(Tb_TaskID.Text, TaskName.Text, duetimes.Text, TaskFreeText.Text, Personal.Text );
                NewTask.TaskType = NewTask.StringTypeToInt(TaskType.Text);
                //Saving that object to the database
                mySQL.InsertNewTask(NewTask);
                //Adding object to task list
                //tasksList1.AddItem(NewTask); --->
                FillTasksList();
                // clear all input filds
                //GeneralCodeHelper.RecurseClearAllTextBoxes(this.Parent); --->
                clearboxes();
                //Update the task index
                TaskIndexUpdate();
            }
            else
            ErrHandler.ErrShow(211, "ישנם שדות ריקים");
        }

        private void clearboxes()// clearing all fileds
        {
            TaskName.Clear();
            Personal.ResetText();
            TaskFreeText.Clear();
            duetimes.ResetText();
            TaskType.ResetText();
        }
        private bool isfullboxes()// returs true if all fields are full
        {
            if (TaskName.Text.Length>0 && Personal.Text.Length > 0 && TaskFreeText.Text.Length > 0 && duetimes.Text.Length > 0 && TaskType.Text.Length > 0)
            {
                return true;
            }
            return false;
        }
        private void Serchbtn_Click(object sender, EventArgs e)
        { 
            tasksList1.ClearList();
            Tasks[] FoundTasks;
            Tasks temp = new Tasks(); // only used for convestion
            int Showing = 0; // show finishd 0 no 1 yes
            String RadioSelected = GetRadiobut(); // get the radio btn currntly selected by the user
            String UserInout = WhatYouNeed.Text;// search input
            if (RadioSelected == "Type") WhatYouNeed.Text = temp.StringTypeToInt(UserInout).ToString();
            if (ShowDone.Checked) Showing++;
                FoundTasks = mySQL.SearchTasksBy(RadioSelected, WhatYouNeed.Text, Showing, LIKE.Checked); // get tasks
            WhatYouNeed.Text = UserInout;
            try
            {
                // fill task list
                for (int i = 0; i< FoundTasks.Length; i++)
                    tasksList1.AddItem(FoundTasks[i]);
            }
            catch (NullReferenceException)
            {
                //TaskList is empty
                ErrHandler.ErrShow(201, "לא נמצא מידע רלוונטי!");
            }
        }

        private String GetRadiobut()
        {
            if (SEcomboBox.Text == "מספר מטלה" ) return "TaskID";
            if (SEcomboBox.Text == "תיאור") return "Title";
            if (SEcomboBox.Text == "תאריך יעד") return "DueDate";
            if (SEcomboBox.Text == "חייל מבצע") return "WorkerID";
            if (SEcomboBox.Text == "סוג") return "Type";
            if (SEcomboBox.Text == "מזין מטלה") return "AssignedBy";
            return ""; // return the name of the data to search for
        }

        private void ExsactSwitch(bool Nedded)
        {
            if(!Nedded){
                LIKE.Checked = true;
                LIKE.Enabled = false;
            }
            else
            {
                //LIKE.Checked = true;
                LIKE.Enabled = !false;
            }
            
        }

        private void TY_CheckedChanged(object sender, EventArgs e)
        {
            ExsactSwitch(false);
        }

        private void NAM_CheckedChanged(object sender, EventArgs e)
        {
            ExsactSwitch(true);
        }

        private void DATED_CheckedChanged(object sender, EventArgs e)
        {
            ExsactSwitch(false);
        }

        private void PESO_CheckedChanged(object sender, EventArgs e)
        {
            ExsactSwitch(false);
        }

        private void GI_CheckedChanged(object sender, EventArgs e)
        {
            ExsactSwitch(false);
        }

        private void TN_CheckedChanged(object sender, EventArgs e)
        {
            ExsactSwitch(false);
        }

        private void TasksList1_EditButtonPresedps(object sender, EventArgs e, SingleTaskView taskatuse)
        {
            //when edit button is pressed
            Tasks ToEdit = mySQL.GetTaskById(taskatuse.TaskID);
            ToEdit.ShowEditTaskDialog();
            Serchbtn_Click(sender, e); // reload updated tasks
        }

        private void Personal_Click(object sender, EventArgs e)
        {
            PersonalNumSelector WorkerDialog = new PersonalNumSelector();
            WorkerDialog.ShowDialog();
            Personal.Text = WorkerDialog.UserId.ToString();

        }

        private void TasksList1_InfoButtonPresedps(object sender, EventArgs e, SingleTaskView taskatuse)
        {
            //when info button is pressed
            Tasks ToShow = mySQL.GetTaskById(taskatuse.TaskID);
            ToShow.ShowTaskMsg();
        }


        private void ExelExport_Click(object sender, EventArgs e)
        {
            GeneralCodeHelper.ExportExel_SwitchFunction(tasksList1.MyItemsList);
            
        }
    }
}
