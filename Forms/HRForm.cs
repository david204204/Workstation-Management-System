using FinalProjectForm.Forms.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using testMySQLConnection;
using FinalProjectForm.DataObjects;
using FinalProjectForm.InterfaceClases;

namespace FinalProjectForm.Forms
{
    public partial class HRForm : Form
    {
        private DBSQL mySQL;
        public HRForm()
        {
            InitializeComponent();
            DBSQL.DatabaseName = GeneralCodeHelper.Database;
            DBSQL.UserName = "root";
            DBSQL.Password = string.Empty;
            mySQL = DBSQL.Instance;
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        string usn; // holds the user name of selected user
        private void Viewall_Click(object sender, EventArgs e)
        {
            PersonalNumSelector AllUsersDialog = new PersonalNumSelector();
            AllUsersDialog.MyText = "כל החיילים במערכת";
            AllUsersDialog.ShowDialog();
            Idtouse.Text = AllUsersDialog.UserId.ToString();
            usn = AllUsersDialog.UserName;
        }
        private void FillHrList()
        {
            Hr[] myInfo;
            myInfo = mySQL.GetAllHrDataForUser(Convert.ToInt32(Idtouse.Text), WhatView.SelectedIndex);
            hrList1.ClearList();
            try
            {
                // fill task list
                SetUserInfo(myInfo[0]);
                for (int i = 0; i < myInfo.Length; i++)
                    hrList1.AddItem(myInfo[i]);
            }
            catch (NullReferenceException)
            {
                //is empty
                SnameLbl.Text = "לא נמצאו תוצאות עבור: " + usn;
            }
        }
        private void SetUserInfo(Hr Userobj)
        {
            SnameLbl.Text= Userobj.UserName;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                FillHrList();
            }
            catch (System.FormatException) // catch any invalid input such as letters. only numbers are allowed
            {

                ErrHandler.ErrShow(700,"מספר אישי לא תקין!");
            }
            
        }

        private void Newhr_Click(object sender, EventArgs e)
        {
            // adding new New Hr row
            NewEditHr EditEDialog = new NewEditHr();
            try
            {
                EditEDialog.Personalid = Convert.ToInt32(Idtouse.Text);
                EditEDialog.ShowDialog();
                FillHrList();

            }
            catch (Exception)
            {
                ErrHandler.ErrShow(701, "יש לבדוק שדה מספר אישי!");
            }
            
        }

        private void HrList1_EditButtonPresedps(object sender, EventArgs e, SingleHrView objuse)
        {
            // Edit Hr via edit btn
            Hr ToEdit = mySQL.GetHrRowById(objuse.HRid);
            NewEditHr NewEditEDialog = new NewEditHr(ToEdit);
            NewEditEDialog.EditMode = true;
            NewEditEDialog.ShowDialog();
            FillHrList();
        }

        private void ExelExport_Click(object sender, EventArgs e)
        {
            
            GeneralCodeHelper.ExportExel_SwitchFunction(hrList1.MyItemsList);
        }
    }
}
