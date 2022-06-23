namespace FinalProjectForm.Forms
{
    partial class TasksViewer
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
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.iaFbluespacer2 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.tasksList1 = new FinalProjectForm.MyControls.TasksList();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Controls.Add(this.iaFbluespacer2, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tasksList1, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(5, 5);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.36866F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.63134F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(843, 478);
            this.tableLayoutPanel3.TabIndex = 8;
            this.tableLayoutPanel3.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel3_Paint);
            // 
            // iaFbluespacer2
            // 
            this.iaFbluespacer2.BackColor = System.Drawing.Color.Transparent;
            this.iaFbluespacer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaFbluespacer2.LineLocation = true;
            this.iaFbluespacer2.LineThickness = 1;
            this.iaFbluespacer2.Location = new System.Drawing.Point(4, 4);
            this.iaFbluespacer2.MainText = "מטלות קיימות:";
            this.iaFbluespacer2.Margin = new System.Windows.Forms.Padding(4);
            this.iaFbluespacer2.Name = "iaFbluespacer2";
            this.iaFbluespacer2.PointDiamiter = 10;
            this.iaFbluespacer2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaFbluespacer2.Size = new System.Drawing.Size(835, 37);
            this.iaFbluespacer2.TabIndex = 7;
            this.iaFbluespacer2.TextSize = 15;
            // 
            // tasksList1
            // 
            this.tasksList1.BackColor = System.Drawing.Color.Transparent;
            this.tasksList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tasksList1.Location = new System.Drawing.Point(2, 47);
            this.tasksList1.Margin = new System.Windows.Forms.Padding(2);
            this.tasksList1.Name = "tasksList1";
            this.tasksList1.OpeningSpeed = 1;
            this.tasksList1.ShowEditBtn = 0;
            this.tasksList1.Size = new System.Drawing.Size(839, 385);
            this.tasksList1.TabIndex = 8;
            this.tasksList1.InfoButtonPresedps += new FinalProjectForm.MyControls.TasksList.InfoButPressedEvent(this.TasksList1_InfoButtonPresedps);
            // 
            // TasksViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(853, 488);
            this.Controls.Add(this.tableLayoutPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TasksViewer";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "מטלות";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private MyControls.IAF_LabelSepertor iaFbluespacer2;
        private MyControls.TasksList tasksList1;
    }
}