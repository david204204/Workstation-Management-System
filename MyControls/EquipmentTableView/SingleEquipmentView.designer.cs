namespace FinalProjectForm
{
    partial class SingleEquipmentView
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
            this.Ename = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OpenSmooth = new System.Windows.Forms.Timer(this.components);
            this.CloseSmooth = new System.Windows.Forms.Timer(this.components);
            this.iafnumber = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.description = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialnumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.expirationdate = new System.Windows.Forms.Label();
            this.iaFbtn11 = new FinalProjectForm.IAF_EditBtn();
            this.iaF_upkeepBtn1 = new FinalProjectForm.IAF_upkeepBtn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.department = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ename
            // 
            this.Ename.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Ename.AutoSize = true;
            this.Ename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Ename.ForeColor = System.Drawing.Color.White;
            this.Ename.Location = new System.Drawing.Point(628, 12);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(66, 20);
            this.Ename.TabIndex = 1;
            this.Ename.Text = "תיאור :";
            // 
            // OpenSmooth
            // 
            this.OpenSmooth.Tick += new System.EventHandler(this.OpenSmooth_Tick);
            // 
            // CloseSmooth
            // 
            this.CloseSmooth.Tick += new System.EventHandler(this.CloseSmooth_Tick);
            // 
            // iafnumber
            // 
            this.iafnumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.iafnumber.AutoSize = true;
            this.iafnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iafnumber.ForeColor = System.Drawing.Color.White;
            this.iafnumber.Location = new System.Drawing.Point(200, 11);
            this.iafnumber.Name = "iafnumber";
            this.iafnumber.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.iafnumber.Size = new System.Drawing.Size(92, 22);
            this.iafnumber.TabIndex = 5;
            this.iafnumber.Text = "iafnumber";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.84211F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.52632F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.36364F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.889885F));
            this.tableLayoutPanel1.Controls.Add(this.description, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Ename, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.serialnumber, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iafnumber, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.expirationdate, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.iaFbtn11, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.iaF_upkeepBtn1, 4, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(697, 90);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.TableLayoutPanel1_Click);
            // 
            // description
            // 
            this.description.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(519, 11);
            this.description.Name = "description";
            this.description.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.description.Size = new System.Drawing.Size(102, 22);
            this.description.TabIndex = 10;
            this.description.Text = "description";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(312, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "תוקף:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(307, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "מסחא:";
            // 
            // serialnumber
            // 
            this.serialnumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.serialnumber.AutoSize = true;
            this.serialnumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialnumber.ForeColor = System.Drawing.Color.White;
            this.serialnumber.Location = new System.Drawing.Point(497, 56);
            this.serialnumber.Name = "serialnumber";
            this.serialnumber.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.serialnumber.Size = new System.Drawing.Size(124, 22);
            this.serialnumber.TabIndex = 11;
            this.serialnumber.Text = "serialnumber ";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(629, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 40);
            this.label1.TabIndex = 12;
            this.label1.Text = "מספר סידורי:";
            // 
            // expirationdate
            // 
            this.expirationdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.expirationdate.AutoSize = true;
            this.expirationdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expirationdate.ForeColor = System.Drawing.Color.White;
            this.expirationdate.Location = new System.Drawing.Point(165, 57);
            this.expirationdate.Name = "expirationdate";
            this.expirationdate.Size = new System.Drawing.Size(127, 20);
            this.expirationdate.TabIndex = 6;
            this.expirationdate.Text = "expirationdate";
            // 
            // iaFbtn11
            // 
            this.iaFbtn11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iaFbtn11.BackColor = System.Drawing.Color.Transparent;
            this.iaFbtn11.Location = new System.Drawing.Point(6, 6);
            this.iaFbtn11.Margin = new System.Windows.Forms.Padding(0);
            this.iaFbtn11.Name = "iaFbtn11";
            this.iaFbtn11.Size = new System.Drawing.Size(31, 33);
            this.iaFbtn11.TabIndex = 4;
            this.iaFbtn11.OnButtonPressedEvent += new FinalProjectForm.IAF_EditBtn.ButtonPressedEvent(this.IaFbtn11_OnButtonPressedEvent_1);
            // 
            // iaF_upkeepBtn1
            // 
            this.iaF_upkeepBtn1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iaF_upkeepBtn1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_upkeepBtn1.Location = new System.Drawing.Point(6, 51);
            this.iaF_upkeepBtn1.Margin = new System.Windows.Forms.Padding(0);
            this.iaF_upkeepBtn1.Name = "iaF_upkeepBtn1";
            this.iaF_upkeepBtn1.Size = new System.Drawing.Size(31, 33);
            this.iaF_upkeepBtn1.TabIndex = 13;
            this.iaF_upkeepBtn1.OnButtonPressedEvent += new FinalProjectForm.IAF_upkeepBtn.ButtonPressedEvent(this.IaF_upkeepBtn1_OnButtonPressedEvent);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.859155F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.14085F));
            this.tableLayoutPanel2.Controls.Add(this.department, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(781, 98);
            this.tableLayoutPanel2.TabIndex = 7;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.TableLayoutPanel2_Click);
            // 
            // department
            // 
            this.department.AutoSize = true;
            this.department.Dock = System.Windows.Forms.DockStyle.Fill;
            this.department.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.department.ForeColor = System.Drawing.Color.Yellow;
            this.department.Location = new System.Drawing.Point(708, 0);
            this.department.Name = "department";
            this.department.Size = new System.Drawing.Size(70, 98);
            this.department.TabIndex = 13;
            this.department.Text = "מחלקה";
            // 
            // SingleEquipmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "SingleEquipmentView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(781, 98);
            this.Click += new System.EventHandler(this.SingleEquipmentView_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TasksView_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Ename;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer OpenSmooth;
        private System.Windows.Forms.Timer CloseSmooth;
        private IAF_EditBtn iaFbtn11;
        private System.Windows.Forms.Label iafnumber;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label expirationdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.Label serialnumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label department;
        private IAF_upkeepBtn iaF_upkeepBtn1;
    }
}
