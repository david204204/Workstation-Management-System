using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    public class Users
    {
        private int PerNum;
        private int pass;
        private int lv;
        public Users()
        {
            PerNum = 0;
            pass = 0;
            lv = 0;
        }
        public Users(int userpnumber, string funame, int userpass, int userlevel)
        {
            PerNum = userpnumber;
            fname = funame;
            pass = userpass;
            lv = userlevel; // cannot be more then 3
        }
        public int Level // this will dictate the type of operations this user can do
        {
            //lv=1 normal clerance
            //lv=2 floor maneger clerance
            //lv=3 top level clerance "GOD"
            get { return lv; }
            set { lv = value; }
        }
        private string fname;

        public string FullName
        {
            get { return fname; }
            set { fname = value; }
        }

        public int Password
        {
            get { return pass; }
            set { pass = value; }
        }

        public int personalnumber
        {
            get { return PerNum; }
            set { PerNum = value; }
        }

    }
}
