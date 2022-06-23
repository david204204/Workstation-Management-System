using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using FinalProjectForm;
using FinalProjectForm.InterfaceClases;
using FinalProjectForm.DataObjects;
using System.Configuration;
//Yaniv Avikzer
//David Tzur
namespace testMySQLConnection
{
    public class DBSQL : DBConnection
    {
        private static DBSQL instance;
        private DBSQL()
        {
            baseDatebaseName = ConfigurationManager.AppSettings["databaseName"];
            baseUserName = ConfigurationManager.AppSettings["username"];
            basePassword = ConfigurationManager.AppSettings["dbPassword"];
        }

        public static DBSQL Instance
        {
            get
            {
                if (instance == null)
                {
                    DBConnection connection = DBConnection.Instance();
                    instance = new DBSQL();
                }
                return instance;
            }
        }

        public static string DatabaseName
        {
            set
            {
                if (value != string.Empty)
                {
                    baseDatebaseName = value;
                }
            }
            get
            {
                return baseDatebaseName;
            }
        }

        public static string UserName
        {
            set
            {
                if (value != string.Empty)
                {
                    baseUserName = value;
                }
            }
            get
            {
                return UserName;
            }
        }

        public static string Password
        {
            set
            {
                if (value != string.Empty)
                {
                    basePassword = value;
                }
            }
            get
            {
                return Password;
            }
        }


        public int GetNumberOfListingInTable(string TableName)
        {
            int result;
            string cmdStr = "SELECT COUNT(*)FROM equipment";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@TName", TableName);
                result = ExecutScalarIntQuery(command);
            }

            return result;
        }

        //_______            _         
        //|__ __|           | |        
        //   | |  __ _  ___ | | __ ___ 
        //   | | / _` |/ __|| |/ // __|
        //   | || (_| |\__ \|   < \__ \
        //   |_| \__,_||___/|_|\_\|___/
        // from here

        //gets the biggest id number from tasks table
        public int GetTaskMaxIdNumber()
        {
            int result;
            string cmdStr = "SELECT max(TaskID) FROM tasks";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                result = ExecutScalarIntQuery(command);
            }

            return result;
        }
        //get task id number by parmeter and returns the same tasks with this id from data base 
        public Tasks GetTaskById(String taskidtofind)
        {
            DataSet das = new DataSet();
            DataTable dt = new DataTable();
            string cmdStr = "SELECT * FROM `tasks` WHERE `TaskID` = @ID";
            Tasks FoundT = new Tasks();
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@ID", taskidtofind);
                das = GetMultipleQuery(command);
            }

            try
            {
                dt = das.Tables[0];
                FoundT.TaskId = Convert.ToInt32(dt.Rows[0][0]);
                FoundT.MyTitle = dt.Rows[0][1].ToString();
                FoundT.FinalDate = Convert.ToDateTime(dt.Rows[0][2]);
                FoundT.TaskDetails = dt.Rows[0][3].ToString();
                FoundT.WorkingOn = Convert.ToInt32(dt.Rows[0][4]);
                FoundT.TaskDone = Convert.ToBoolean(dt.Rows[0][5]);
                FoundT.AssignedDate = Convert.ToDateTime(dt.Rows[0][6]);
                FoundT.AssignedBy = Convert.ToInt32(dt.Rows[0][7]);
                FoundT.TaskType = Convert.ToInt32(dt.Rows[0][8]);
            }
            catch (Exception e)
            {
                ErrHandler.ErrShow(300, e.ToString());
            }
            return FoundT;
        }
        // insert a new task or update it
        public void InsertNewTask(FinalProjectForm.Tasks Item, bool Update = false)
        {
            string cmdStr;
            if (!Update)
            {
                cmdStr = "INSERT INTO tasks (TaskID,Title, DueDate,Details,WorkerID,AssignedBy,Type) VALUES (@TaskID,@Title, @DueDate,@Details,@WorkerID,@AssignedBy,@Type)";
            }
            else
            {
                cmdStr = "UPDATE tasks SET Type = @Type, Title = @Title,DueDate = @DueDate,Details = @Details,WorkerID = @WorkerID,TaskFinished = @TaskFinished  Where TaskID = @TaskID";
            }

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {

                command.Parameters.AddWithValue("@TaskID", Item.TaskId);
                command.Parameters.AddWithValue("@Title", Item.MyTitle);
                command.Parameters.AddWithValue("@DueDate", Item.FinalDate);
                command.Parameters.AddWithValue("@Details", Item.TaskDetails);
                command.Parameters.AddWithValue("@WorkerID", Item.WorkingOn);
                command.Parameters.AddWithValue("@AssignedBy", Item.AssignedBy);
                command.Parameters.AddWithValue("@Type", Item.TaskType);
                command.Parameters.AddWithValue("@TaskFinished", Item.TaskDone);
                base.ExecuteSimpleQuery(command); // Save it!

            }
        }
        public Tasks[] GetTasksData(int userpernum) // this will return all of the tasks for the user in the data base
        {
            //Loading tasks from database returing tasks obj array
            DataSet ds = new DataSet();
            Tasks[] mytsaks = null;
            string cmdStr = "SELECT * FROM tasks WHERE WorkerID = @User AND TaskFinished = 0";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@User", userpernum);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {

                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                mytsaks = new Tasks[dt.Rows.Count];
                for (int i = 0; i < mytsaks.Length; i++)
                {
                    mytsaks[i] = new Tasks();
                    mytsaks[i].TaskId = Convert.ToInt32(dt.Rows[i][0]);
                    mytsaks[i].MyTitle = dt.Rows[i][1].ToString();
                    mytsaks[i].FinalDate = Convert.ToDateTime(dt.Rows[i][2]);
                    mytsaks[i].TaskDetails = dt.Rows[i][3].ToString();
                    mytsaks[i].WorkingOn = Convert.ToInt32(dt.Rows[i][4]);
                    mytsaks[i].TaskDone = Convert.ToBoolean(dt.Rows[i][5]);
                    mytsaks[i].AssignedDate = Convert.ToDateTime(dt.Rows[i][6]);
                    mytsaks[i].AssignedBy = Convert.ToInt32(dt.Rows[i][7]);
                    mytsaks[i].TaskType = Convert.ToInt32(dt.Rows[i][8]);
                }
            }
            return mytsaks;
        }
        //************************************
        //search of task by multy parameters
        public Tasks[] SearchTasksBy(String ByWhat, String SearchFor, int showfinished = 0, bool Exact = true,bool ExportExel = false)
        {
            //Loading tasks from database returing tasks obj array
            DataSet ds = new DataSet();
            Tasks[] mytsaks = null;
            string cmdStr;
            if (ByWhat == "" || SearchFor == "")// make sure the user gave content to search for
                                                //if not display all tasks
            {
                cmdStr = "SELECT * FROM `tasks` WHERE TaskFinished = 0 OR @showfinished";
            }
            else
            {
                if (Exact)                {//Exact search
                    cmdStr = "SELECT * FROM tasks WHERE @ByWhat = @SearchFor AND TaskFinished BETWEEN 0 AND @showfinished";                }                else                {                    cmdStr = "SELECT * FROM `tasks` WHERE @ByWhat LIKE '%@SearchFor%' AND TaskFinished BETWEEN 0 AND @showfinished";                }

            }
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@ByWhat", ByWhat);
                command.Parameters.AddWithValue("@SearchFor", SearchFor);
                command.Parameters.AddWithValue("@showfinished", showfinished);
                
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
                

            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                mytsaks = new Tasks[dt.Rows.Count];
                for (int i = 0; i < mytsaks.Length; i++)
                {
                    mytsaks[i] = new Tasks();
                    mytsaks[i].TaskId = Convert.ToInt32(dt.Rows[i][0]);
                    mytsaks[i].MyTitle = dt.Rows[i][1].ToString();
                    mytsaks[i].FinalDate = Convert.ToDateTime(dt.Rows[i][2]);
                    mytsaks[i].TaskDetails = dt.Rows[i][3].ToString();
                    mytsaks[i].WorkingOn = Convert.ToInt32(dt.Rows[i][4]);
                    mytsaks[i].TaskDone = Convert.ToBoolean(dt.Rows[i][5]);
                    mytsaks[i].AssignedDate = Convert.ToDateTime(dt.Rows[i][6]);
                    mytsaks[i].AssignedBy = Convert.ToInt32(dt.Rows[i][7]);
                    mytsaks[i].TaskType = Convert.ToInt32(dt.Rows[i][8]);
                }
            }
            //GeneralCodeHelper.ExportExel_Tasks_obj(mytsaks);
            return mytsaks;
        }
        //*************************************
        //serching tasks by using multy parmeters
        public DataTable SearchTasksByDATAGRID(String ByWhat, String SearchFor, int showfinished = 0, bool Exact = true)
        {
            //Loading tasks from database returing tasks obj array
            DataSet ds = new DataSet();
            Tasks[] mytsaks = null;
            string cmdStr;
            if (ByWhat == "" || SearchFor == "")// make sure the user gave contcst to search for
                                                //if not display all tasks
            {
                cmdStr = "SELECT * FROM `tasks` WHERE TaskFinished = 0 OR @showfinished";
            }
            else
            {
                if (Exact)
                {//Exact search
                    cmdStr = "SELECT * FROM `tasks` WHERE `@ByWhat` = '@SearchFor' AND `TaskFinished` BETWEEN 0 AND @showfinished";
                }
                else
                {
                    cmdStr = "SELECT * FROM `tasks` WHERE @ByWhat LIKE '% @SearchFor %' AND `TaskFinished` BETWEEN 0 AND @showfinished";
                }
            }
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@ByWhat", ByWhat);
                command.Parameters.AddWithValue("@SearchFor", SearchFor);
                command.Parameters.AddWithValue("@showfinished", showfinished);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
                dt.Columns["TaskID"].ColumnName = "מספר מטלה";
            }
            catch
            {

            }

            return dt;
        }// TESTING ONLY
        public Tasks[] GetAllTasksData(int showfinished = 0) // this will return all of the tasks in database
        {
            //Loading tasks from database returing tasks obj array
            DataSet ds = new DataSet();
            Tasks[] mytsaks = null;
            string cmdStr = "SELECT * FROM `tasks` WHERE TaskFinished = 0 OR @showfinished";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@showfinished", showfinished);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                mytsaks = new Tasks[dt.Rows.Count];
                for (int i = 0; i < mytsaks.Length; i++)
                {
                    mytsaks[i] = new Tasks();
                    mytsaks[i].TaskId = Convert.ToInt32(dt.Rows[i][0]);
                    mytsaks[i].MyTitle = dt.Rows[i][1].ToString();
                    mytsaks[i].FinalDate = Convert.ToDateTime(dt.Rows[i][2]);
                    mytsaks[i].TaskDetails = dt.Rows[i][3].ToString();
                    mytsaks[i].WorkingOn = Convert.ToInt32(dt.Rows[i][4]);
                    mytsaks[i].TaskDone = Convert.ToBoolean(dt.Rows[i][5]);
                    mytsaks[i].AssignedDate = Convert.ToDateTime(dt.Rows[i][6]);
                    mytsaks[i].AssignedBy = Convert.ToInt32(dt.Rows[i][7]);
                    mytsaks[i].TaskType = Convert.ToInt32(dt.Rows[i][8]);
                }
            }
            return mytsaks;
        }

        //  _    _                       
        // | |  | |                      
        // | |  | | ___   ___  _ __  ___ 
        // | |  | |/ __| / _ \| '__|/ __|
        // | |__| |\__ \|  __/| |   \__ \
        //  \____/ |___/ \___||_|   |___/
        // from here


        // gets the user password by personal number
        public int GetUserPassword(int userpernum)
        {
            int result;
            string cmdStr = "SELECT `password` FROM `users` WHERE personalnumber = @personalnumber";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@personalnumber", userpernum);
                result = ExecutScalarIntQuery(command);
            }
            return result;
        }

        // gets user data by user pesonal number
        public Users GetUserData(int userpernum, String DataTypeToReturn = "All")
        {
            //Loading tasks from database returing tasks obj array
            DataSet ds = new DataSet();
            Users User = null;
            string cmdStr;
            if (DataTypeToReturn == "All")
            {
                cmdStr = "SELECT * FROM `users` WHERE personalnumber = @personalnumber";
            } else {
                cmdStr = "SELECT (" + DataTypeToReturn + ") FROM `users` WHERE personalnumber = " + userpernum;
            }
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@personalnumber", userpernum);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (DataTypeToReturn == "All")
            {
                User = new Users(Convert.ToInt32(dt.Rows[0][0]), dt.Rows[0][1].ToString(), Convert.ToInt32(dt.Rows[0][2]), Convert.ToInt32(dt.Rows[0][3]));
            }
            else
            {
                User = new Users(0, "0", 0, Convert.ToInt32(dt.Rows[0][0]));
            }
            return User;
        }

        public DataTable GetAllUsersData(int User_Level_BETWEEN1_and = 3) // this will return all of the Users in database
        {
            DataSet ds = new DataSet();
            string cmdStr = "SELECT * FROM users WHERE `level` BETWEEN 1 AND @userlevel";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@userlevel", User_Level_BETWEEN1_and);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
                //renameing some columes to heb for the user
                dt.Columns["personalnumber"].ColumnName = "מספר אישי";
                dt.Columns["fname"].ColumnName = "שם";
                //Removing unneeded colums from datatable
                dt.Columns.Remove("password");
                dt.Columns.Remove("level");
            }
            catch
            {

            }
            return dt;
        }



        // ______               _                                 _   
        //|  ____|             (_)                               | |  
        //| |__    __ _  _   _  _  _ __   _ __ ___    ___  _ __  | |_ 
        //|  __|  / _` || | | || || '_ \ | '_ ` _ \  / _ \| '_ \ | __|
        //| |____| (_| || |_| || || |_) || | | | | ||  __/| | | || |_ 
        //|______|\__, | \__,_||_|| .__/ |_| |_| |_| \___||_| |_| \__|
        //           | |          | |                                 
        //           |_|          |_|                                 
        // from here

        // insert new equipment to data base
        public void InsertNewEquipment(FinalProjectForm.DataObjects.Equipment Item, bool Update = false)
        {
            string cmdStr;
            if (!Update)
            {
                cmdStr = "INSERT INTO equipment (description,serialnumber ,iafnumber,expirationdate,department) VALUES (@description,@serialnumber , @iafnumber,@expirationdate,@department)";
            }
            else
            {
                cmdStr = "UPDATE equipment SET description = @description, serialnumber = @serialnumber,iafnumber = @iafnumber,expirationdate = @expirationdate,department = @department  Where serialnumber ='" + Item.SerialNumber + "'";
            }
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@description", Item.Description);
                command.Parameters.AddWithValue("@serialnumber", Item.SerialNumber);
                command.Parameters.AddWithValue("@iafnumber", Item.IAFnumber);
                command.Parameters.AddWithValue("@expirationdate", Item.ExpirationDate);
                command.Parameters.AddWithValue("@department", Item.Department);
                base.ExecuteSimpleQuery(command); // Save it!

            }
        }
        public Equipment[] GetEquipmentData(int serialnumber = 0) // this will return all of the tasks for the user in the data base
        {
            //Loading tasks from database returing tasks obj array
            DataSet ds = new DataSet();
            Equipment[] Eitem = null;
            string cmdStr;
            if (serialnumber == 0)
            {// get all items
                cmdStr = "SELECT * FROM equipment";
            }
            else
            { // get items by sl
                cmdStr = "SELECT * FROM equipment WHERE serialnumber  = @serialnumber";
            }
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@serialnumber", serialnumber);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                Eitem = new Equipment[dt.Rows.Count];
                for (int i = 0; i < Eitem.Length; i++)
                {
                    Eitem[i] = new Equipment();
                    Eitem[i].Description = dt.Rows[i][0].ToString();
                    Eitem[i].SerialNumber = Convert.ToInt32(dt.Rows[i][1]);
                    Eitem[i].IAFnumber = Convert.ToInt32(dt.Rows[i][2]);
                    Eitem[i].ExpirationDate = Convert.ToDateTime(dt.Rows[i][3]);
                    Eitem[i].Department = dt.Rows[i][4].ToString();
                }
            }
            
            return Eitem;
        }
        // get equipment by id from data base
        public Equipment GetEquipmentById(int Equipmentidtofind)
        {
            DataSet das = new DataSet();
            DataTable dt = new DataTable();
            string cmdStr = "SELECT * FROM `equipment` WHERE `serialnumber` = @serialnumber";
            Equipment Eitem = new Equipment();
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@serialnumber", Equipmentidtofind);
                das = GetMultipleQuery(command);
            }

            try
            {
                dt = das.Tables[0];
                Eitem = new Equipment();
                Eitem.Description = dt.Rows[0][0].ToString();
                Eitem.SerialNumber = Convert.ToInt32(dt.Rows[0][1]);
                Eitem.IAFnumber = Convert.ToInt32(dt.Rows[0][2]);
                Eitem.ExpirationDate = Convert.ToDateTime(dt.Rows[0][3]);
                Eitem.Department = dt.Rows[0][4].ToString();
            }
            catch (Exception e)
            {
                ErrHandler.ErrShow(310, e.ToString());
            }
            return Eitem;
        }
        //**************************evgiya
        public Equipment[] SearchEquipmentData(String SQLCommand) // this will return all of the tasks for the user in the data base
        {
            //Loading tasks from database returning tasks obj array
            DataSet ds = new DataSet();
            Equipment[] Eitem = null;
            string cmdStr = SQLCommand;
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                
                command.Parameters.AddWithValue("@Today", DateTime.Now.ToShortDateString());
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                Eitem = new Equipment[dt.Rows.Count];
                for (int i = 0; i < Eitem.Length; i++)
                {
                    Eitem[i] = new Equipment();
                    Eitem[i].Description = dt.Rows[i][0].ToString();
                    Eitem[i].SerialNumber = Convert.ToInt32(dt.Rows[i][1]);
                    Eitem[i].IAFnumber = Convert.ToInt32(dt.Rows[i][2]);
                    Eitem[i].ExpirationDate = Convert.ToDateTime(dt.Rows[i][3]);
                    Eitem[i].Department = dt.Rows[i][4].ToString();
                }
            }
            return Eitem;
        }

        // __          __           _      _____  _          _    _               
        // \ \        / /          | |    / ____|| |        | |  (_)              
        //  \ \  /\  / /___   _ __ | | __| (___  | |_  __ _ | |_  _   ___   _ __  
        //   \ \/  \/ // _ \ | '__|| |/ / \___ \ | __|/ _` || __|| | / _ \ | '_ \ 
        //    \  /\  /| (_) || |   |   <  ____) || |_| (_| || |_ | || (_) || | | |
        //     \/  \/  \___/ |_|   |_|\_\|_____/  \__|\__,_| \__||_| \___/ |_| |_|
        // from here
        public Worker[] GetWorkersFromDb() // this will return all of the workers in database
        {
            //Loading tasks from database returing tasks obj array
            //DBSQL.Instance(); 
            DataSet ds = new DataSet();
            Worker[] workers = null;
            //string cmdStr = "SELECT * FROM workers";
            string cmdStr = "SELECT workers.worker_id, users.fname, workers.worker_role,workers.worker_class FROM workers INNER JOIN users ON workers.worker_id = users.personalnumber";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                workers = new Worker[dt.Rows.Count];
                for (int i = 0; i < workers.Length; i++)
                {
                    workers[i] = new Worker();
                    workers[i].Worker_id = Convert.ToInt32(dt.Rows[i][0]);
                    workers[i].Worker_name = dt.Rows[i][1].ToString();
                    workers[i].Worker_role = dt.Rows[i][2].ToString();
                    workers[i].Worker_class = dt.Rows[i][3].ToString();

                }
            }
            return workers;
        }

        public void InsertWorkListToDB(FinalProjectForm.WorkList Item) //will insert the work to data bsae 
        {
            string cmdStr = "INSERT INTO worklist (engine_sn,maintenance_desc, deadline_date,workers, status, work_class) VALUES (@engine_sn,@maintenance_desc, @deadline_date,@workers, @status, @work_class)";

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@engine_sn", Item.Engine_sn);
                command.Parameters.AddWithValue("@maintenance_desc", Item.Maintenance_desc);
                command.Parameters.AddWithValue("@deadline_date", Item.Deadline_date);
                command.Parameters.AddWithValue("@workers", Item.Worker_name);
                command.Parameters.AddWithValue("@status", Item.Status);
                command.Parameters.AddWithValue("@work_class", Item.ClassWork);

                base.ExecuteSimpleQuery(command); // Save it!

            }
        }

        public void UpDateWorkListToDB(FinalProjectForm.WorkList Item) //will update the work station in data base
        {

            string cmdStr = "UPDATE worklist SET engine_sn = @engine_sn, maintenance_desc = @maintenance_desc, deadline_date = @deadline_date, workers=@workers, status = @status Where engine_sn = @engine_sn";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@engine_sn", Item.Engine_sn);
                command.Parameters.AddWithValue("@maintenance_desc", Item.Maintenance_desc);
                command.Parameters.AddWithValue("@deadline_date", Item.Deadline_date);
                command.Parameters.AddWithValue("@workers", Item.Worker_name);
                command.Parameters.AddWithValue("@status", Item.Status);

                base.ExecuteSimpleQuery(command); // Save it!

            }
        }

        public WorkList[] GetWorkListFromDb() // this will return all of the work list in database
        {
            //Loading tasks from database returing tasks obj array
            //DBSQL.Instance(); 
            DataSet ds = new DataSet();
            WorkList[] worklist = null;
            string cmdStr = "SELECT * FROM worklist";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                worklist = new WorkList[dt.Rows.Count];
                for (int i = 0; i < worklist.Length; i++)
                {
                    worklist[i] = new WorkList();
                    worklist[i].Engine_sn = Convert.ToInt32(dt.Rows[i][1]);
                    worklist[i].Maintenance_desc = dt.Rows[i][2].ToString();
                    worklist[i].Deadline_date = Convert.ToDateTime(dt.Rows[i][3]);
                    worklist[i].Worker_name = dt.Rows[i][4].ToString();
                    worklist[i].Status = dt.Rows[i][5].ToString();
                    worklist[i].ClassWork = dt.Rows[i][6].ToString();


                }
            }
            return worklist;
        }

        public ShopList[] GetLogisticFromDb() // this will return all of the logistic list in database
        {
            //Loading logistic from database returing tasks obj array
            //DBSQL.Instance(); 
            DataSet ds = new DataSet();
            ShopList[] shopList = null;
            string cmdStr = "SELECT * FROM logistic";


            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                shopList = new ShopList[dt.Rows.Count];
                for (int i = 0; i < shopList.Length; i++)
                {
                    shopList[i] = new ShopList();
                    shopList[i].Product_sn = dt.Rows[i][1].ToString();
                    shopList[i].Product_desc = dt.Rows[i][4].ToString();
                    shopList[i].QuantityAvailable = Convert.ToInt32(dt.Rows[i][2]);
                    shopList[i].Quantityused = Convert.ToInt32(dt.Rows[i][3]);
                    shopList[i].QuantityForOrder = Convert.ToInt32(dt.Rows[i][5]);
                    shopList[i].ClassWork = dt.Rows[i][6].ToString();


                }
            }
            return shopList;
        }
        
        //update new logistic quantity by entering used numbers, order numbers by parameters that contains name of the product used in Job
        //updets only if insert new job to doing list
        public void UpdateToNewQuantity(int num, int used, int order, string str)
        {
            /* WHERE product_description="+"'"+str+"'*/
            string cmdStr = "UPDATE logistic SET availablequantity=@availablequantity, used_quantity=@used_quantity, ordering_quantity=@ordering_quantity WHERE product_description LIKE " + "'" + str + "'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@availablequantity", num);
                command.Parameters.AddWithValue("@used_quantity", used);
                command.Parameters.AddWithValue("@ordering_quantity", order);


                base.ExecuteSimpleQuery(command); // Save it!

            }

        }
        //update the quantity of the logistic to new reserve
        public void UpdateOrder(string Desc, int Toorder)
        {


            string cmdStr = "UPDATE logistic SET availablequantity=@availablequantity, ordering_quantity=@ordering_quantity WHERE product_sn LIKE " + "'" + Desc + "'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@availablequantity", Toorder);

                command.Parameters.AddWithValue("@ordering_quantity", 0);


                base.ExecuteSimpleQuery(command); // Save it!


            }

        }

        //chenge status id done or not
        public void UpdateIfWorkDone(string engineNum, string statusUpdated)
        {


            string cmdStr = "UPDATE worklist SET status=@status WHERE engine_sn = " + "'" + engineNum + "'";
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@status", statusUpdated);





                base.ExecuteSimpleQuery(command); // Save it!


            }

        }






        //HR
        //this function return sql line by choose if we want to see every hr constrains even if there date was expired or just the relevant one
        private string GetAllHrDataForUser_switch(int show)
        {
            switch (show)
            {
                case 0: return "SELECT hr.*, users.fname FROM hr, users WHERE hr.personalID = users.personalnumber AND personalID LIKE @Userid"; ;// all
                case 1: return "SELECT hr.*, users.fname FROM hr, users WHERE hr.personalID = users.personalnumber AND personalID LIKE @Userid AND `todate` > @Today"; //Only relevent
                default: return "SELECT hr.*, users.fname FROM hr, users WHERE hr.personalID = users.personalnumber AND personalID LIKE @Userid";// all
            }
        }
        public Hr[] GetAllHrDataForUser(int userid, int date = 0) // this will return all of the tasks in database
        {
            //Loading tasks from database returing tasks obj array
            DataSet ds = new DataSet();
            Hr[] myhr = null;
            string cmdStr = GetAllHrDataForUser_switch(date); //0 is defult
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@Today", DateTime.Today);
                command.Parameters.AddWithValue("@Userid", userid);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
            }
            catch
            {

            }
            if (dt.Rows.Count > 0)
            {
                myhr = new Hr[dt.Rows.Count];
                for (int i = 0; i < myhr.Length; i++)
                {
                    myhr[i] = new Hr();
                    myhr[i].hrid = Convert.ToInt32(dt.Rows[i][0]);
                    myhr[i].PersonalID = Convert.ToInt32(dt.Rows[i][1]);
                    myhr[i].Description = dt.Rows[i][2].ToString();
                    myhr[i].From_Date = Convert.ToDateTime(dt.Rows[i][3]);
                    myhr[i].To_Date = Convert.ToDateTime(dt.Rows[i][4]);
                    myhr[i].Type = dt.Rows[i][5].ToString();
                    myhr[i].UserName = dt.Rows[i][6].ToString();

                }
            }
            return myhr;
        }
        public void InsertNewHrRow(Hr Item, bool Update = false)
        {
            string cmdStr;
            if (!Update) // if update false then new row, if true the update row
            {
                //new row insetion
                cmdStr = "INSERT INTO hr (personalID ,description, fromdate,todate,type) VALUES (@personalID ,@description, @fromdate,@todate,@type)";
            }
            else
            {
                //update by personal number
                cmdStr = "UPDATE hr SET description = @description, fromdate = @fromdate,todate = @todate,type = @type Where hrID = @hrid";
            }

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@hrid", Item.hrid);
                command.Parameters.AddWithValue("@personalID", Item.PersonalID);
                command.Parameters.AddWithValue("@description", Item.Description);
                command.Parameters.AddWithValue("@fromdate", Item.From_Date);
                command.Parameters.AddWithValue("@todate", Item.To_Date);
                command.Parameters.AddWithValue("@type", Item.Type);
                base.ExecuteSimpleQuery(command); // Save it!

            }
        }
        //geting the hr list by id
        public Hr GetHrRowById(int idtofind)
        {
            DataSet das = new DataSet();
            DataTable dt = new DataTable();
            string cmdStr = "SELECT * FROM `hr` WHERE `hrid` = @ID";
            Hr myhr = new Hr();
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@ID", idtofind);
                das = GetMultipleQuery(command);
            }

            try
            {
                dt = das.Tables[0];
                myhr = new Hr();
                myhr.hrid = Convert.ToInt32(dt.Rows[0][0]);
                myhr.PersonalID = Convert.ToInt32(dt.Rows[0][1]);
                myhr.Description = dt.Rows[0][2].ToString();
                myhr.From_Date = Convert.ToDateTime(dt.Rows[0][3]);
                myhr.To_Date = Convert.ToDateTime(dt.Rows[0][4]);
                myhr.Type = dt.Rows[0][5].ToString();
            }
            catch (Exception e)
            {
                ErrHandler.ErrShow(310, e.ToString());
            }
            return myhr;
        }


        // Equipment UpKeep, inserting new one or update the exists ones
        public void InsertNewEquipment_upkeep(Equipment_UpKeep Item, bool Update = false)
        {
            string cmdStr;
            if (!Update)
            {
                cmdStr = "INSERT INTO equipment_upkeep (serialnumber ,upkeeptype ,upkeeptimespan,extrainfo,expirationdate,upkeekcreator) VALUES (@serialnumber,@upkeeptype , @upkeeptimespan,@extrainfo,@expirationdate,@upkeekcreator)";
            }
            else
            {
                cmdStr = "UPDATE equipment_upkeep SET serialnumber = @serialnumber, upkeeptype = @upkeeptype,upkeeptimespan = @upkeeptimespan,extrainfo = @extrainfo,expirationdate = @expirationdate,upkeekcreator = @upkeekcreator  Where serialnumber = @serialnumber";
            }
            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {

                command.Parameters.AddWithValue("@serialnumber", Item.SerialNumber);
                command.Parameters.AddWithValue("@upkeeptype", Item.UpKeepType);
                command.Parameters.AddWithValue("@upkeeptimespan", Item.TimeSpan);
                command.Parameters.AddWithValue("@extrainfo", Item.ExtraInfo);
                command.Parameters.AddWithValue("@expirationdate", Item.ExpirationDate);
                command.Parameters.AddWithValue("@upkeekcreator", GeneralCodeHelper.curentUser.personalnumber);
                base.ExecuteSimpleQuery(command); // Save it!

            }
        }

        private string GetAllEquipment_upkeep_switch(int show)
        {
            switch (show)
            {
                case 0: return "SELECT * FROM `equipment_upkeep` WHERE serialnumber = @ItemToshow";// all
                case 1: return "SELECT * FROM `equipment_upkeep` WHERE expirationdate < @Today AND serialnumber = @ItemToshow"; //expiard
                case 2: return "SELECT * FROM `equipment_upkeep` WHERE expirationdate > @Today AND serialnumber = @ItemToshow"; // not expiard     
                default: return "SELECT * FROM `equipment_upkeep` WHERE serialnumber = @ItemToshow";// all
            }
        }
        //geting all the equipmment data with
        public DataTable GetAllEquipment_upkeep(int itemserial,int show = 0) 
        {
            //Loading tasks from database returing tasks obj array
            DataSet ds = new DataSet();
            string cmdStr= GetAllEquipment_upkeep_switch(show);// = "SELECT * FROM `equipment_upkeep` WHERE serialnumber = @ItemToshow";
            //show:
            //0=all,1=expiard,2=not expiard

            using (MySqlCommand command = new MySqlCommand(cmdStr))
            {
                command.Parameters.AddWithValue("@Today", DateTime.Today);
                command.Parameters.AddWithValue("@ItemToshow", itemserial);
                ds = GetMultipleQuery(command);
            }
            DataTable dt = new DataTable();
            try
            {
                dt = ds.Tables[0];
                //translating table heder
                dt.Columns["UkID"].ColumnName = "מספר פעולה";
                dt.Columns["serialnumber"].ColumnName = "מספר סידורי";
                dt.Columns["upkeeptype"].ColumnName = "סוג";
                dt.Columns["upkeeptimespan"].ColumnName = "פרק זמן";
                dt.Columns["extrainfo"].ColumnName = "מידע נוסף";
                dt.Columns["expirationdate"].ColumnName = "פג תוקף";
                dt.Columns["upkeepdate"].ColumnName = "תאריך הוספה";
                dt.Columns["upkeekcreator"].ColumnName = "יוצר הפעולה";
               
            }
            catch
            {

            }
            return dt;
        }

    }
}
 