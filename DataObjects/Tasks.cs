using System;
using System.Windows.Forms;
using FinalProjectForm.Forms.Dialogs;
using FinalProjectForm.InterfaceClases;
namespace FinalProjectForm
{
    public class Tasks
    {
        private int Task_id;
        private DateTime DoneDate;
        private String Details;
        private int WorkerIds;
        private String title;
        private bool Finished=false;
        private DateTime AssData;
        private int AssBy;
        private int Ty;

        public int StringTypeToInt(String Type) // Functin get the type of task in int format and convert to string
        {
            if (Type == "אחזקה")  return 0;
            if (Type == "איכות") return 1;
            if (Type == "בטיחות") return 2;
            return 3;
        }
        public String IntTypeToString(String Type)// Functin get the type of task in string format and convert to int
        {
            if (Type == "0") return "אחזקה";
            if (Type == "1") return "איכות";
            if (Type == "2") return "בטיחות";
            return "";
        }
        public int TaskType //type of task property
        {
            //0 = Maintenance
            //1 = Quality
            //2 = Safety
            get { return Ty; }
            set { Ty = value; }
        }

        public string TaskTypeToString
        {
            get { return IntTypeToString(Ty.ToString()); }
        }

        public int AssignedBy // gets the user assinging the task from globalhelper class
        {
            get { return AssBy; }
            set { AssBy = value; }
        }

        public DateTime AssignedDate // this is set by the sql server
        {
            get { return AssData; }
            set { AssData = value; }
        }


        public bool TaskDone// when the task is done this will be set to true
        {
            get { return Finished; }
            set { Finished = value; }
        }

        public Tasks()
        {
            Task_id = 0;
            Details = "";
            WorkerIds = 0;
        }
        public Tasks(String taskid, String title, String timeto,String description, String personid)
        {

                MyTitle = title;
                Task_id = Int32.Parse(taskid);
                DoneDate = Convert.ToDateTime(timeto);
                Details = description;
                WorkerIds = Int32.Parse(personid);
                AssignedBy = GeneralCodeHelper.curentUser.personalnumber;
                //TaskType = TaskT;
        }


        public String MyTitle
        {
            get { return title; }
            set { title = value; }
        }

        public int WorkingOn
        {
            get { return WorkerIds; }
            set { WorkerIds = value; }
        }

        public String TaskDetails
        {
            get { return Details; }
            set { Details = value; }
        }

        public DateTime FinalDate
        {
            get { return DoneDate; }
            set { DoneDate = value; }
        }

        public int TaskId
        {
            get { return Task_id; }
            set { Task_id = value; }
        }

        public void ShowTaskMsg() // showing full info of the task to the user
        {
            //string typestr = IntTypeToString(TaskType.ToString()); // convert type to string for user display
            TaskFullInfo msg = new TaskFullInfo(this);
            msg.ShowDialog();
        }
        public void ShowEditTaskDialog() // showing full info of the task to the user
        {
            //string typestr = IntTypeToString(TaskType.ToString()); // convert type to string for user display
            TaskEdit Edit = new TaskEdit(this);
            Edit.ShowDialog();
        }

    }
}
