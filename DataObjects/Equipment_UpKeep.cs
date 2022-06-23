using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm.DataObjects
{
    public class Equipment_UpKeep
    {
        private int ukid;
        private int sn;
        private string ty;
        private string exinfi;
        private DateTime XP;
        private DateTime UkDate;
        private String ts;
        private int userid;

        public int UpKeekCreator
        {
            get { return userid; }
            set { userid = value; }
        }

        public String TimeSpan
        {
            get { return ts; }
            set { ts = value; }
        }


        public DateTime UpKeepDate
        {
            get { return UkDate; }
            set { UkDate = value; }
        }

        public DateTime ExpirationDate
        {
            get { return XP; }
            set { XP = value; }
        }

        public string ExtraInfo
        {
            get { return exinfi; }
            set { exinfi = value; }
        }


        public string UpKeepType
        {
            get { return ty; }
            set { ty = value; }
        }

        public int SerialNumber
        {
            get { return sn; }
            set { sn = value; }
        }

        public int UpKeepID
        {
            get { return ukid; }
            set { ukid = value; }
        }

    }
}
