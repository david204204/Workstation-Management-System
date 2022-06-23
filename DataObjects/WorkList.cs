using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    public class WorkList
    {
        public WorkList()
        {
            

        }

        public WorkList(string engineSerial, string name, string timeto, string description,string statusofwork,string CWork)
        {
            worker_name = name;
            engine_sn = Int32.Parse(engineSerial);
            deadline_date = Convert.ToDateTime(timeto);
            maintenance_desc = description;
            status = statusofwork;
            ClassWork = CWork;
        }

        private string status;
        private string classWork;

        public string ClassWork
        {
            get { return classWork; }
            set { classWork = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        private string worker_name;

        public string Worker_name
        {
            get { return worker_name; }
            set { worker_name = value; }
        }

        private int engine_sn;

        public int Engine_sn
        {
            get { return engine_sn; }
            set { engine_sn = value; }
        }

        private DateTime deadline_date;

        public DateTime Deadline_date
        {
            get { return deadline_date; }
            set { deadline_date = value; }
        }

        private string maintenance_desc;

        public string Maintenance_desc 
        {
            get { return maintenance_desc; }
            set { maintenance_desc = value; }
        }

       

    }
}
