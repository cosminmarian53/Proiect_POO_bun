﻿namespace Proiect_POO_bun
{
    partial class MainAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAppForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.AccesLevelLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.ModifyDatabase = new System.Windows.Forms.ToolStrip();
            this.MainToolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.MateriiButton = new System.Windows.Forms.ToolStripButton();
            this.StudentiButton = new System.Windows.Forms.ToolStripButton();
            this.ProgrameButton = new System.Windows.Forms.ToolStripButton();
            this.Users = new System.Windows.Forms.ToolStripButton();
            this.Catalog = new System.Windows.Forms.ToolStripButton();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.ModifyDatabase.SuspendLayout();
            this.MainToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.AccesLevelLabel);
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.MainToolStrip);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(800, 450);
            this.MainPanel.TabIndex = 0;
            // 
            // AccesLevelLabel
            // 
            this.AccesLevelLabel.AutoSize = true;
            this.AccesLevelLabel.Font = new System.Drawing.Font("UT Sans Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccesLevelLabel.Location = new System.Drawing.Point(-6, -5);
            this.AccesLevelLabel.Name = "AccesLevelLabel";
            this.AccesLevelLabel.Padding = new System.Windows.Forms.Padding(0, 6, 0, 0);
            this.AccesLevelLabel.Size = new System.Drawing.Size(131, 37);
            this.AccesLevelLabel.TabIndex = 3;
            this.AccesLevelLabel.Text = "Acces Level: 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.dataGrid);
            this.panel1.Controls.Add(this.ModifyDatabase);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 406);
            this.panel1.TabIndex = 2;
            // 
            // dataGrid
            // 
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.Location = new System.Drawing.Point(186, 0);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersWidth = 51;
            this.dataGrid.RowTemplate.Height = 24;
            this.dataGrid.Size = new System.Drawing.Size(614, 406);
            this.dataGrid.TabIndex = 2;
            // 
            // ModifyDatabase
            // 
            this.ModifyDatabase.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ModifyDatabase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ModifyDatabase.Dock = System.Windows.Forms.DockStyle.Left;
            this.ModifyDatabase.Font = new System.Drawing.Font("UT Sans Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyDatabase.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ModifyDatabase.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ModifyDatabase.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.Catalog});
            this.ModifyDatabase.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.ModifyDatabase.Location = new System.Drawing.Point(0, 0);
            this.ModifyDatabase.Name = "ModifyDatabase";
            this.ModifyDatabase.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ModifyDatabase.Size = new System.Drawing.Size(186, 406);
            this.ModifyDatabase.TabIndex = 1;
            this.ModifyDatabase.Text = "toolStrip1";
            // 
            // MainToolStrip
            // 
            this.MainToolStrip.AllowMerge = false;
            this.MainToolStrip.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.MainToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.MainToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MateriiButton,
            this.StudentiButton,
            this.ProgrameButton,
            this.Users});
            this.MainToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MainToolStrip.Name = "MainToolStrip";
            this.MainToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainToolStrip.Size = new System.Drawing.Size(800, 44);
            this.MainToolStrip.TabIndex = 0;
            this.MainToolStrip.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.ForeColor = System.Drawing.Color.Black;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(183, 39);
            this.toolStripButton3.Text = "Adaugă";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(183, 39);
            this.toolStripButton4.Text = "Șterge";
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(183, 39);
            this.toolStripButton5.Text = "Modifică";
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // MateriiButton
            // 
            this.MateriiButton.CheckOnClick = true;
            this.MateriiButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.MateriiButton.Font = new System.Drawing.Font("UT Sans Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MateriiButton.Image = ((System.Drawing.Image)(resources.GetObject("MateriiButton.Image")));
            this.MateriiButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MateriiButton.Margin = new System.Windows.Forms.Padding(0, 3, 0, 2);
            this.MateriiButton.Name = "MateriiButton";
            this.MateriiButton.Size = new System.Drawing.Size(91, 39);
            this.MateriiButton.Text = "Materii";
            this.MateriiButton.Click += new System.EventHandler(this.MateriiButton_Click);
            // 
            // StudentiButton
            // 
            this.StudentiButton.CheckOnClick = true;
            this.StudentiButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.StudentiButton.Font = new System.Drawing.Font("UT Sans Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentiButton.Image = ((System.Drawing.Image)(resources.GetObject("StudentiButton.Image")));
            this.StudentiButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.StudentiButton.Name = "StudentiButton";
            this.StudentiButton.Size = new System.Drawing.Size(102, 41);
            this.StudentiButton.Text = "Studenți";
            this.StudentiButton.Click += new System.EventHandler(this.StudentiButton_Click);
            // 
            // ProgrameButton
            // 
            this.ProgrameButton.CheckOnClick = true;
            this.ProgrameButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProgrameButton.Font = new System.Drawing.Font("UT Sans Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgrameButton.Image = ((System.Drawing.Image)(resources.GetObject("ProgrameButton.Image")));
            this.ProgrameButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProgrameButton.Name = "ProgrameButton";
            this.ProgrameButton.Size = new System.Drawing.Size(116, 41);
            this.ProgrameButton.Text = "Programe";
            this.ProgrameButton.ToolTipText = "Programe";
            this.ProgrameButton.Click += new System.EventHandler(this.ProgrameButton_Click);
            // 
            // Users
            // 
            this.Users.CheckOnClick = true;
            this.Users.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Users.Font = new System.Drawing.Font("UT Sans Medium", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Users.Image = ((System.Drawing.Image)(resources.GetObject("Users.Image")));
            this.Users.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(116, 41);
            this.Users.Text = "Utilizatori";
            this.Users.ToolTipText = "Programe";
            this.Users.Click += new System.EventHandler(this.Users_Click);
            // 
            // Catalog
            // 
            this.Catalog.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Catalog.Image = ((System.Drawing.Image)(resources.GetObject("Catalog.Image")));
            this.Catalog.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Catalog.Name = "Catalog";
            this.Catalog.Size = new System.Drawing.Size(183, 39);
            this.Catalog.Text = "Generare Catalog";
            this.Catalog.Click += new System.EventHandler(this.Catalog_Click);
            // 
            // MainAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAppForm";
            this.Text = "UniCatalog";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ModifyDatabase.ResumeLayout(false);
            this.ModifyDatabase.PerformLayout();
            this.MainToolStrip.ResumeLayout(false);
            this.MainToolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStrip MainToolStrip;
        private System.Windows.Forms.ToolStripButton StudentiButton;
        private System.Windows.Forms.ToolStripButton MateriiButton;
        private System.Windows.Forms.ToolStripButton Users;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip ModifyDatabase;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Label AccesLevelLabel;
        private System.Windows.Forms.ToolStripButton ProgrameButton;
        private System.Windows.Forms.ToolStripButton Catalog;
    }
}