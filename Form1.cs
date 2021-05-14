using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectForm
{
    public partial class WorkManger : Form
    {
        private Button currentButten;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public WorkManger()
        {
            InitializeComponent();
        }

        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                
                if(currentButten != (Button)btnSender)
                {
                    DisableButton();
                    Color color;
                    currentButten = (Button)btnSender;
                    currentButten.BackColor = Color.FromArgb(51, 61, 101);
                    currentButten.ForeColor = Color.White;
                    
                    currentButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
                }
            }
            


        }
        private void DisableButton()
        {
            foreach(Control previousBtn in PanelMenu.Controls)
            {
                if(previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51,51,76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void OpenChildForm(Form childForm,object btnSender)
        {
            if(activeForm!=null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            LbTitle.Text = childForm.Text; 

        }

        private void TaskBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.TasksForm(), sender);
        }

        private void WorkMangBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.WorkStations(), sender);
        }

        private void EquipmentBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.EquipmentForm(), sender);
        }

        private void LogisticBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.LogisticForm(), sender);
        }

        private void HRbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.HRForm(), sender);
        }

        private void ReportBTN_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.ReportsForm(), sender);
        }
    }

    
}
