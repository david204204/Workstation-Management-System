using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    //this is worker class with geters and seters
    public class Worker
    {


        private string worker_name;

        public string Worker_name
        {
            get { return worker_name; }
            set { worker_name = value; }
        }

        private int worker_rank;

        public int Worker_rank
        {
            get { return worker_rank; }
            set { worker_rank = value; }
        }

        private string worker_role;

        public string Worker_role
        {
            get { return worker_role; }
            set { worker_role = value; }
        }

        private string worker_class;

        public string Worker_class
        {
            get { return worker_class; }
            set { worker_class = value; }
        }

        private int workerid;

        public int Worker_id
        {
            get { return workerid; }
            set { workerid = value; }
        }


    }
}
