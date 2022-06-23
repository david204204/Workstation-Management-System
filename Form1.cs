using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FinalProjectForm.Forms;
using FinalProjectForm.InterfaceClases;
namespace FinalProjectForm
{
    public partial class WorkManger : Form
    {
        private Button currentButten;
        //private Random random;
        //private int tempIndex;
        private Form activeForm;
        public WorkManger()
        {
            InitializeComponent();
            
        }


        // use to butify the buttons
        private void ActivateButton(object btnSender)
        {
            if(btnSender != null)
            {
                if(currentButten != (Button)btnSender)
                {
                    DisableButton();
                    currentButten = (Button)btnSender;
                    currentButten.BackColor = Color.FromArgb(51, 61, 101);
                    currentButten.ForeColor = Color.White;
                    currentButten.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular,System.Drawing.GraphicsUnit.Point,((byte)(0)));
                }
            }
            


        }
        // disable a button
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
        // opens a form within a form
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
            //childForm.Width = panelDesktopPanel.Width;
            //panelDesktopPanel.Width = childForm.Width;
            childForm.Show();
            LbTitle.Text = childForm.Text; 

        }


        private void TaskBTN_Click(object sender, EventArgs e)
        {
            switch (GeneralCodeHelper.curentUser.Level)
            {
                case 1:
                    OpenChildForm(new Forms.TasksViewer(), sender);
                    break;
                case 2: // show user level 1

                    
                    break;
                case 3:
                    OpenChildForm(new Forms.TasksForm(), sender);
                    break;
            }
            
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

        private void panelDesktopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelLogo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WorkManger_Load(object sender, EventArgs e)
        {

        }
        public void HideAllBtns(int mode=0) //function hides all buttons or shows user buttons - hides by defult
        {//switch has all the different user levels by numbers
            switch (mode)
            {
                case 0:
                    foreach (var Button in PanelMenu.Controls.OfType<Button>()) { Button.Visible = false; } // hide all
                    break;
                case 1: // show user level 1
                    TaskBTN.Visible = true;
                    EquipmentBTN.Visible = true;
                    namelbl.Text = GeneralCodeHelper.curentUser.FullName;
                    break;
                case 3:
                    foreach (var Button in PanelMenu.Controls.OfType<Button>()) { Button.Visible = true; } // show all
                    namelbl.Text = GeneralCodeHelper.curentUser.FullName;
                   
                    break;
            }
                    
        }
        //public Users curentUser = new Users();

            //loades the user login window
        public void LoginWindow()
        {
            //loads login window and make sure login window has secseed login-in
            Login Llogin = new Login(this);
            HideAllBtns(0);
            DarkenMe(false);
            Llogin.ShowDialog();
            if (Llogin.SecsessLoggdin)
            {
                HideAllBtns(GeneralCodeHelper.curentUser.Level);
                DarkenMe(true);
                ReportBTN.PerformClick();
            }
            else
            {
                this.Close();
            }
        }
        private void WorkManger_Paint(object sender, PaintEventArgs e)
        {
            //Brush brush = new SolidBrush(Color.Black);
            //e.Graphics.FillRectangle(brush, 0, 0, this.Width, this.Height);
        }
        private void DarkenMe(bool what)
        {
            // hides everything and colorf the form grey - when false
            // going th opsite when true
            Color DeadColor = Color.Gray;
            Color LiveColor = Color.White ;
            if (!what)
            {
                this.BackColor = DeadColor;
            }
            else
            {
                this.BackColor = LiveColor;
            }
            
            tableLayoutPanel1.Visible = what;
            panelDesktopPanel.Visible = what;
            TitlePanel.Visible = what;
            PanelLogo.Visible = what;
            PanelMenu.Visible = what;
        }

        private void WorkManger_Shown(object sender, EventArgs e)
        {
            LoginWindow();
        }

        private void PanelMenu_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PanelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }


    }

    
}
