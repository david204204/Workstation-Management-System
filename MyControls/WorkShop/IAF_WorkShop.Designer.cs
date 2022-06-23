namespace FinalProjectForm.MyControls
{
    partial class IAF_WorkShop
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.shopHeadNew1 = new FinalProjectForm.MyControls.WorkShop.shopHeadNew();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 26);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(600, 347);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.SizeChanged += new System.EventHandler(this.FlowLayoutPanel1_SizeChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.shopHeadNew1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(604, 375);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // shopHeadNew1
            // 
            this.shopHeadNew1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.shopHeadNew1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.shopHeadNew1.DoneDate = "כמות במלאי";
            this.shopHeadNew1.EngineNum = "מסח\'\'א";
            this.shopHeadNew1.EngineTesters = "כמות שנצרכה";
            this.shopHeadNew1.JobDes = "שם רכיב";
            this.shopHeadNew1.Location = new System.Drawing.Point(0, 1);
            this.shopHeadNew1.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.shopHeadNew1.Name = "shopHeadNew1";
            this.shopHeadNew1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.shopHeadNew1.Size = new System.Drawing.Size(604, 23);
            this.shopHeadNew1.Status = "כמות להזמנה";
            this.shopHeadNew1.TabIndex = 1;
            this.shopHeadNew1.Tag = "";
            // 
            // IAF_WorkShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "IAF_WorkShop";
            this.Size = new System.Drawing.Size(604, 375);
            this.Load += new System.EventHandler(this.IAF_WorkShop_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private WorkShop.shopHeadNew shopHeadNew1;
    }
}
