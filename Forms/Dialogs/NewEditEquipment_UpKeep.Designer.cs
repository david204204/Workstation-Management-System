namespace FinalProjectForm.Forms.Dialogs
{
    partial class NewEditEquipment_UpKeep
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
            this.Upkeepdgv = new System.Windows.Forms.DataGridView();
            this.typeCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExtrainfoTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TodayLbl = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TirdPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.DGVshow = new System.Windows.Forms.ComboBox();
            this.ForthPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SecondPanel = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.TimespanCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.EXPlbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addnewupkeep = new System.Windows.Forms.Button();
            this.iaF_LabelSepertor1 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.iaF_LabelSepertor2 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            ((System.ComponentModel.ISupportInitialize)(this.Upkeepdgv)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.TirdPanel.SuspendLayout();
            this.ForthPanel.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Upkeepdgv
            // 
            this.Upkeepdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Upkeepdgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Upkeepdgv.Location = new System.Drawing.Point(3, 36);
            this.Upkeepdgv.Name = "Upkeepdgv";
            this.Upkeepdgv.ReadOnly = true;
            this.Upkeepdgv.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Upkeepdgv.RowTemplate.Height = 24;
            this.Upkeepdgv.Size = new System.Drawing.Size(781, 239);
            this.Upkeepdgv.TabIndex = 1;
            this.Upkeepdgv.Paint += new System.Windows.Forms.PaintEventHandler(this.Upkeepdgv_Paint);
            // 
            // typeCB
            // 
            this.typeCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.typeCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeCB.FormattingEnabled = true;
            this.typeCB.Items.AddRange(new object[] {
            "בדיקה",
            "אחזקה"});
            this.typeCB.Location = new System.Drawing.Point(467, 5);
            this.typeCB.Name = "typeCB";
            this.typeCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.typeCB.Size = new System.Drawing.Size(169, 24);
            this.typeCB.TabIndex = 4;
            this.typeCB.SelectedIndexChanged += new System.EventHandler(this.TypeCB_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(742, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(30, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "סוג:";
            // 
            // ExtrainfoTB
            // 
            this.ExtrainfoTB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ExtrainfoTB.Location = new System.Drawing.Point(467, 76);
            this.ExtrainfoTB.Multiline = true;
            this.ExtrainfoTB.Name = "ExtrainfoTB";
            this.ExtrainfoTB.Size = new System.Drawing.Size(169, 48);
            this.ExtrainfoTB.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(656, 91);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(116, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "מידע נוסף לאחזקה:";
            // 
            // TodayLbl
            // 
            this.TodayLbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TodayLbl.AutoSize = true;
            this.TodayLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TodayLbl.ForeColor = System.Drawing.Color.Black;
            this.TodayLbl.Location = new System.Drawing.Point(547, 136);
            this.TodayLbl.Name = "TodayLbl";
            this.TodayLbl.Size = new System.Drawing.Size(89, 18);
            this.TodayLbl.TabIndex = 8;
            this.TodayLbl.Text = "תאריך היום";
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.iaF_LabelSepertor1, 0, 0);
            this.MainPanel.Controls.Add(this.Upkeepdgv, 0, 1);
            this.MainPanel.Controls.Add(this.iaF_LabelSepertor2, 0, 3);
            this.MainPanel.Controls.Add(this.TirdPanel, 0, 2);
            this.MainPanel.Controls.Add(this.ForthPanel, 0, 4);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 5;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Size = new System.Drawing.Size(787, 590);
            this.MainPanel.TabIndex = 9;
            // 
            // TirdPanel
            // 
            this.TirdPanel.ColumnCount = 2;
            this.TirdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 87.57613F));
            this.TirdPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.42387F));
            this.TirdPanel.Controls.Add(this.label3, 1, 0);
            this.TirdPanel.Controls.Add(this.DGVshow, 0, 0);
            this.TirdPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TirdPanel.Location = new System.Drawing.Point(3, 281);
            this.TirdPanel.Name = "TirdPanel";
            this.TirdPanel.RowCount = 1;
            this.TirdPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TirdPanel.Size = new System.Drawing.Size(781, 27);
            this.TirdPanel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(744, 5);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(34, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "הצג:";
            // 
            // DGVshow
            // 
            this.DGVshow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DGVshow.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DGVshow.FormattingEnabled = true;
            this.DGVshow.Items.AddRange(new object[] {
            "הכל",
            "פגי תוקף",
            "בתוקף"});
            this.DGVshow.Location = new System.Drawing.Point(559, 3);
            this.DGVshow.Name = "DGVshow";
            this.DGVshow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGVshow.Size = new System.Drawing.Size(121, 24);
            this.DGVshow.TabIndex = 0;
            this.DGVshow.SelectedIndexChanged += new System.EventHandler(this.DGVshow_SelectedIndexChanged);
            // 
            // ForthPanel
            // 
            this.ForthPanel.ColumnCount = 1;
            this.ForthPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ForthPanel.Controls.Add(this.SecondPanel, 0, 0);
            this.ForthPanel.Controls.Add(this.addnewupkeep, 0, 1);
            this.ForthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ForthPanel.Location = new System.Drawing.Point(3, 347);
            this.ForthPanel.Name = "ForthPanel";
            this.ForthPanel.RowCount = 2;
            this.ForthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ForthPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.ForthPanel.Size = new System.Drawing.Size(781, 240);
            this.ForthPanel.TabIndex = 6;
            // 
            // SecondPanel
            // 
            this.SecondPanel.ColumnCount = 2;
            this.SecondPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.48792F));
            this.SecondPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.51208F));
            this.SecondPanel.Controls.Add(this.label6, 1, 1);
            this.SecondPanel.Controls.Add(this.TimespanCB, 0, 1);
            this.SecondPanel.Controls.Add(this.label1, 1, 0);
            this.SecondPanel.Controls.Add(this.label5, 1, 4);
            this.SecondPanel.Controls.Add(this.typeCB, 0, 0);
            this.SecondPanel.Controls.Add(this.EXPlbl, 0, 4);
            this.SecondPanel.Controls.Add(this.label4, 1, 3);
            this.SecondPanel.Controls.Add(this.TodayLbl, 0, 3);
            this.SecondPanel.Controls.Add(this.label2, 1, 2);
            this.SecondPanel.Controls.Add(this.ExtrainfoTB, 0, 2);
            this.SecondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondPanel.Location = new System.Drawing.Point(3, 3);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.RowCount = 5;
            this.SecondPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.54369F));
            this.SecondPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.45631F));
            this.SecondPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.SecondPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.SecondPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.SecondPanel.Size = new System.Drawing.Size(775, 199);
            this.SecondPanel.TabIndex = 4;
            this.SecondPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SecondPanel_Paint);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(715, 45);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "פרק זמן:";
            // 
            // TimespanCB
            // 
            this.TimespanCB.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.TimespanCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TimespanCB.FormattingEnabled = true;
            this.TimespanCB.Items.AddRange(new object[] {
            "יומית",
            "שבועית",
            "חודשית"});
            this.TimespanCB.Location = new System.Drawing.Point(467, 42);
            this.TimespanCB.Name = "TimespanCB";
            this.TimespanCB.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.TimespanCB.Size = new System.Drawing.Size(169, 24);
            this.TimespanCB.TabIndex = 10;
            this.TimespanCB.SelectedIndexChanged += new System.EventHandler(this.TimespanCB_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(705, 172);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "בתוקף עד:";
            // 
            // EXPlbl
            // 
            this.EXPlbl.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EXPlbl.AutoSize = true;
            this.EXPlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXPlbl.ForeColor = System.Drawing.Color.Red;
            this.EXPlbl.Location = new System.Drawing.Point(572, 172);
            this.EXPlbl.Name = "EXPlbl";
            this.EXPlbl.Size = new System.Drawing.Size(64, 18);
            this.EXPlbl.TabIndex = 11;
            this.EXPlbl.Text = "פג תוקף";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(685, 136);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(87, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "תאריך אחזקה:";
            // 
            // addnewupkeep
            // 
            this.addnewupkeep.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addnewupkeep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addnewupkeep.Location = new System.Drawing.Point(297, 208);
            this.addnewupkeep.Name = "addnewupkeep";
            this.addnewupkeep.Size = new System.Drawing.Size(187, 29);
            this.addnewupkeep.TabIndex = 5;
            this.addnewupkeep.Text = "שמור";
            this.addnewupkeep.UseVisualStyleBackColor = true;
            this.addnewupkeep.Click += new System.EventHandler(this.Addnewupkeep_Click);
            // 
            // iaF_LabelSepertor1
            // 
            this.iaF_LabelSepertor1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaF_LabelSepertor1.LineLocation = true;
            this.iaF_LabelSepertor1.LineThickness = 1;
            this.iaF_LabelSepertor1.Location = new System.Drawing.Point(4, 4);
            this.iaF_LabelSepertor1.MainText = "תחזוקה של פריט";
            this.iaF_LabelSepertor1.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor1.Name = "iaF_LabelSepertor1";
            this.iaF_LabelSepertor1.PointDiamiter = 10;
            this.iaF_LabelSepertor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor1.Size = new System.Drawing.Size(779, 25);
            this.iaF_LabelSepertor1.TabIndex = 2;
            this.iaF_LabelSepertor1.TextSize = 10;
            // 
            // iaF_LabelSepertor2
            // 
            this.iaF_LabelSepertor2.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iaF_LabelSepertor2.LineLocation = true;
            this.iaF_LabelSepertor2.LineThickness = 1;
            this.iaF_LabelSepertor2.Location = new System.Drawing.Point(4, 315);
            this.iaF_LabelSepertor2.MainText = "תחזוקה חדשה לפריט";
            this.iaF_LabelSepertor2.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor2.Name = "iaF_LabelSepertor2";
            this.iaF_LabelSepertor2.PointDiamiter = 10;
            this.iaF_LabelSepertor2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor2.Size = new System.Drawing.Size(779, 25);
            this.iaF_LabelSepertor2.TabIndex = 3;
            this.iaF_LabelSepertor2.TextSize = 10;
            // 
            // NewEditEquipment_UpKeep
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(787, 590);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "NewEditEquipment_UpKeep";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            ((System.ComponentModel.ISupportInitialize)(this.Upkeepdgv)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.TirdPanel.ResumeLayout(false);
            this.TirdPanel.PerformLayout();
            this.ForthPanel.ResumeLayout(false);
            this.SecondPanel.ResumeLayout(false);
            this.SecondPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Upkeepdgv;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor1;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor2;
        private System.Windows.Forms.ComboBox typeCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ExtrainfoTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label TodayLbl;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel SecondPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label EXPlbl;
        private System.Windows.Forms.TableLayoutPanel TirdPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox DGVshow;
        private System.Windows.Forms.ComboBox TimespanCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel ForthPanel;
        private System.Windows.Forms.Button addnewupkeep;
    }
}