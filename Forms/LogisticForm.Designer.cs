namespace FinalProjectForm.Forms
{
    partial class LogisticForm
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
            this.orderNow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.SecondPanel = new System.Windows.Forms.TableLayoutPanel();
            this.iaF_WorkShop1 = new FinalProjectForm.MyControls.IAF_WorkShop();
            this.MainPanel.SuspendLayout();
            this.SecondPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderNow
            // 
            this.orderNow.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.orderNow.Location = new System.Drawing.Point(78, 4);
            this.orderNow.Name = "orderNow";
            this.orderNow.Size = new System.Drawing.Size(69, 29);
            this.orderNow.TabIndex = 19;
            this.orderNow.Text = "הזמן";
            this.orderNow.UseVisualStyleBackColor = true;
            this.orderNow.Click += new System.EventHandler(this.orderNow_Click_2);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(69, 29);
            this.button1.TabIndex = 22;
            this.button1.Text = "אפס מלאי";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // MainPanel
            // 
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.Controls.Add(this.SecondPanel, 0, 1);
            this.MainPanel.Controls.Add(this.iaF_WorkShop1, 0, 0);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 2;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.MainPanel.Size = new System.Drawing.Size(995, 539);
            this.MainPanel.TabIndex = 23;
            // 
            // SecondPanel
            // 
            this.SecondPanel.ColumnCount = 4;
            this.SecondPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.SecondPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SecondPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.SecondPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.SecondPanel.Controls.Add(this.button1, 3, 0);
            this.SecondPanel.Controls.Add(this.orderNow, 2, 0);
            this.SecondPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecondPanel.Location = new System.Drawing.Point(2, 500);
            this.SecondPanel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.SecondPanel.Name = "SecondPanel";
            this.SecondPanel.RowCount = 1;
            this.SecondPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SecondPanel.Size = new System.Drawing.Size(991, 37);
            this.SecondPanel.TabIndex = 24;
            // 
            // iaF_WorkShop1
            // 
            this.iaF_WorkShop1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.iaF_WorkShop1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_WorkShop1.Location = new System.Drawing.Point(5, 2);
            this.iaF_WorkShop1.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.iaF_WorkShop1.Name = "iaF_WorkShop1";
            this.iaF_WorkShop1.Size = new System.Drawing.Size(985, 494);
            this.iaF_WorkShop1.TabIndex = 21;
            // 
            // LogisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 539);
            this.Controls.Add(this.MainPanel);
            this.Name = "LogisticForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "לוגיסטיקה";
            this.MainPanel.ResumeLayout(false);
            this.SecondPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button orderNow;
        private MyControls.IAF_WorkShop iaF_WorkShop1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.TableLayoutPanel SecondPanel;
        //private MyControls.IAF_WorkShop iaF_WorkShop1;
    }
}