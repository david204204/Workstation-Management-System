using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm.DataObjects
{
    public class Equipment
    {
        private string descr;
        private int senum;
        private int iafnum;
        private DateTime Ex;
        private String dep;
        public Equipment()
        {

        }
        public Equipment(String description,int serialnumber,int iafnumber,DateTime expirationdate,String department)
        {
            Description = description;
            SerialNumber = serialnumber;
            IAFnumber = iafnumber;
            ExpirationDate = expirationdate;
            Department = department;
        }

        public String Department
        {
            get { return dep; }
            set { dep = value; }
        }

        public DateTime ExpirationDate
        {
            get { return Ex; }
            set { Ex = value; }
        }

        public int IAFnumber
        {
            get { return iafnum; }
            set { iafnum = value; }
        }

        public int SerialNumber
        {
            get { return senum; }
            set { senum = value; }
        }

        public string Description
        {
            get { return descr; }
            set { descr = value; }
        }

    }
}
