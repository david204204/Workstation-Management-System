namespace FinalProjectForm.Forms.Dialogs
{
    partial class NewEditEquipment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TaskID1 = new System.Windows.Forms.Label();
            this.serialnumber = new System.Windows.Forms.NumericUpDown();
            this.Title2 = new System.Windows.Forms.Label();
            this.iafnumber = new System.Windows.Forms.NumericUpDown();
            this.DueDate2 = new System.Windows.Forms.Label();
            this.expirationdate = new System.Windows.Forms.DateTimePicker();
            this.Details2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.WorkerID2 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.Exbtn = new System.Windows.Forms.Button();
            this.ScanIAFB = new FinalProjectForm.IAF_BarCodeBtn();
            this.iaF_BarCodeBtn1 = new FinalProjectForm.IAF_BarCodeBtn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialnumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iafnumber)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.TaskID1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.serialnumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Title2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.iafnumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DueDate2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.expirationdate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Details2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.description, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.WorkerID2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.department, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.Exbtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.ScanIAFB, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iaF_BarCodeBtn1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.2849F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.56979F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28633F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(544, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TaskID1
            // 
            this.TaskID1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TaskID1.AutoSize = true;
            this.TaskID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskID1.ForeColor = System.Drawing.Color.White;
            this.TaskID1.Location = new System.Drawing.Point(410, 24);
            this.TaskID1.Name = "TaskID1";
            this.TaskID1.Size = new System.Drawing.Size(111, 20);
            this.TaskID1.TabIndex = 5;
            this.TaskID1.Text = ":מספר סידורי";
            // 
            // serialnumber
            // 
            this.serialnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.serialnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialnumber.ForeColor = System.Drawing.Color.Black;
            this.serialnumber.Location = new System.Drawing.Point(106, 22);
            this.serialnumber.Maximum = new decimal(new int[] {
            276447231,
            23283,
            0,
            0});
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialnumber.Size = new System.Drawing.Size(265, 24);
            this.serialnumber.TabIndex = 3;
            // 
            // Title2
            // 
            this.Title2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.ForeColor = System.Drawing.Color.White;
            this.Title2.Location = new System.Drawing.Point(386, 93);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(135, 20);
            this.Title2.TabIndex = 6;
            this.Title2.Text = ":מספר חיל אוויר";
            // 
            // iafnumber
            // 
            this.iafnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iafnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iafnumber.ForeColor = System.Drawing.Color.Black;
            this.iafnumber.Location = new System.Drawing.Point(106, 91);
            this.iafnumber.Maximum = new decimal(new int[] {
            1874919423,
            2328306,
            0,
            0});
            this.iafnumber.Name = "iafnumber";
            this.iafnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iafnumber.Size = new System.Drawing.Size(265, 24);
            this.iafnumber.TabIndex = 4;
            // 
            // DueDate2
            // 
            this.DueDate2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DueDate2.AutoSize = true;
            this.DueDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate2.ForeColor = System.Drawing.Color.White;
            this.DueDate2.Location = new System.Drawing.Point(468, 162);
            this.DueDate2.Name = "DueDate2";
            this.DueDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DueDate2.Size = new System.Drawing.Size(53, 20);
            this.DueDate2.TabIndex = 8;
            this.DueDate2.Text = "תוקף:";
            // 
            // expirationdate
            // 
            this.expirationdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.expirationdate.CustomFormat = "ddd dd MMM yyyy";
            this.expirationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationdate.ForeColor = System.Drawing.Color.White;
            this.expirationdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirationdate.Location = new System.Drawing.Point(106, 160);
            this.expirationdate.Name = "expirationdate";
            this.expirationdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expirationdate.RightToLeftLayout = true;
            this.expirationdate.Size = new System.Drawing.Size(265, 24);
            this.expirationdate.TabIndex = 7;
            // 
            // Details2
            // 
            this.Details2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Details2.AutoSize = true;
            this.Details2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details2.ForeColor = System.Drawing.Color.White;
            this.Details2.Location = new System.Drawing.Point(461, 266);
            this.Details2.Name = "Details2";
            this.Details2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Details2.Size = new System.Drawing.Size(60, 20);
            this.Details2.TabIndex = 10;
            this.Details2.Text = "תיאור:";
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(106, 240);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.description.Size = new System.Drawing.Size(265, 73);
            this.description.TabIndex = 9;
            // 
            // WorkerID2
            // 
            this.WorkerID2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WorkerID2.AutoSize = true;
            this.WorkerID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerID2.ForeColor = System.Drawing.Color.White;
            this.WorkerID2.Location = new System.Drawing.Point(454, 370);
            this.WorkerID2.Name = "WorkerID2";
            this.WorkerID2.Size = new System.Drawing.Size(67, 20);
            this.WorkerID2.TabIndex = 11;
            this.WorkerID2.Text = ":מחלקה";
            // 
            // department
            // 
            this.department.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.ForeColor = System.Drawing.Color.Black;
            this.department.Location = new System.Drawing.Point(106, 368);
            this.department.Name = "department";
            this.department.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.department.Size = new System.Drawing.Size(265, 24);
            this.department.TabIndex = 12;
            // 
            // Exbtn
            // 
            this.Exbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Exbtn.Location = new System.Drawing.Point(116, 430);
            this.Exbtn.Name = "Exbtn";
            this.Exbtn.Size = new System.Drawing.Size(255, 43);
            this.Exbtn.TabIndex = 21;
            this.Exbtn.Text = "שמור";
            this.Exbtn.UseVisualStyleBackColor = true;
            this.Exbtn.Click += new System.EventHandler(this.Exbtn_Click);
            // 
            // ScanIAFB
            // 
            this.ScanIAFB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ScanIAFB.BackColor = System.Drawing.Color.Transparent;
            this.ScanIAFB.Location = new System.Drawing.Point(13, 80);
            this.ScanIAFB.Margin = new System.Windows.Forms.Padding(0);
            this.ScanIAFB.Name = "ScanIAFB";
            this.ScanIAFB.Size = new System.Drawing.Size(73, 46);
            this.ScanIAFB.TabIndex = 24;
            this.ScanIAFB.OnButtonPressedEvent += new FinalProjectForm.IAF_BarCodeBtn.ButtonPressedEvent(this.ScanIAFB_OnButtonPressedEvent);
            // 
            // iaF_BarCodeBtn1
            // 
            this.iaF_BarCodeBtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iaF_BarCodeBtn1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_BarCodeBtn1.Location = new System.Drawing.Point(13, 11);
            this.iaF_BarCodeBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.iaF_BarCodeBtn1.Name = "iaF_BarCodeBtn1";
            this.iaF_BarCodeBtn1.Size = new System.Drawing.Size(73, 46);
            this.iaF_BarCodeBtn1.TabIndex = 25;
            this.iaF_BarCodeBtn1.OnButtonPressedEvent += new FinalProjectForm.IAF_BarCodeBtn.ButtonPressedEvent(this.IaF_BarCodeBtn1_OnButtonPressedEvent);
            // 
            // NewEditEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(544, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewEditEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serialnumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iafnumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.DateTimePicker expirationdate;
        private System.Windows.Forms.NumericUpDown iafnumber;
        private System.Windows.Forms.NumericUpDown serialnumber;
        private System.Windows.Forms.Button Exbtn;
        private System.Windows.Forms.Label TaskID1;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.Label DueDate2;
        private System.Windows.Forms.Label Details2;
        private System.Windows.Forms.Label WorkerID2;
        private IAF_BarCodeBtn ScanIAFB;
        private IAF_BarCodeBtn iaF_BarCodeBtn1;
    }
}