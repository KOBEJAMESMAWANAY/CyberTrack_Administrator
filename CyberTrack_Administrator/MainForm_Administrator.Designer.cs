namespace CyberTrack_Administrator
{
    partial class MainForm_Administrator
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
            this.menuStrip1_Administrator = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.submitAReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.auditLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1_Administrator.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1_Administrator
            // 
            this.menuStrip1_Administrator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.submitAReportToolStripMenuItem,
            this.allCasesToolStripMenuItem,
            this.auditLogsToolStripMenuItem,
            this.adminPanelToolStripMenuItem});
            this.menuStrip1_Administrator.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1_Administrator.Name = "menuStrip1_Administrator";
            this.menuStrip1_Administrator.Size = new System.Drawing.Size(1584, 38);
            this.menuStrip1_Administrator.TabIndex = 1;
            this.menuStrip1_Administrator.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(131, 34);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // submitAReportToolStripMenuItem
            // 
            this.submitAReportToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitAReportToolStripMenuItem.Name = "submitAReportToolStripMenuItem";
            this.submitAReportToolStripMenuItem.Size = new System.Drawing.Size(169, 34);
            this.submitAReportToolStripMenuItem.Text = "Submit Report";
            this.submitAReportToolStripMenuItem.Click += new System.EventHandler(this.submitAReportToolStripMenuItem_Click);
            // 
            // allCasesToolStripMenuItem
            // 
            this.allCasesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCasesToolStripMenuItem.Name = "allCasesToolStripMenuItem";
            this.allCasesToolStripMenuItem.Size = new System.Drawing.Size(111, 34);
            this.allCasesToolStripMenuItem.Text = "All Cases";
            this.allCasesToolStripMenuItem.Click += new System.EventHandler(this.allCasesToolStripMenuItem_Click_1);
            // 
            // auditLogsToolStripMenuItem
            // 
            this.auditLogsToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.auditLogsToolStripMenuItem.Name = "auditLogsToolStripMenuItem";
            this.auditLogsToolStripMenuItem.Size = new System.Drawing.Size(132, 34);
            this.auditLogsToolStripMenuItem.Text = "Audit Logs";
            this.auditLogsToolStripMenuItem.Click += new System.EventHandler(this.auditLogsToolStripMenuItem_Click);
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(150, 34);
            this.adminPanelToolStripMenuItem.Text = "Admin Panel";
            this.adminPanelToolStripMenuItem.Click += new System.EventHandler(this.adminPanelToolStripMenuItem_Click);
            // 
            // MainForm_Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 961);
            this.Controls.Add(this.menuStrip1_Administrator);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1_Administrator;
            this.Name = "MainForm_Administrator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm_Administrator";
            this.menuStrip1_Administrator.ResumeLayout(false);
            this.menuStrip1_Administrator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1_Administrator;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem submitAReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem auditLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
    }
}