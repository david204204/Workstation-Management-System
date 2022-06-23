namespace FinalProjectForm.Forms.Dialogs
{
    partial class PersonalNumSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonalNumSelector));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Keepbtn = new System.Windows.Forms.Button();
            this.iaF_LabelSepertor1 = new FinalProjectForm.MyControls.IAF_LabelSepertor();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(379, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // Keepbtn
            // 
            this.Keepbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Keepbtn.Location = new System.Drawing.Point(13, 393);
            this.Keepbtn.Name = "Keepbtn";
            this.Keepbtn.Size = new System.Drawing.Size(376, 39);
            this.Keepbtn.TabIndex = 1;
            this.Keepbtn.Text = "בחר";
            this.Keepbtn.UseVisualStyleBackColor = true;
            this.Keepbtn.Click += new System.EventHandler(this.Keepbtn_Click);
            // 
            // iaF_LabelSepertor1
            // 
            this.iaF_LabelSepertor1.BackColor = System.Drawing.Color.Transparent;
            this.iaF_LabelSepertor1.LineLocation = true;
            this.iaF_LabelSepertor1.LineThickness = 1;
            this.iaF_LabelSepertor1.Location = new System.Drawing.Point(13, 3);
            this.iaF_LabelSepertor1.MainText = "נא לבחור חייל מבצע";
            this.iaF_LabelSepertor1.Margin = new System.Windows.Forms.Padding(4);
            this.iaF_LabelSepertor1.Name = "iaF_LabelSepertor1";
            this.iaF_LabelSepertor1.PointDiamiter = 10;
            this.iaF_LabelSepertor1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.iaF_LabelSepertor1.Size = new System.Drawing.Size(378, 31);
            this.iaF_LabelSepertor1.TabIndex = 2;
            this.iaF_LabelSepertor1.TextSize = 10;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(213, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(109, 22);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 38);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "חיפוש שם:";
            // 
            // PersonalNumSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 444);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.iaF_LabelSepertor1);
            this.Controls.Add(this.Keepbtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonalNumSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "בחירת חייל מבצע";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Keepbtn;
        private MyControls.IAF_LabelSepertor iaF_LabelSepertor1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}