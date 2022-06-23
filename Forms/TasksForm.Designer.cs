namespace FinalProjectForm.Forms
{
    partial class TasksForm
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
            this.components = new System.ComponentModel.Container();
            this.Savebtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_TaskID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Personal = new System.Windows.Forms.ComboBox();
            this.TaskFreeText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.duetimes = new System.Windows.Forms.DateTimePicker();
            this.TaskType = new System.Windows.Forms.ComboBox();
            this.typelbl = new System.Windows.Forms.Label();
            this.ShowDone = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tasksList1 = new FinalProjectForm.MyControls.TasksList();
            this.ExportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExelExport = new System.Windows.Forms.ToolStripMenuItem();
            this.iaFbluespacer2 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Serchbtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.WhatYouNeed = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.SEcomboBox = new System.Windows.Forms.ComboBox();
            this.LIKE = new System.Windows.Forms.CheckBox();
            this.iaF_LabelSepertor1 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.ExportMenu.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Savebtn
            // 
            this.Savebtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Savebtn.Location = new System.Drawing.Point(246, 106);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(98, 35);
            this.Savebtn.TabIndex = 2;
            this.Savebtn.Text = "הקצה";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(835, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "מטלה חדשה:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "מספר מטלה:";
            // 
            // Tb_TaskID
            // 
            this.Tb_TaskID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_TaskID.Enabled = false;
            this.Tb_TaskID.Location = new System.Drawing.Point(407, 7);
            this.Tb_TaskID.Name = "Tb_TaskID";
            this.Tb_TaskID.Size = new System.Drawing.Size(98, 20);
            this.Tb_TaskID.TabIndex = 4;
            this.Tb_TaskID.Text = "404";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 214F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 108F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 161F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Tb_TaskID, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.Personal, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.TaskFreeText, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TaskName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.duetimes, 3, 1);
            this.tableLayoutPanel2.Controls.Add(this.Savebtn, 4, 2);
            this.tableLayoutPanel2.Controls.Add(this.TaskType, 3, 2);
            this.tableLayoutPanel2.Controls.Add(this.typelbl, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 28);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(930, 178);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(870, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "שם מטלה:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(862, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "חייל מבצע:";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(862, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "תוכן מטלה:";
            // 
            // Personal
            // 
            this.Personal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Personal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Personal.FormattingEnabled = true;
            this.Personal.Location = new System.Drawing.Point(619, 42);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(208, 21);
            this.Personal.TabIndex = 4;
            this.Personal.Click += new System.EventHandler(this.Personal_Click);
            // 
            // TaskFreeText
            // 
            this.TaskFreeText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaskFreeText.Location = new System.Drawing.Point(619, 84);
            this.TaskFreeText.Multiline = true;
            this.TaskFreeText.Name = "TaskFreeText";
            this.TaskFreeText.Size = new System.Drawing.Size(208, 79);
            this.TaskFreeText.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(548, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "תאריך יעד:";
            // 
            // TaskName
            // 
            this.TaskName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaskName.Location = new System.Drawing.Point(619, 7);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(208, 20);
            this.TaskName.TabIndex = 9;
            // 
            // duetimes
            // 
            this.duetimes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.duetimes.CustomFormat = "ddd dd MMM yyyy";
            this.duetimes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duetimes.Location = new System.Drawing.Point(407, 42);
            this.duetimes.Name = "duetimes";
            this.duetimes.Size = new System.Drawing.Size(98, 20);
            this.duetimes.TabIndex = 3;
            // 
            // TaskType
            // 
            this.TaskType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaskType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TaskType.FormattingEnabled = true;
            this.TaskType.Items.AddRange(new object[] {
            "אחזקה",
            "איכות",
            "בטיחות"});
            this.TaskType.Location = new System.Drawing.Point(407, 113);
            this.TaskType.Name = "TaskType";
            this.TaskType.Size = new System.Drawing.Size(98, 21);
            this.TaskType.TabIndex = 12;
            // 
            // typelbl
            // 
            this.typelbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.typelbl.AutoSize = true;
            this.typelbl.Location = new System.Drawing.Point(554, 117);
            this.typelbl.Name = "typelbl";
            this.typelbl.Size = new System.Drawing.Size(59, 13);
            this.typelbl.TabIndex = 13;
            this.typelbl.Text = "סוג מטלה:";
            // 
            // ShowDone
            // 
            this.ShowDone.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ShowDone.AutoSize = true;
            this.ShowDone.Location = new System.Drawing.Point(181, 32);
            this.ShowDone.Name = "ShowDone";
            this.ShowDone.Size = new System.Drawing.Size(101, 17);
            this.ShowDone.TabIndex = 11;
            this.ShowDone.Text = "הצג שהסתיימו";
            this.ShowDone.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.tasksList1, 0, 5);
            this.tableLayoutPanel3.Controls.Add(this.iaFbluespacer2, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.iaF_LabelSepertor1, 0, 2);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 6;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 184F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 66F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(936, 542);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // tasksList1
            // 
            this.tasksList1.BackColor = System.Drawing.Color.Transparent;
            this.tasksList1.ContextMenuStrip = this.ExportMenu;
            this.tasksList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksList1.Location = new System.Drawing.Point(2, 347);
            this.tasksList1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tasksList1.Name = "tasksList1";
            this.tasksList1.OpeningSpeed = 1;
            this.tasksList1.ShowEditBtn = 1;
            this.tasksList1.Size = new System.Drawing.Size(932, 193);
            this.tasksList1.TabIndex = 8;
            this.tasksList1.InfoButtonPresedps += new FinalProjectForm.MyControls.TasksList.InfoButPressedEvent(this.TasksList1_InfoButtonPresedps);
            this.tasksList1.EditButtonPresedps += new FinalProjectForm.MyControls.TasksList.EditButPressedEvent(this.TasksList1_EditButtonPresedps);
            // 
            // ExportMenu
            // 
            this.ExportMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ExportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ExelExport});
            this.ExportMenu.Name = "ExportMenu";
            this.ExportMenu.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ExportMenu.Size = new System.Drawing.Size(140, 26);
            // 
            // ExelExport
            // 
            this.ExelExport.Name = "ExelExport";
            this.ExelExport.Size = new System.Drawing.Size(139, 22);
            this.ExelExport.Text = "ייצוא לאקסל";
            this.ExelExport.Click += new System.EventHandler(this.ExelExport_Click);
            // 
            // iaFbluespacer2
            // 
            this.iaFbluespacer2.BackColor = System.Drawing.Color.Transparent;
            this.iaFbluespacer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaFbluespacer2.LineLocation = true;
            this.iaFbluespacer2.LineThickness = 1;
            this.iaFbluespacer2.Location = new System.Drawing.Point(4, 314);
            this.iaFbluespacer2.MainText = "מטלות:";
            this.iaFbluespacer2.Margin = new System.Windows.Forms.Padding(4);
            this.iaFbluespacer2.Name = "iaFbluespacer2";
            this.iaFbluespacer2.PointDiamiter = 10;
            this.iaFbluespacer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaFbluespacer2.Size = new System.Drawing.Size(928, 27);
            this.iaFbluespacer2.TabIndex = 7;
            this.iaFbluespacer2.TextSize = 12;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.32961F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.67039F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel1.Controls.Add(this.Serchbtn, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 247);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(930, 60);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // Serchbtn
            // 
            this.Serchbtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Serchbtn.Location = new System.Drawing.Point(6, 12);
            this.Serchbtn.Name = "Serchbtn";
            this.Serchbtn.Size = new System.Drawing.Size(106, 36);
            this.Serchbtn.TabIndex = 12;
            this.Serchbtn.Text = "חיפוש";
            this.Serchbtn.UseVisualStyleBackColor = true;
            this.Serchbtn.Click += new System.EventHandler(this.Serchbtn_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.WhatYouNeed, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(695, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(232, 54);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // WhatYouNeed
            // 
            this.WhatYouNeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WhatYouNeed.Location = new System.Drawing.Point(3, 30);
            this.WhatYouNeed.Name = "WhatYouNeed";
            this.WhatYouNeed.Size = new System.Drawing.Size(226, 20);
            this.WhatYouNeed.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(148, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "טקסט לחיפוש:";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.SEcomboBox, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.LIKE, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ShowDone, 1, 1);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(120, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(569, 54);
            this.tableLayoutPanel5.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(497, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "שדה חיפוש:";
            // 
            // SEcomboBox
            // 
            this.SEcomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SEcomboBox.Items.AddRange(new object[] {
            "תיאור",
            "מספר מטלה",
            "תאריך יעד",
            "חייל מבצע",
            "סוג",
            "מזין המטלה"});
            this.SEcomboBox.Location = new System.Drawing.Point(321, 30);
            this.SEcomboBox.Name = "SEcomboBox";
            this.SEcomboBox.Size = new System.Drawing.Size(245, 21);
            this.SEcomboBox.TabIndex = 12;
            // 
            // LIKE
            // 
            this.LIKE.AutoSize = true;
            this.LIKE.Checked = true;
            this.LIKE.CheckState = System.Windows.Forms.CheckState.Checked;
            this.LIKE.Location = new System.Drawing.Point(193, 3);
            this.LIKE.Name = "LIKE";
            this.LIKE.Size = new System.Drawing.Size(89, 17);
            this.LIKE.TabIndex = 6;
            this.LIKE.Text = "ביטוי מדויק";
            this.LIKE.UseVisualStyleBackColor = true;
            // 
            // iaF_LabelSepertor1
            // 
            this.iaF_LabelSepertor1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaF_LabelSepertor1.LineLocation = true;
            this.iaF_LabelSepertor1.LineThickness = 1;
            this.iaF_LabelSepertor1.Location = new System.Drawing.Point(4, 213);
            this.iaF_LabelSepertor1.MainText = "חיפוש מטלות:";
            this.iaF_LabelSepertor1.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor1.Name = "iaF_LabelSepertor1";
            this.iaF_LabelSepertor1.PointDiamiter = 10;
            this.iaF_LabelSepertor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor1.Size = new System.Drawing.Size(928, 27);
            this.iaF_LabelSepertor1.TabIndex = 14;
            this.iaF_LabelSepertor1.TextSize = 12;
            // 
            // TasksForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(946, 552);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasksForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מטלות";
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ExportMenu.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_TaskID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker duetimes;
        private System.Windows.Forms.ComboBox Personal;
        private System.Windows.Forms.TextBox TaskFreeText;
        private MyControls.IAF_LabelSepertor iaFbluespacer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MyControls.TasksList tasksList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.CheckBox ShowDone;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button Serchbtn;
        private System.Windows.Forms.TextBox WhatYouNeed;
        private System.Windows.Forms.ComboBox TaskType;
        private System.Windows.Forms.Label typelbl;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.CheckBox LIKE;
        private System.Windows.Forms.ComboBox SEcomboBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip ExportMenu;
        private System.Windows.Forms.ToolStripMenuItem ExelExport;
    }
}