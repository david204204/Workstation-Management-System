namespace FinalProjectForm
{
    partial class SingleLine
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Vlbl = new System.Windows.Forms.Label();
            this.Slbl = new System.Windows.Forms.Label();
            this.Dlbl = new System.Windows.Forms.Label();
            this.Tlbl = new System.Windows.Forms.Label();
            this.Eid = new System.Windows.Forms.Label();
            this.CloseSmooth = new System.Windows.Forms.Timer(this.components);
            this.OpenSmooth = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.Vlbl, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.Slbl, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.Dlbl, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Tlbl, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Eid, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(586, 32);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Click += new System.EventHandler(this.tableLayoutPanel1_Click);
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // Vlbl
            // 
            this.Vlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Vlbl.AutoSize = true;
            this.Vlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vlbl.ForeColor = System.Drawing.Color.White;
            this.Vlbl.Location = new System.Drawing.Point(103, 7);
            this.Vlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Vlbl.Name = "Vlbl";
            this.Vlbl.Size = new System.Drawing.Size(13, 17);
            this.Vlbl.TabIndex = 4;
            this.Vlbl.Text = "*";
            // 
            // Slbl
            // 
            this.Slbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Slbl.AutoSize = true;
            this.Slbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slbl.ForeColor = System.Drawing.Color.White;
            this.Slbl.Location = new System.Drawing.Point(220, 7);
            this.Slbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Slbl.Name = "Slbl";
            this.Slbl.Size = new System.Drawing.Size(13, 17);
            this.Slbl.TabIndex = 3;
            this.Slbl.Text = "*";
            // 
            // Dlbl
            // 
            this.Dlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Dlbl.AutoSize = true;
            this.Dlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dlbl.ForeColor = System.Drawing.Color.White;
            this.Dlbl.Location = new System.Drawing.Point(337, 7);
            this.Dlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dlbl.Name = "Dlbl";
            this.Dlbl.Size = new System.Drawing.Size(13, 17);
            this.Dlbl.TabIndex = 2;
            this.Dlbl.Text = "*";
            // 
            // Tlbl
            // 
            this.Tlbl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Tlbl.AutoSize = true;
            this.Tlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tlbl.ForeColor = System.Drawing.Color.White;
            this.Tlbl.Location = new System.Drawing.Point(454, 7);
            this.Tlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Tlbl.Name = "Tlbl";
            this.Tlbl.Size = new System.Drawing.Size(13, 17);
            this.Tlbl.TabIndex = 1;
            this.Tlbl.Text = "*";
            // 
            // Eid
            // 
            this.Eid.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Eid.AutoSize = true;
            this.Eid.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eid.ForeColor = System.Drawing.Color.White;
            this.Eid.Location = new System.Drawing.Point(571, 7);
            this.Eid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Eid.Name = "Eid";
            this.Eid.Size = new System.Drawing.Size(13, 17);
            this.Eid.TabIndex = 0;
            this.Eid.Text = "*";
            // 
            // CloseSmooth
            // 
            this.CloseSmooth.Tick += new System.EventHandler(this.CloseSmooth_Tick_1);
            // 
            // OpenSmooth
            // 
            this.OpenSmooth.Tick += new System.EventHandler(this.OpenSmooth_Tick_1);
            // 
            // SingleLine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.Name = "SingleLine";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Size = new System.Drawing.Size(586, 32);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label Eid;
        private System.Windows.Forms.Label Vlbl;
        private System.Windows.Forms.Label Slbl;
        private System.Windows.Forms.Label Dlbl;
        private System.Windows.Forms.Label Tlbl;


        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer CloseSmooth;
        private System.Windows.Forms.Timer OpenSmooth;
        private System.Windows.Forms.Timer timer2;
    }
}
