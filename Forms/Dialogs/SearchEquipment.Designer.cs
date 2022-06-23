namespace FinalProjectForm.Forms.Dialogs
{
    partial class SearchEquipment
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
            this.departmentC = new System.Windows.Forms.CheckBox();
            this.descriptionC = new System.Windows.Forms.CheckBox();
            this.expirationdateC = new System.Windows.Forms.CheckBox();
            this.iafnumberC = new System.Windows.Forms.CheckBox();
            this.serialnumber = new System.Windows.Forms.TextBox();
            this.TaskID1 = new System.Windows.Forms.Label();
            this.WorkerID2 = new System.Windows.Forms.Label();
            this.department = new System.Windows.Forms.TextBox();
            this.DueDate2 = new System.Windows.Forms.Label();
            this.expirationdate = new System.Windows.Forms.DateTimePicker();
            this.Title2 = new System.Windows.Forms.Label();
            this.iafnumber = new System.Windows.Forms.TextBox();
            this.Details2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.serialnumberC = new System.Windows.Forms.CheckBox();
            this.Exbtn = new System.Windows.Forms.Button();
            this.descriptionCEX = new System.Windows.Forms.CheckBox();
            this.departmentCEX = new System.Windows.Forms.CheckBox();
            this.DateFilter = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 295F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 131F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.Controls.Add(this.departmentC, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.descriptionC, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.expirationdateC, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.iafnumberC, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.serialnumber, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.TaskID1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.WorkerID2, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.department, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DueDate2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.expirationdate, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Title2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.iafnumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Details2, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.description, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.serialnumberC, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Exbtn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.descriptionCEX, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.departmentCEX, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.DateFilter, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090247F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.18049F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091156F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.091156F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(608, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // departmentC
            // 
            this.departmentC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.departmentC.AutoSize = true;
            this.departmentC.Location = new System.Drawing.Point(583, 372);
            this.departmentC.Name = "departmentC";
            this.departmentC.Size = new System.Drawing.Size(18, 17);
            this.departmentC.TabIndex = 26;
            this.departmentC.UseVisualStyleBackColor = true;
            this.departmentC.CheckedChanged += new System.EventHandler(this.DepartmentC_CheckedChanged);
            // 
            // descriptionC
            // 
            this.descriptionC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionC.AutoSize = true;
            this.descriptionC.Location = new System.Drawing.Point(583, 268);
            this.descriptionC.Name = "descriptionC";
            this.descriptionC.Size = new System.Drawing.Size(18, 17);
            this.descriptionC.TabIndex = 25;
            this.descriptionC.UseVisualStyleBackColor = true;
            this.descriptionC.CheckedChanged += new System.EventHandler(this.DescriptionC_CheckedChanged);
            // 
            // expirationdateC
            // 
            this.expirationdateC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.expirationdateC.AutoSize = true;
            this.expirationdateC.Location = new System.Drawing.Point(583, 164);
            this.expirationdateC.Name = "expirationdateC";
            this.expirationdateC.Size = new System.Drawing.Size(18, 17);
            this.expirationdateC.TabIndex = 24;
            this.expirationdateC.UseVisualStyleBackColor = true;
            this.expirationdateC.CheckedChanged += new System.EventHandler(this.ExpirationdateC_CheckedChanged);
            // 
            // iafnumberC
            // 
            this.iafnumberC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iafnumberC.AutoSize = true;
            this.iafnumberC.Location = new System.Drawing.Point(583, 95);
            this.iafnumberC.Name = "iafnumberC";
            this.iafnumberC.Size = new System.Drawing.Size(18, 17);
            this.iafnumberC.TabIndex = 23;
            this.iafnumberC.UseVisualStyleBackColor = true;
            this.iafnumberC.CheckedChanged += new System.EventHandler(this.IafnumberC_CheckedChanged);
            // 
            // serialnumber
            // 
            this.serialnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.serialnumber.Enabled = false;
            this.serialnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialnumber.ForeColor = System.Drawing.Color.Black;
            this.serialnumber.Location = new System.Drawing.Point(178, 22);
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.serialnumber.Size = new System.Drawing.Size(265, 24);
            this.serialnumber.TabIndex = 3;
            // 
            // TaskID1
            // 
            this.TaskID1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TaskID1.AutoSize = true;
            this.TaskID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskID1.ForeColor = System.Drawing.Color.White;
            this.TaskID1.Location = new System.Drawing.Point(463, 24);
            this.TaskID1.Name = "TaskID1";
            this.TaskID1.Size = new System.Drawing.Size(111, 20);
            this.TaskID1.TabIndex = 5;
            this.TaskID1.Text = ":מספר סידורי";
            // 
            // WorkerID2
            // 
            this.WorkerID2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WorkerID2.AutoSize = true;
            this.WorkerID2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WorkerID2.ForeColor = System.Drawing.Color.White;
            this.WorkerID2.Location = new System.Drawing.Point(507, 370);
            this.WorkerID2.Name = "WorkerID2";
            this.WorkerID2.Size = new System.Drawing.Size(67, 20);
            this.WorkerID2.TabIndex = 11;
            this.WorkerID2.Text = ":מחלקה";
            // 
            // department
            // 
            this.department.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.department.Enabled = false;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department.ForeColor = System.Drawing.Color.Black;
            this.department.Location = new System.Drawing.Point(178, 368);
            this.department.Name = "department";
            this.department.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.department.Size = new System.Drawing.Size(265, 24);
            this.department.TabIndex = 12;
            // 
            // DueDate2
            // 
            this.DueDate2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DueDate2.AutoSize = true;
            this.DueDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate2.ForeColor = System.Drawing.Color.White;
            this.DueDate2.Location = new System.Drawing.Point(521, 162);
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
            this.expirationdate.Enabled = false;
            this.expirationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationdate.ForeColor = System.Drawing.Color.White;
            this.expirationdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expirationdate.Location = new System.Drawing.Point(178, 160);
            this.expirationdate.Name = "expirationdate";
            this.expirationdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.expirationdate.RightToLeftLayout = true;
            this.expirationdate.Size = new System.Drawing.Size(265, 24);
            this.expirationdate.TabIndex = 7;
            // 
            // Title2
            // 
            this.Title2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.ForeColor = System.Drawing.Color.White;
            this.Title2.Location = new System.Drawing.Point(480, 83);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(94, 40);
            this.Title2.TabIndex = 6;
            this.Title2.Text = ":מספר חיל אוויר";
            // 
            // iafnumber
            // 
            this.iafnumber.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iafnumber.Enabled = false;
            this.iafnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iafnumber.ForeColor = System.Drawing.Color.Black;
            this.iafnumber.Location = new System.Drawing.Point(178, 91);
            this.iafnumber.Name = "iafnumber";
            this.iafnumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iafnumber.Size = new System.Drawing.Size(265, 24);
            this.iafnumber.TabIndex = 4;
            // 
            // Details2
            // 
            this.Details2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Details2.AutoSize = true;
            this.Details2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details2.ForeColor = System.Drawing.Color.White;
            this.Details2.Location = new System.Drawing.Point(514, 266);
            this.Details2.Name = "Details2";
            this.Details2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Details2.Size = new System.Drawing.Size(60, 20);
            this.Details2.TabIndex = 10;
            this.Details2.Text = "תיאור:";
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.description.Enabled = false;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.Black;
            this.description.Location = new System.Drawing.Point(178, 240);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.description.Size = new System.Drawing.Size(265, 73);
            this.description.TabIndex = 9;
            // 
            // serialnumberC
            // 
            this.serialnumberC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.serialnumberC.AutoSize = true;
            this.serialnumberC.Location = new System.Drawing.Point(583, 26);
            this.serialnumberC.Name = "serialnumberC";
            this.serialnumberC.Size = new System.Drawing.Size(18, 17);
            this.serialnumberC.TabIndex = 22;
            this.serialnumberC.UseVisualStyleBackColor = true;
            this.serialnumberC.CheckedChanged += new System.EventHandler(this.SerialnumberC_CheckedChanged);
            // 
            // Exbtn
            // 
            this.Exbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exbtn.Location = new System.Drawing.Point(171, 430);
            this.Exbtn.Name = "Exbtn";
            this.Exbtn.Size = new System.Drawing.Size(255, 43);
            this.Exbtn.TabIndex = 21;
            this.Exbtn.Text = "חפש";
            this.Exbtn.UseVisualStyleBackColor = true;
            this.Exbtn.Click += new System.EventHandler(this.Exbtn_Click);
            // 
            // descriptionCEX
            // 
            this.descriptionCEX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.descriptionCEX.AutoSize = true;
            this.descriptionCEX.Checked = true;
            this.descriptionCEX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.descriptionCEX.ForeColor = System.Drawing.SystemColors.Control;
            this.descriptionCEX.Location = new System.Drawing.Point(51, 266);
            this.descriptionCEX.Name = "descriptionCEX";
            this.descriptionCEX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.descriptionCEX.Size = new System.Drawing.Size(97, 21);
            this.descriptionCEX.TabIndex = 28;
            this.descriptionCEX.Text = "ביטוי מדוייק";
            this.descriptionCEX.UseVisualStyleBackColor = true;
            // 
            // departmentCEX
            // 
            this.departmentCEX.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.departmentCEX.AutoSize = true;
            this.departmentCEX.Checked = true;
            this.departmentCEX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.departmentCEX.ForeColor = System.Drawing.SystemColors.Control;
            this.departmentCEX.Location = new System.Drawing.Point(51, 370);
            this.departmentCEX.Name = "departmentCEX";
            this.departmentCEX.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.departmentCEX.Size = new System.Drawing.Size(97, 21);
            this.departmentCEX.TabIndex = 29;
            this.departmentCEX.Text = "ביטוי מדוייק";
            this.departmentCEX.UseVisualStyleBackColor = true;
            // 
            // DateFilter
            // 
            this.DateFilter.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DateFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DateFilter.FormattingEnabled = true;
            this.DateFilter.Items.AddRange(new object[] {
            "מתאריך",
            "עד תאריך"});
            this.DateFilter.Location = new System.Drawing.Point(27, 160);
            this.DateFilter.Name = "DateFilter";
            this.DateFilter.Size = new System.Drawing.Size(121, 24);
            this.DateFilter.TabIndex = 30;
            // 
            // SearchEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(608, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SearchEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox department;
        private System.Windows.Forms.Label WorkerID2;
        private System.Windows.Forms.Label Details2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label DueDate2;
        private System.Windows.Forms.DateTimePicker expirationdate;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.TextBox iafnumber;
        private System.Windows.Forms.TextBox serialnumber;
        private System.Windows.Forms.Label TaskID1;
        private System.Windows.Forms.Button Exbtn;
        private System.Windows.Forms.CheckBox serialnumberC;
        private System.Windows.Forms.CheckBox departmentC;
        private System.Windows.Forms.CheckBox descriptionC;
        private System.Windows.Forms.CheckBox expirationdateC;
        private System.Windows.Forms.CheckBox iafnumberC;
        private System.Windows.Forms.CheckBox descriptionCEX;
        private System.Windows.Forms.CheckBox departmentCEX;
        private System.Windows.Forms.ComboBox DateFilter;
    }
}