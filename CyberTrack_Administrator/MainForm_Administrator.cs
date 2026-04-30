using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CyberTrack_Administrator
{
    public partial class MainForm_Administrator : Form
    {
        public MainForm_Administrator()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard_Administrator newMDIChild = new Dashboard_Administrator();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void submitAReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SubmitReport_Administrator newMDIChild = new SubmitReport_Administrator();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void auditLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuditLogs_Administrator newMDIChild = new AuditLogs_Administrator();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void adminPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AdminPanel_Administrator newMDIChild = new AdminPanel_Administrator();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }

        private void allCasesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AllCases_Administrator newMDIChild = new AllCases_Administrator();
            newMDIChild.MdiParent = this;
            newMDIChild.Show();
        }
    }
}
