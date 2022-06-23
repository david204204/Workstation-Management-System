namespace FinalProjectForm.Forms
{
    partial class EquipmentForm
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
            this.equipmentList1 = new FinalProjectForm.MyControls.EquipmentList();
            this.ExportMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.AddE = new System.Windows.Forms.ToolStripMenuItem();
            this.SeaE = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ExelExport = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.iaF_LabelSepertor2 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.NewEq = new System.Windows.Forms.Button();
            this.SeEq = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.ExportMenu.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.equipmentList1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.iaF_LabelSepertor2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.5F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1067, 554);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // equipmentList1
            // 
            this.equipmentList1.BackColor = System.Drawing.Color.Transparent;
            this.equipmentList1.ContextMenuStrip = this.ExportMenu;
            this.equipmentList1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentList1.Location = new System.Drawing.Point(2, 129);
            this.equipmentList1.Margin = new System.Windows.Forms.Padding(2);
            this.equipmentList1.Name = "equipmentList1";
            this.equipmentList1.OpeningSpeed = 1;
            this.equipmentList1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.equipmentList1.ShowEditBtn = 1;
            this.equipmentList1.Size = new System.Drawing.Size(1063, 423);
            this.equipmentList1.TabIndex = 2;
            this.equipmentList1.EditButtonPresedps += new FinalProjectForm.MyControls.EquipmentList.EditButPressedEvent(this.EquipmentList1_EditButtonPresedps);
            this.equipmentList1.UpKeepButtonPresedps += new FinalProjectForm.MyControls.EquipmentList.UpKeepButPressedEvent(this.EquipmentList1_UpKeepButtonPresedps);
            // 
            // ExportMenu
            // 
            this.ExportMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ExportMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddE,
            this.SeaE,
            this.toolStripSeparator1,
            this.ExelExport});
            this.ExportMenu.Name = "ExportMenu";
            this.ExportMenu.Size = new System.Drawing.Size(160, 82);
            // 
            // AddE
            // 
            this.AddE.Name = "AddE";
            this.AddE.Size = new System.Drawing.Size(159, 24);
            this.AddE.Text = "הוספת ציוד";
            this.AddE.Click += new System.EventHandler(this.NewEq_Click_1);
            // 
            // SeaE
            // 
            this.SeaE.Name = "SeaE";
            this.SeaE.Size = new System.Drawing.Size(159, 24);
            this.SeaE.Text = "חיפוש ציוד";
            this.SeaE.Click += new System.EventHandler(this.SeEq_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(156, 6);
            // 
            // ExelExport
            // 
            this.ExelExport.Name = "ExelExport";
            this.ExelExport.Size = new System.Drawing.Size(159, 24);
            this.ExelExport.Text = "ייצוא לאקסל";
            this.ExelExport.Click += new System.EventHandler(this.ExelExport_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(966, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "ניהול ציוד";
            // 
            // iaF_LabelSepertor2
            // 
            this.iaF_LabelSepertor2.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaF_LabelSepertor2.LineLocation = true;
            this.iaF_LabelSepertor2.LineThickness = 1;
            this.iaF_LabelSepertor2.Location = new System.Drawing.Point(4, 98);
            this.iaF_LabelSepertor2.MainText = "ציוד:";
            this.iaF_LabelSepertor2.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor2.Name = "iaF_LabelSepertor2";
            this.iaF_LabelSepertor2.PointDiamiter = 10;
            this.iaF_LabelSepertor2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor2.Size = new System.Drawing.Size(1059, 25);
            this.iaF_LabelSepertor2.TabIndex = 1;
            this.iaF_LabelSepertor2.TextSize = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.NewEq, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.SeEq, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 36);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1061, 55);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // NewEq
            // 
            this.NewEq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NewEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewEq.Location = new System.Drawing.Point(533, 3);
            this.NewEq.Name = "NewEq";
            this.NewEq.Size = new System.Drawing.Size(525, 49);
            this.NewEq.TabIndex = 5;
            this.NewEq.Text = "הוספת ציוד";
            this.NewEq.UseVisualStyleBackColor = true;
            this.NewEq.Click += new System.EventHandler(this.NewEq_Click_1);
            // 
            // SeEq
            // 
            this.SeEq.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SeEq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeEq.Location = new System.Drawing.Point(3, 3);
            this.SeEq.Name = "SeEq";
            this.SeEq.Size = new System.Drawing.Size(524, 49);
            this.SeEq.TabIndex = 4;
            this.SeEq.Text = "חיפוש ציוד";
            this.SeEq.UseVisualStyleBackColor = true;
            this.SeEq.Click += new System.EventHandler(this.SeEq_Click);
            // 
            // EquipmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EquipmentForm";
            this.Text = "ניהול ציוד";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ExportMenu.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MyControls.EquipmentList equipmentList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button NewEq;
        private System.Windows.Forms.Button SeEq;
        private System.Windows.Forms.ContextMenuStrip ExportMenu;
        private System.Windows.Forms.ToolStripMenuItem ExelExport;
        private System.Windows.Forms.ToolStripMenuItem AddE;
        private System.Windows.Forms.ToolStripMenuItem SeaE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}