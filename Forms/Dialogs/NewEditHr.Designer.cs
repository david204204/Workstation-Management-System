namespace FinalProjectForm.Forms.Dialogs
{
    partial class NewEditHr
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
            this.useridnum = new System.Windows.Forms.NumericUpDown();
            this.TaskID1 = new System.Windows.Forms.Label();
            this.DueDate2 = new System.Windows.Forms.Label();
            this.Fromdate = new System.Windows.Forms.DateTimePicker();
            this.Title2 = new System.Windows.Forms.Label();
            this.Exbtn = new System.Windows.Forms.Button();
            this.Details2 = new System.Windows.Forms.Label();
            this.description = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Todate = new System.Windows.Forms.DateTimePicker();
            this.typeofactive = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useridnum)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 158F));
            this.tableLayoutPanel1.Controls.Add(this.useridnum, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.TaskID1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.DueDate2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Fromdate, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Title2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Exbtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Details2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.description, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Todate, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.typeofactive, 0, 1);
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
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(474, 489);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // useridnum
            // 
            this.useridnum.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.useridnum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.useridnum.ForeColor = System.Drawing.Color.Black;
            this.useridnum.Location = new System.Drawing.Point(48, 22);
            this.useridnum.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.useridnum.Name = "useridnum";
            this.useridnum.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.useridnum.Size = new System.Drawing.Size(265, 24);
            this.useridnum.TabIndex = 3;
            // 
            // TaskID1
            // 
            this.TaskID1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TaskID1.AutoSize = true;
            this.TaskID1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskID1.ForeColor = System.Drawing.Color.White;
            this.TaskID1.Location = new System.Drawing.Point(374, 24);
            this.TaskID1.Name = "TaskID1";
            this.TaskID1.Size = new System.Drawing.Size(97, 20);
            this.TaskID1.TabIndex = 5;
            this.TaskID1.Text = "מספר אישי:";
            // 
            // DueDate2
            // 
            this.DueDate2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DueDate2.AutoSize = true;
            this.DueDate2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DueDate2.ForeColor = System.Drawing.Color.White;
            this.DueDate2.Location = new System.Drawing.Point(397, 162);
            this.DueDate2.Name = "DueDate2";
            this.DueDate2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DueDate2.Size = new System.Drawing.Size(74, 20);
            this.DueDate2.TabIndex = 8;
            this.DueDate2.Text = "מתאריך:";
            // 
            // Fromdate
            // 
            this.Fromdate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Fromdate.CustomFormat = "ddd dd MMM yyyy";
            this.Fromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fromdate.ForeColor = System.Drawing.Color.White;
            this.Fromdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Fromdate.Location = new System.Drawing.Point(48, 160);
            this.Fromdate.Name = "Fromdate";
            this.Fromdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Fromdate.RightToLeftLayout = true;
            this.Fromdate.Size = new System.Drawing.Size(265, 24);
            this.Fromdate.TabIndex = 7;
            // 
            // Title2
            // 
            this.Title2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Title2.AutoSize = true;
            this.Title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title2.ForeColor = System.Drawing.Color.White;
            this.Title2.Location = new System.Drawing.Point(437, 93);
            this.Title2.Name = "Title2";
            this.Title2.Size = new System.Drawing.Size(34, 20);
            this.Title2.TabIndex = 6;
            this.Title2.Text = "סוג";
            // 
            // Exbtn
            // 
            this.Exbtn.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Exbtn.Location = new System.Drawing.Point(58, 430);
            this.Exbtn.Name = "Exbtn";
            this.Exbtn.Size = new System.Drawing.Size(255, 43);
            this.Exbtn.TabIndex = 21;
            this.Exbtn.Text = "שמור";
            this.Exbtn.UseVisualStyleBackColor = true;
            this.Exbtn.Click += new System.EventHandler(this.Exbtn_Click);
            // 
            // Details2
            // 
            this.Details2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Details2.AutoSize = true;
            this.Details2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Details2.ForeColor = System.Drawing.Color.White;
            this.Details2.Location = new System.Drawing.Point(411, 370);
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
            this.description.Location = new System.Drawing.Point(48, 349);
            this.description.Multiline = true;
            this.description.Name = "description";
            this.description.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.description.Size = new System.Drawing.Size(265, 63);
            this.description.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(380, 266);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 22;
            this.label1.Text = "עד תאריך:";
            // 
            // Todate
            // 
            this.Todate.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Todate.CustomFormat = "ddd dd MMM yyyy";
            this.Todate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Todate.ForeColor = System.Drawing.Color.White;
            this.Todate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Todate.Location = new System.Drawing.Point(48, 264);
            this.Todate.Name = "Todate";
            this.Todate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Todate.RightToLeftLayout = true;
            this.Todate.Size = new System.Drawing.Size(265, 24);
            this.Todate.TabIndex = 23;
            // 
            // typeofactive
            // 
            this.typeofactive.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeofactive.FormattingEnabled = true;
            this.typeofactive.Location = new System.Drawing.Point(48, 91);
            this.typeofactive.Name = "typeofactive";
            this.typeofactive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeofactive.Size = new System.Drawing.Size(265, 24);
            this.typeofactive.TabIndex = 24;
            // 
            // NewEditHr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(474, 489);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewEditHr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.useridnum)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Details2;
        private System.Windows.Forms.TextBox description;
        private System.Windows.Forms.Label DueDate2;
        private System.Windows.Forms.DateTimePicker Fromdate;
        private System.Windows.Forms.Label Title2;
        private System.Windows.Forms.NumericUpDown useridnum;
        private System.Windows.Forms.Label TaskID1;
        private System.Windows.Forms.Button Exbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker Todate;
        private System.Windows.Forms.ComboBox typeofactive;
    }
}