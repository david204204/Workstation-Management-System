using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm.DataObjects
{
    public class Hr
    {
        private int id;
        private int perid;
        private string des;
        private DateTime From;
        private DateTime To;
        private string typ;
        private string Usn;

        public string UserName
        {
            get { return Usn; }
            set { Usn = value; }
        }

        public string Type
        {
            get { return typ; }
            set { typ = value; }
        }

        public DateTime To_Date
        {
            get { return To; }
            set { To = value; }
        }

        public DateTime From_Date
        {
            get { return From; }
            set { From = value; }
        }

        public string Description
        {
            get { return des; }
            set { des = value; }
        }

        public int PersonalID
        {
            get { return perid; }
            set { perid = value; }
        }

        public int hrid
        {
            get { return id; }
            set { id = value; }
        }

    }
}
