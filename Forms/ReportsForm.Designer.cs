namespace FinalProjectForm.Forms
{
    partial class ReportsForm
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
            this.TasksChart = new System.Windows.Forms.TableLayoutPanel();
            this.halfCircleProssesBar1 = new FinalProjectForm.MyControls.Graphs.HalfCircleProssesBar();
            this.iaF_LabelSepertor1 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.pieReadOut1 = new FinalProjectForm.MyControls.Graphs.PieReadOut();
            this.pieChart1 = new FinalProjectForm.MyControls.Graphs.PieChart();
            this.iaF_LabelSepertor2 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.tableLayoutPanel1.SuspendLayout();
            this.TasksChart.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.halfCircleProssesBar1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.iaF_LabelSepertor1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TasksChart, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iaF_LabelSepertor2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(949, 535);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // TasksChart
            // 
            this.TasksChart.ColumnCount = 2;
            this.TasksChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.25345F));
            this.TasksChart.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 72.74655F));
            this.TasksChart.Controls.Add(this.pieReadOut1, 0, 0);
            this.TasksChart.Controls.Add(this.pieChart1, 1, 0);
            this.TasksChart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TasksChart.Location = new System.Drawing.Point(3, 36);
            this.TasksChart.Name = "TasksChart";
            this.TasksChart.RowCount = 1;
            this.TasksChart.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TasksChart.Size = new System.Drawing.Size(943, 228);
            this.TasksChart.TabIndex = 1;
            // 
            // halfCircleProssesBar1
            // 
            this.halfCircleProssesBar1.BaseColor = System.Drawing.Color.DarkGray;
            this.halfCircleProssesBar1.LineThikness = 30;
            this.halfCircleProssesBar1.Location = new System.Drawing.Point(535, 303);
            this.halfCircleProssesBar1.MainText = "שמישות";
            this.halfCircleProssesBar1.Name = "halfCircleProssesBar1";
            this.halfCircleProssesBar1.ProssesValue = 50;
            this.halfCircleProssesBar1.SecondColor = System.Drawing.Color.SteelBlue;
            this.halfCircleProssesBar1.Size = new System.Drawing.Size(411, 194);
            this.halfCircleProssesBar1.TabIndex = 3;
            // 
            // iaF_LabelSepertor1
            // 
            this.iaF_LabelSepertor1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaF_LabelSepertor1.LineLocation = true;
            this.iaF_LabelSepertor1.LineThickness = 1;
            this.iaF_LabelSepertor1.Location = new System.Drawing.Point(4, 4);
            this.iaF_LabelSepertor1.MainText = "סטטוס מטלות";
            this.iaF_LabelSepertor1.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor1.Name = "iaF_LabelSepertor1";
            this.iaF_LabelSepertor1.PointDiamiter = 10;
            this.iaF_LabelSepertor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor1.Size = new System.Drawing.Size(941, 25);
            this.iaF_LabelSepertor1.TabIndex = 0;
            this.iaF_LabelSepertor1.TextSize = 10;
            // 
            // pieReadOut1
            // 
            this.pieReadOut1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pieReadOut1.Location = new System.Drawing.Point(689, 3);
            this.pieReadOut1.MyLovlyPie = this.pieChart1;
            this.pieReadOut1.Name = "pieReadOut1";
            this.pieReadOut1.Size = new System.Drawing.Size(251, 222);
            this.pieReadOut1.TabIndex = 3;
            this.pieReadOut1.Text1 = "שהסתיימו";
            this.pieReadOut1.Text2 = "פתוחות";
            this.pieReadOut1.Text3 = "כמות מטלות";
            // 
            // pieChart1
            // 
            this.pieChart1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pieChart1.BaseColor = System.Drawing.Color.MediumSpringGreen;
            this.pieChart1.Location = new System.Drawing.Point(391, 3);
            this.pieChart1.Maximum = 200F;
            this.pieChart1.Name = "pieChart1";
            this.pieChart1.Part1 = 25;
            this.pieChart1.Part2 = 50;
            this.pieChart1.SecondColor = System.Drawing.Color.DodgerBlue;
            this.pieChart1.Size = new System.Drawing.Size(292, 222);
            this.pieChart1.TabIndex = 1;
            this.pieChart1.TirdColor = System.Drawing.Color.Black;
            // 
            // iaF_LabelSepertor2
            // 
            this.iaF_LabelSepertor2.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaF_LabelSepertor2.LineLocation = true;
            this.iaF_LabelSepertor2.LineThickness = 1;
            this.iaF_LabelSepertor2.Location = new System.Drawing.Point(4, 271);
            this.iaF_LabelSepertor2.MainText = "סטטוס ציודים";
            this.iaF_LabelSepertor2.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor2.Name = "iaF_LabelSepertor2";
            this.iaF_LabelSepertor2.PointDiamiter = 10;
            this.iaF_LabelSepertor2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor2.Size = new System.Drawing.Size(941, 25);
            this.iaF_LabelSepertor2.TabIndex = 2;
            this.iaF_LabelSepertor2.TextSize = 10;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 535);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReportsForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "דוחות";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.TasksChart.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MyControls.Graphs.PieChart pieChart1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor1;
        private System.Windows.Forms.TableLayoutPanel TasksChart;
        private MyControls.Graphs.PieReadOut pieReadOut1;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor2;
        private MyControls.Graphs.HalfCircleProssesBar halfCircleProssesBar1;
    }
}