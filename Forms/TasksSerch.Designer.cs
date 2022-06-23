namespace FinalProjectForm.Forms
{
    partial class TasksSerch
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_TaskID = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.ArcTasks = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Personal = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TaskName = new System.Windows.Forms.TextBox();
            this.duetimes = new System.Windows.Forms.DateTimePicker();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iaFbluespacer2 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.tasksList1 = new FinalProjectForm.MyControls.TasksList();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "חיפוש מטלות:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "מספר מטלה:";
            // 
            // Tb_TaskID
            // 
            this.Tb_TaskID.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tb_TaskID.Enabled = false;
            this.Tb_TaskID.Location = new System.Drawing.Point(242, 35);
            this.Tb_TaskID.Name = "Tb_TaskID";
            this.Tb_TaskID.Size = new System.Drawing.Size(98, 22);
            this.Tb_TaskID.TabIndex = 4;
            this.Tb_TaskID.Text = "404";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.42321F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.57679F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 115F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 227F));
            this.tableLayoutPanel2.Controls.Add(this.button1, 4, 1);
            this.tableLayoutPanel2.Controls.Add(this.ArcTasks, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.Tb_TaskID, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.Personal, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label7, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.TaskName, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.duetimes, 3, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 32);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(837, 184);
            this.tableLayoutPanel2.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(65, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 35);
            this.button1.TabIndex = 13;
            this.button1.Text = "חיפוש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // ArcTasks
            // 
            this.ArcTasks.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ArcTasks.AutoSize = true;
            this.ArcTasks.Location = new System.Drawing.Point(49, 35);
            this.ArcTasks.Name = "ArcTasks";
            this.ArcTasks.Size = new System.Drawing.Size(131, 21);
            this.ArcTasks.TabIndex = 12;
            this.ArcTasks.Tag = "";
            this.ArcTasks.Text = "הצג מטלות מאכיון";
            this.ArcTasks.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(770, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "שם מטלה:";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(763, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "חייל מבצע:";
            // 
            // Personal
            // 
            this.Personal.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Personal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.Personal.FormattingEnabled = true;
            this.Personal.Location = new System.Drawing.Point(519, 125);
            this.Personal.Name = "Personal";
            this.Personal.Size = new System.Drawing.Size(187, 24);
            this.Personal.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "תאריך יעד:";
            // 
            // TaskName
            // 
            this.TaskName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TaskName.Location = new System.Drawing.Point(519, 35);
            this.TaskName.Name = "TaskName";
            this.TaskName.Size = new System.Drawing.Size(187, 22);
            this.TaskName.TabIndex = 9;
            // 
            // duetimes
            // 
            this.duetimes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.duetimes.CustomFormat = "ddd dd MMM yyyy";
            this.duetimes.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.duetimes.Location = new System.Drawing.Point(242, 127);
            this.duetimes.Name = "duetimes";
            this.duetimes.Size = new System.Drawing.Size(98, 22);
            this.duetimes.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.iaFbluespacer2, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.tasksList1, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.18681F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.81319F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 224F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(843, 478);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // iaFbluespacer2
            // 
            this.iaFbluespacer2.BackColor = System.Drawing.Color.Transparent;
            this.iaFbluespacer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaFbluespacer2.LineLocation = true;
            this.iaFbluespacer2.LineThickness = 1;
            this.iaFbluespacer2.Location = new System.Drawing.Point(4, 223);
            this.iaFbluespacer2.MainText = "מטלות שנמצאו:";
            this.iaFbluespacer2.Margin = new System.Windows.Forms.Padding(4);
            this.iaFbluespacer2.Name = "iaFbluespacer2";
            this.iaFbluespacer2.PointDiamiter = 10;
            this.iaFbluespacer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaFbluespacer2.Size = new System.Drawing.Size(835, 26);
            this.iaFbluespacer2.TabIndex = 7;
            this.iaFbluespacer2.TextSize = 12;
            // 
            // tasksList1
            // 
            this.tasksList1.BackColor = System.Drawing.Color.Transparent;
            this.tasksList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksList1.Location = new System.Drawing.Point(2, 255);
            this.tasksList1.Margin = new System.Windows.Forms.Padding(2);
            this.tasksList1.Name = "tasksList1";
            this.tasksList1.OpeningSpeed = 1;
            this.tasksList1.Size = new System.Drawing.Size(839, 221);
            this.tasksList1.TabIndex = 8;
            // 
            // TasksSerch
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(853, 488);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasksSerch";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מטלות";
            this.Load += new System.EventHandler(this.TasksForm_Load);
            this.Shown += new System.EventHandler(this.TasksForm_Shown);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_TaskID;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker duetimes;
        private System.Windows.Forms.ComboBox Personal;
        private MyControls.IAF_LabelSepertor iaFbluespacer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MyControls.TasksList tasksList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TaskName;
        private System.Windows.Forms.CheckBox ArcTasks;
        private System.Windows.Forms.Button button1;
    }
}