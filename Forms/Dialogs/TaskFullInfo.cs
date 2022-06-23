using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectForm.Forms.Dialogs
{
    public partial class TaskFullInfo : Form
    {
        public TaskFullInfo(Tasks ShowInfo)
        {
            InitializeComponent();
            string typestr = ShowInfo.IntTypeToString(ShowInfo.TaskType.ToString()); // convert type to string for user display
            TaskID.Text = ShowInfo.TaskId.ToString();
                Title.Text = ShowInfo.MyTitle;
            DueDate.Text = ShowInfo.FinalDate.ToShortDateString();
            Details.Text = ShowInfo.TaskDetails;
            WorkerID.Text = ShowInfo.WorkingOn.ToString();
            TaskFinished.Text = ShowInfo.TaskDone.ToString();
            AssignedDate.Text = ShowInfo.AssignedDate.ToShortDateString();
            AssignedBy.Text = ShowInfo.AssignedBy.ToString();
            Type.Text = typestr;
        }

        private void Exbtn_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
