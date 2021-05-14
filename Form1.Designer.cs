﻿namespace FinalProjectForm
{
    partial class WorkManger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkManger));
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.TaskBTN = new System.Windows.Forms.Button();
            this.WorkMangBTN = new System.Windows.Forms.Button();
            this.EquipmentBTN = new System.Windows.Forms.Button();
            this.LogisticBTN = new System.Windows.Forms.Button();
            this.HRbtn = new System.Windows.Forms.Button();
            this.ReportBTN = new System.Windows.Forms.Button();
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.LbTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.PanelMenu.SuspendLayout();
            this.TitlePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.PanelMenu.Controls.Add(this.ReportBTN);
            this.PanelMenu.Controls.Add(this.HRbtn);
            this.PanelMenu.Controls.Add(this.LogisticBTN);
            this.PanelMenu.Controls.Add(this.EquipmentBTN);
            this.PanelMenu.Controls.Add(this.WorkMangBTN);
            this.PanelMenu.Controls.Add(this.TaskBTN);
            this.PanelMenu.Controls.Add(this.PanelLogo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelMenu.Location = new System.Drawing.Point(580, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 450);
            this.PanelMenu.TabIndex = 0;
            // 
            // PanelLogo
            // 
            this.PanelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.PanelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("PanelLogo.BackgroundImage")));
            this.PanelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(220, 80);
            this.PanelLogo.TabIndex = 0;
            // 
            // TaskBTN
            // 
            this.TaskBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.TaskBTN.FlatAppearance.BorderSize = 0;
            this.TaskBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TaskBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.TaskBTN.Image = ((System.Drawing.Image)(resources.GetObject("TaskBTN.Image")));
            this.TaskBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaskBTN.Location = new System.Drawing.Point(0, 80);
            this.TaskBTN.Name = "TaskBTN";
            this.TaskBTN.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.TaskBTN.Size = new System.Drawing.Size(220, 60);
            this.TaskBTN.TabIndex = 1;
            this.TaskBTN.Text = "מטלות   ";
            this.TaskBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.TaskBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.TaskBTN.UseVisualStyleBackColor = true;
            this.TaskBTN.Click += new System.EventHandler(this.TaskBTN_Click);
            // 
            // WorkMangBTN
            // 
            this.WorkMangBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.WorkMangBTN.FlatAppearance.BorderSize = 0;
            this.WorkMangBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WorkMangBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.WorkMangBTN.Image = ((System.Drawing.Image)(resources.GetObject("WorkMangBTN.Image")));
            this.WorkMangBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkMangBTN.Location = new System.Drawing.Point(0, 140);
            this.WorkMangBTN.Name = "WorkMangBTN";
            this.WorkMangBTN.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.WorkMangBTN.Size = new System.Drawing.Size(220, 60);
            this.WorkMangBTN.TabIndex = 2;
            this.WorkMangBTN.Text = "רצפת עבודה   ";
            this.WorkMangBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.WorkMangBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.WorkMangBTN.UseVisualStyleBackColor = true;
            this.WorkMangBTN.Click += new System.EventHandler(this.WorkMangBTN_Click);
            // 
            // EquipmentBTN
            // 
            this.EquipmentBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.EquipmentBTN.FlatAppearance.BorderSize = 0;
            this.EquipmentBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EquipmentBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.EquipmentBTN.Image = ((System.Drawing.Image)(resources.GetObject("EquipmentBTN.Image")));
            this.EquipmentBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EquipmentBTN.Location = new System.Drawing.Point(0, 200);
            this.EquipmentBTN.Name = "EquipmentBTN";
            this.EquipmentBTN.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.EquipmentBTN.Size = new System.Drawing.Size(220, 60);
            this.EquipmentBTN.TabIndex = 3;
            this.EquipmentBTN.Text = "ציוד   ";
            this.EquipmentBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.EquipmentBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.EquipmentBTN.UseVisualStyleBackColor = true;
            this.EquipmentBTN.Click += new System.EventHandler(this.EquipmentBTN_Click);
            // 
            // LogisticBTN
            // 
            this.LogisticBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogisticBTN.FlatAppearance.BorderSize = 0;
            this.LogisticBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogisticBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.LogisticBTN.Image = ((System.Drawing.Image)(resources.GetObject("LogisticBTN.Image")));
            this.LogisticBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogisticBTN.Location = new System.Drawing.Point(0, 260);
            this.LogisticBTN.Name = "LogisticBTN";
            this.LogisticBTN.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.LogisticBTN.Size = new System.Drawing.Size(220, 60);
            this.LogisticBTN.TabIndex = 4;
            this.LogisticBTN.Text = "לוגיסטיקה   ";
            this.LogisticBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LogisticBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.LogisticBTN.UseVisualStyleBackColor = true;
            this.LogisticBTN.Click += new System.EventHandler(this.LogisticBTN_Click);
            // 
            // HRbtn
            // 
            this.HRbtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.HRbtn.FlatAppearance.BorderSize = 0;
            this.HRbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HRbtn.ForeColor = System.Drawing.Color.Gainsboro;
            this.HRbtn.Image = ((System.Drawing.Image)(resources.GetObject("HRbtn.Image")));
            this.HRbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HRbtn.Location = new System.Drawing.Point(0, 320);
            this.HRbtn.Name = "HRbtn";
            this.HRbtn.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.HRbtn.Size = new System.Drawing.Size(220, 60);
            this.HRbtn.TabIndex = 5;
            this.HRbtn.Text = "כח אדם   ";
            this.HRbtn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.HRbtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.HRbtn.UseVisualStyleBackColor = true;
            this.HRbtn.Click += new System.EventHandler(this.HRbtn_Click);
            // 
            // ReportBTN
            // 
            this.ReportBTN.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReportBTN.FlatAppearance.BorderSize = 0;
            this.ReportBTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportBTN.ForeColor = System.Drawing.Color.Gainsboro;
            this.ReportBTN.Image = ((System.Drawing.Image)(resources.GetObject("ReportBTN.Image")));
            this.ReportBTN.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportBTN.Location = new System.Drawing.Point(0, 380);
            this.ReportBTN.Name = "ReportBTN";
            this.ReportBTN.Padding = new System.Windows.Forms.Padding(0, 0, 12, 0);
            this.ReportBTN.Size = new System.Drawing.Size(220, 60);
            this.ReportBTN.TabIndex = 6;
            this.ReportBTN.Text = "דוחות   ";
            this.ReportBTN.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ReportBTN.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.ReportBTN.UseVisualStyleBackColor = true;
            this.ReportBTN.Click += new System.EventHandler(this.ReportBTN_Click);
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.TitlePanel.Controls.Add(this.LbTitle);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(580, 80);
            this.TitlePanel.TabIndex = 1;
            // 
            // LbTitle
            // 
            this.LbTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.LbTitle.AutoSize = true;
            this.LbTitle.Font = new System.Drawing.Font("Montserrat", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LbTitle.ForeColor = System.Drawing.Color.White;
            this.LbTitle.Location = new System.Drawing.Point(236, 26);
            this.LbTitle.Name = "LbTitle";
            this.LbTitle.Size = new System.Drawing.Size(56, 25);
            this.LbTitle.TabIndex = 0;
            this.LbTitle.Text = "ראשי";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(0, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(580, 370);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // WorkManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.PanelMenu);
            this.Name = "WorkManger";
            this.Text = "WorkManger";
            this.PanelMenu.ResumeLayout(false);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Button ReportBTN;
        private System.Windows.Forms.Button HRbtn;
        private System.Windows.Forms.Button LogisticBTN;
        private System.Windows.Forms.Button EquipmentBTN;
        private System.Windows.Forms.Button WorkMangBTN;
        private System.Windows.Forms.Button TaskBTN;
        private System.Windows.Forms.Panel PanelLogo;
        private System.Windows.Forms.Panel TitlePanel;
        private System.Windows.Forms.Label LbTitle;
        private System.Windows.Forms.Panel panelDesktopPanel;
    }
}

