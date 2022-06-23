using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjectForm
{
    class training
    {
        private int T_ID;
        private String Name;
        private String Loc;
        public DateTime[] MeetingDates { get; set; }
        private int p_id;

        public int Participant_Id
        {
            get { return p_id; }
            set { p_id = value; }
        }

        public String Location
        {
            get { return Loc; }
            set { Loc = value; }
        }

        public String T_Name
        {
            get { return Name; }
            set { Name = value; }
        }

        public int Id
        {
            get { return T_ID; }
            set { T_ID = value; }
        }

    }
}
