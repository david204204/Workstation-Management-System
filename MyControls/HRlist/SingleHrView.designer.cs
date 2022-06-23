namespace FinalProjectForm
{
    partial class SingleHrView
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
            this.fromdate = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.todate = new System.Windows.Forms.Label();
            this.iaFbtn11 = new FinalProjectForm.IAF_EditBtn();
            this.description = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.Typee = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ename
            // 
            this.Ename.AutoSize = true;
            this.Ename.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Ename.ForeColor = System.Drawing.Color.White;
            this.Ename.Location = new System.Drawing.Point(322, 0);
            this.Ename.Name = "Ename";
            this.Ename.Size = new System.Drawing.Size(59, 20);
            this.Ename.TabIndex = 1;
            this.Ename.Text = "פירוט:";
            // 
            // OpenSmooth
            // 
            this.OpenSmooth.Tick += new System.EventHandler(this.OpenSmooth_Tick);
            // 
            // CloseSmooth
            // 
            this.CloseSmooth.Tick += new System.EventHandler(this.CloseSmooth_Tick);
            // 
            // fromdate
            // 
            this.fromdate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.fromdate.AutoSize = true;
            this.fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromdate.ForeColor = System.Drawing.Color.White;
            this.fromdate.Location = new System.Drawing.Point(110, 71);
            this.fromdate.Name = "fromdate";
            this.fromdate.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.fromdate.Size = new System.Drawing.Size(83, 22);
            this.fromdate.TabIndex = 5;
            this.fromdate.Text = "fromdate";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.66667F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.20803F));
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.fromdate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.todate, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.iaFbtn11, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(301, 331);
            this.tableLayoutPanel1.TabIndex = 6;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.TableLayoutPanel1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(224, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "מתאריך:";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(207, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "עד תאריך:";
            // 
            // todate
            // 
            this.todate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.todate.AutoSize = true;
            this.todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todate.ForeColor = System.Drawing.Color.White;
            this.todate.Location = new System.Drawing.Point(132, 238);
            this.todate.Name = "todate";
            this.todate.Size = new System.Drawing.Size(61, 20);
            this.todate.TabIndex = 6;
            this.todate.Text = "todate";
            // 
            // iaFbtn11
            // 
            this.iaFbtn11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iaFbtn11.BackColor = System.Drawing.Color.Transparent;
            this.iaFbtn11.Location = new System.Drawing.Point(9, 66);
            this.iaFbtn11.Margin = new System.Windows.Forms.Padding(0);
            this.iaFbtn11.Name = "iaFbtn11";
            this.iaFbtn11.Size = new System.Drawing.Size(29, 33);
            this.iaFbtn11.TabIndex = 4;
            this.iaFbtn11.OnButtonPressedEvent += new FinalProjectForm.IAF_EditBtn.ButtonPressedEvent(this.IaFbtn11_OnButtonPressedEvent_1);
            // 
            // description
            // 
            this.description.AutoSize = true;
            this.description.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description.ForeColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(209, 0);
            this.description.Name = "description";
            this.description.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.description.Size = new System.Drawing.Size(102, 22);
            this.description.TabIndex = 10;
            this.description.Text = "description";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.859155F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.14085F));
            this.tableLayoutPanel2.Controls.Add(this.Typee, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(781, 345);
            this.tableLayoutPanel2.TabIndex = 7;
            this.tableLayoutPanel2.Click += new System.EventHandler(this.TableLayoutPanel2_Click);
            // 
            // Typee
            // 
            this.Typee.AutoSize = true;
            this.Typee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.Typee.ForeColor = System.Drawing.Color.Yellow;
            this.Typee.Location = new System.Drawing.Point(744, 0);
            this.Typee.Name = "Typee";
            this.Typee.Size = new System.Drawing.Size(34, 20);
            this.Typee.TabIndex = 13;
            this.Typee.Text = "סוג";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.93705F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.06295F));
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(699, 339);
            this.tableLayoutPanel3.TabIndex = 14;
            this.tableLayoutPanel3.Click += new System.EventHandler(this.TableLayoutPanel2_Click);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tableLayoutPanel4.Controls.Add(this.description, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.Ename, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(312, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(384, 333);
            this.tableLayoutPanel4.TabIndex = 0;
            this.tableLayoutPanel4.Click += new System.EventHandler(this.TableLayoutPanel2_Click);
            // 
            // SingleHrView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.tableLayoutPanel2);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "SingleHrView";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(781, 345);
            this.Load += new System.EventHandler(this.SingleHrView_Load);
            this.Click += new System.EventHandler(this.SingleEquipmentView_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.TasksView_Paint);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Ename;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer OpenSmooth;
        private System.Windows.Forms.Timer CloseSmooth;
        private System.Windows.Forms.Label fromdate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label todate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label description;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label Typee;
        private IAF_EditBtn iaFbtn11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
    }
}
