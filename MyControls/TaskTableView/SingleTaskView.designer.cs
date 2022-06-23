namespace FinalProjectForm
{
    partial class SingleTaskView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Stext = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OpenSmooth = new System.Windows.Forms.Timer(this.components);
            this.CloseSmooth = new System.Windows.Forms.Timer(this.components);
            this.dDate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iaFbtn11 = new FinalProjectForm.IAF_EditBtn();
            this.Taskid = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iaF_InfoBtn1 = new FinalProjectForm.IAF_InfoBtn();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(656, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Task Name";
            // 
            // Stext
            // 
            this.Stext.AutoSize = true;
            this.Stext.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Stext.ForeColor = System.Drawing.Color.White;
            this.Stext.Location = new System.Drawing.Point(313, 49);
            this.Stext.Name = "Stext";
            this.Stext.Size = new System.Drawing.Size(465, 49);
            this.Stext.TabIndex = 3;
            this.Stext.Text = "Sub Text";
            this.Stext.Click += new System.EventHandler(this.Stext_Click);
            // 
            // OpenSmooth
            // 
            this.OpenSmooth.Tick += new System.EventHandler(this.OpenSmooth_Tick);
            // 
            // CloseSmooth
            // 
            this.CloseSmooth.Tick += new System.EventHandler(this.CloseSmooth_Tick);
            // 
            // dDate
            // 
            this.dDate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dDate.AutoSize = true;
            this.dDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dDate.ForeColor = System.Drawing.Color.White;
            this.dDate.Location = new System.Drawing.Point(78, 13);
            this.dDate.Name = "dDate";
            this.dDate.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.dDate.Size = new System.Drawing.Size(89, 22);
            this.dDate.TabIndex = 5;
            this.dDate.Text = "Due Date";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.0598F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.9402F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 74F));
            this.tableLayoutPanel1.Controls.Add(this.Stext, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dDate, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Taskid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.iaFbtn11, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.iaF_InfoBtn1, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(781, 98);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.TableLayoutPanel1_Click);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.TableLayoutPanel1_Paint);
            this.tableLayoutPanel1.MouseHover += new System.EventHandler(this.TableLayoutPanel1_MouseHover);
            // 
            // iaFbtn11
            // 
            this.iaFbtn11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iaFbtn11.BackColor = System.Drawing.Color.Transparent;
            this.iaFbtn11.Location = new System.Drawing.Point(22, 57);
            this.iaFbtn11.Margin = new System.Windows.Forms.Padding(0);
            this.iaFbtn11.Name = "iaFbtn11";
            this.iaFbtn11.Size = new System.Drawing.Size(31, 33);
            this.iaFbtn11.TabIndex = 4;
            this.iaFbtn11.OnButtonPressedEvent += new FinalProjectForm.IAF_EditBtn.ButtonPressedEvent(this.IaFbtn11_OnButtonPressedEvent_1);
            this.iaFbtn11.Load += new System.EventHandler(this.IaFbtn11_Load);
          
            // 
            // Taskid
            // 
            this.Taskid.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Taskid.AutoSize = true;
            this.Taskid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Taskid.ForeColor = System.Drawing.Color.White;
            this.Taskid.Location = new System.Drawing.Point(78, 63);
            this.Taskid.Name = "Taskid";
            this.Taskid.Size = new System.Drawing.Size(68, 20);
            this.Taskid.TabIndex = 6;
            this.Taskid.Text = "TaskID";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(211, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 40);
            this.label3.TabIndex = 8;
            this.label3.Text = "תאריך יעד:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(211, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "מזהה:";
            // 
            // iaF_InfoBtn1
            // 
            this.iaF_InfoBtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iaF_InfoBtn1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_InfoBtn1.Location = new System.Drawing.Point(22, 8);
            this.iaF_InfoBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.iaF_InfoBtn1.Name = "iaF_InfoBtn1";
            this.iaF_InfoBtn1.Size = new System.Drawing.Size(31, 33);
            this.iaF_InfoBtn1.TabIndex = 9;
            this.iaF_InfoBtn1.OnButtonPressedEvent += new FinalProjectForm.IAF_InfoBtn.ButtonPressedEvent(this.IaF_InfoBtn1_OnButtonPressedEvent);
            // 
            // SingleTaskView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "SingleTaskView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(781, 98);
            this.Load += new System.EventHandler(this.TasksView_Load);
            this.Click += new System.EventHandler(this.TasksView_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TasksView_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Stext;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer OpenSmooth;
        private System.Windows.Forms.Timer CloseSmooth;
        private IAF_EditBtn iaFbtn11;
        private System.Windows.Forms.Label dDate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Taskid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private IAF_InfoBtn iaF_InfoBtn1;
    }
}
