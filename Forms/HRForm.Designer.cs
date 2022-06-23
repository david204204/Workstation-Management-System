namespace FinalProjectForm.Forms
{
    partial class HRForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.iaF_LabelSepertor1 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.Idtouse = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Newhr = new System.Windows.Forms.Button();
            this.SnameLbl = new System.Windows.Forms.Label();
            this.Viewall = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.WhatView = new System.Windows.Forms.ComboBox();
            this.iaF_LabelSepertor2 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.hrList1 = new FinalProjectForm.MyControls.HrList();
            this.ExportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ExelExport = new System.Windows.Forms.ToolStripMenuItem();
            this.Vieall = new System.Windows.Forms.ToolStripMenuItem();
            this.newE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.ExportMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.iaF_LabelSepertor1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.iaF_LabelSepertor2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.hrList1, 0, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // iaF_LabelSepertor1
            // 
            this.iaF_LabelSepertor1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaF_LabelSepertor1.LineLocation = true;
            this.iaF_LabelSepertor1.LineThickness = 1;
            this.iaF_LabelSepertor1.Location = new System.Drawing.Point(4, 4);
            this.iaF_LabelSepertor1.MainText = "ניהול כח אדם";
            this.iaF_LabelSepertor1.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor1.Name = "iaF_LabelSepertor1";
            this.iaF_LabelSepertor1.PointDiamiter = 10;
            this.iaF_LabelSepertor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor1.Size = new System.Drawing.Size(1059, 25);
            this.iaF_LabelSepertor1.TabIndex = 0;
            this.iaF_LabelSepertor1.TextSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.01408F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.98592F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 263F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.Idtouse, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 2, 2);
            this.tableLayoutPanel2.Controls.Add(this.Newhr, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.SnameLbl, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.Viewall, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.WhatView, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.42735F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.57265F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1061, 144);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(864, 14);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(194, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "חיפוש חייל לפי מספר אישי:";
            // 
            // Idtouse
            // 
            this.Idtouse.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Idtouse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Idtouse.Location = new System.Drawing.Point(590, 10);
            this.Idtouse.Name = "Idtouse";
            this.Idtouse.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Idtouse.Size = new System.Drawing.Size(204, 27);
            this.Idtouse.TabIndex = 0;
            this.Idtouse.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(976, 110);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "חייל נבחר:";
            // 
            // Newhr
            // 
            this.Newhr.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Newhr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newhr.Location = new System.Drawing.Point(166, 102);
            this.Newhr.Name = "Newhr";
            this.Newhr.Size = new System.Drawing.Size(182, 35);
            this.Newhr.TabIndex = 4;
            this.Newhr.Text = "הוסף אילוץ";
            this.Newhr.UseVisualStyleBackColor = true;
            this.Newhr.Click += new System.EventHandler(this.Newhr_Click);
            // 
            // SnameLbl
            // 
            this.SnameLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SnameLbl.AutoSize = true;
            this.SnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SnameLbl.Location = new System.Drawing.Point(770, 104);
            this.SnameLbl.Name = "SnameLbl";
            this.SnameLbl.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SnameLbl.Size = new System.Drawing.Size(24, 32);
            this.SnameLbl.TabIndex = 3;
            this.SnameLbl.Text = "-";
            // 
            // Viewall
            // 
            this.Viewall.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Viewall.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Viewall.Location = new System.Drawing.Point(166, 52);
            this.Viewall.Name = "Viewall";
            this.Viewall.Size = new System.Drawing.Size(182, 39);
            this.Viewall.TabIndex = 1;
            this.Viewall.Text = "הצג את כל החיילים";
            this.Viewall.UseVisualStyleBackColor = true;
            this.Viewall.Click += new System.EventHandler(this.Viewall_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(166, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(182, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "חפש";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1019, 62);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "הצג:";
            // 
            // WhatView
            // 
            this.WhatView.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.WhatView.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WhatView.FormattingEnabled = true;
            this.WhatView.Items.AddRange(new object[] {
            "את הכל",
            "רק רלוונטי"});
            this.WhatView.Location = new System.Drawing.Point(590, 60);
            this.WhatView.Name = "WhatView";
            this.WhatView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.WhatView.Size = new System.Drawing.Size(204, 24);
            this.WhatView.TabIndex = 6;
            // 
            // iaF_LabelSepertor2
            // 
            this.iaF_LabelSepertor2.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaF_LabelSepertor2.LineLocation = true;
            this.iaF_LabelSepertor2.LineThickness = 1;
            this.iaF_LabelSepertor2.Location = new System.Drawing.Point(4, 187);
            this.iaF_LabelSepertor2.MainText = "אילוצים";
            this.iaF_LabelSepertor2.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor2.Name = "iaF_LabelSepertor2";
            this.iaF_LabelSepertor2.PointDiamiter = 10;
            this.iaF_LabelSepertor2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor2.Size = new System.Drawing.Size(1059, 25);
            this.iaF_LabelSepertor2.TabIndex = 2;
            this.iaF_LabelSepertor2.TextSize = 10;
            // 
            // hrList1
            // 
            this.hrList1.BackColor = System.Drawing.Color.Transparent;
            this.hrList1.ContextMenuStrip = this.ExportMenu;
            this.hrList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hrList1.Location = new System.Drawing.Point(3, 219);
            this.hrList1.Name = "hrList1";
            this.hrList1.OpeningSpeed = 1;
            this.hrList1.ShowEditBtn = 1;
            this.hrList1.Size = new System.Drawing.Size(1061, 332);
            this.hrList1.TabIndex = 3;
            this.hrList1.EditButtonPresedps += new FinalProjectForm.MyControls.HrList.EditButPressedEvent(this.HrList1_EditButtonPresedps);
            // 
            // ExportMenu
            // 
            this.ExportMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ExportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Vieall,
            this.newE,
            this.toolStripSeparator1,
            this.ExelExport});
            this.ExportMenu.Name = "ExportMenu";
            this.ExportMenu.Size = new System.Drawing.Size(208, 82);
            // 
            // ExelExport
            // 
            this.ExelExport.Name = "ExelExport";
            this.ExelExport.Size = new System.Drawing.Size(207, 24);
            this.ExelExport.Text = "ייצוא לאקסל";
            this.ExelExport.Click += new System.EventHandler(this.ExelExport_Click);
            // 
            // Vieall
            // 
            this.Vieall.Name = "Vieall";
            this.Vieall.Size = new System.Drawing.Size(207, 24);
            this.Vieall.Text = "הצג את  כל החיילים";
            this.Vieall.Click += new System.EventHandler(this.Viewall_Click);
            // 
            // newE
            // 
            this.newE.Name = "newE";
            this.newE.Size = new System.Drawing.Size(207, 24);
            this.newE.Text = "אילוץ חדש";
            this.newE.Click += new System.EventHandler(this.Newhr_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(204, 6);
            // 
            // HRForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HRForm";
            this.Text = "כח אדם";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ExportMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Idtouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SnameLbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Viewall;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor2;
        private MyControls.HrList hrList1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Newhr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox WhatView;
        private System.Windows.Forms.ContextMenuStrip ExportMenu;
        private System.Windows.Forms.ToolStripMenuItem ExelExport;
        private System.Windows.Forms.ToolStripMenuItem Vieall;
        private System.Windows.Forms.ToolStripMenuItem newE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}