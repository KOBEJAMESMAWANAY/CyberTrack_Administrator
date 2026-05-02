namespace CyberTrack_Administrator
{
    partial class AllCases_Administrator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllCases_Administrator));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Select_Box = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CASE_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SEVERITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CATEGORY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORTER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ASSIGNED_TO = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.SLA_STATUS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.REPORTED_ON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ACTION = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label25 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox24 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.grbLogo_Administrator = new System.Windows.Forms.GroupBox();
            this.picCyberTrackLogo_Administrator = new System.Windows.Forms.PictureBox();
            this.lblIncidentManagementSystem_Administrator = new System.Windows.Forms.Label();
            this.lblCyberTrack_Administrator = new System.Windows.Forms.Label();
            this.grbPermissions_Administrator = new System.Windows.Forms.GroupBox();
            this.txtDelete_Administrator = new System.Windows.Forms.TextBox();
            this.txtUpdate_Administrator = new System.Windows.Forms.TextBox();
            this.txtCreate_Administrator = new System.Windows.Forms.TextBox();
            this.lblDelete_Administrator = new System.Windows.Forms.Label();
            this.lblUpdate_Administrator = new System.Windows.Forms.Label();
            this.lblCreate_Administrator = new System.Windows.Forms.Label();
            this.lblPermissions_Administrator = new System.Windows.Forms.Label();
            this.grbUserLogo_Administrator = new System.Windows.Forms.GroupBox();
            this.picUserPhoto_Administrator = new System.Windows.Forms.PictureBox();
            this.lblUserRole_Administrator = new System.Windows.Forms.Label();
            this.lblUserName_Administrator = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.grbLogo_Administrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCyberTrackLogo_Administrator)).BeginInit();
            this.grbPermissions_Administrator.SuspendLayout();
            this.grbUserLogo_Administrator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto_Administrator)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.dataGridView2);
            this.groupBox3.Controls.Add(this.label25);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.groupBox5);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.pictureBox4);
            this.groupBox3.Location = new System.Drawing.Point(12, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1260, 856);
            this.groupBox3.TabIndex = 40;
            this.groupBox3.TabStop = false;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select_Box,
            this.CASE_ID,
            this.Title,
            this.SEVERITY,
            this.STATUS,
            this.CATEGORY,
            this.REPORTER,
            this.ASSIGNED_TO,
            this.SLA_STATUS,
            this.REPORTED_ON,
            this.ACTION});
            this.dataGridView2.Location = new System.Drawing.Point(20, 239);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(1219, 598);
            this.dataGridView2.TabIndex = 70;
            // 
            // Select_Box
            // 
            this.Select_Box.HeaderText = "";
            this.Select_Box.Name = "Select_Box";
            this.Select_Box.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Select_Box.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Select_Box.Width = 107;
            // 
            // CASE_ID
            // 
            this.CASE_ID.HeaderText = "CASE ID";
            this.CASE_ID.Name = "CASE_ID";
            this.CASE_ID.ReadOnly = true;
            this.CASE_ID.Width = 107;
            // 
            // Title
            // 
            this.Title.HeaderText = "TITLE";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 107;
            // 
            // SEVERITY
            // 
            this.SEVERITY.HeaderText = "SEVERITY";
            this.SEVERITY.Name = "SEVERITY";
            this.SEVERITY.ReadOnly = true;
            this.SEVERITY.Width = 107;
            // 
            // STATUS
            // 
            this.STATUS.HeaderText = "STATUS";
            this.STATUS.Name = "STATUS";
            this.STATUS.ReadOnly = true;
            this.STATUS.Width = 107;
            // 
            // CATEGORY
            // 
            this.CATEGORY.HeaderText = "CATEGORY";
            this.CATEGORY.Name = "CATEGORY";
            this.CATEGORY.ReadOnly = true;
            this.CATEGORY.Width = 106;
            // 
            // REPORTER
            // 
            this.REPORTER.HeaderText = "REPORTER";
            this.REPORTER.Name = "REPORTER";
            this.REPORTER.ReadOnly = true;
            this.REPORTER.Width = 107;
            // 
            // ASSIGNED_TO
            // 
            this.ASSIGNED_TO.HeaderText = "ASSIGNED TO";
            this.ASSIGNED_TO.Name = "ASSIGNED_TO";
            this.ASSIGNED_TO.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ASSIGNED_TO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ASSIGNED_TO.Width = 107;
            // 
            // SLA_STATUS
            // 
            this.SLA_STATUS.HeaderText = "SLA STATUS";
            this.SLA_STATUS.Name = "SLA_STATUS";
            this.SLA_STATUS.ReadOnly = true;
            this.SLA_STATUS.Width = 107;
            // 
            // REPORTED_ON
            // 
            this.REPORTED_ON.HeaderText = "REPORTED ON";
            this.REPORTED_ON.Name = "REPORTED_ON";
            this.REPORTED_ON.ReadOnly = true;
            this.REPORTED_ON.Width = 107;
            // 
            // ACTION
            // 
            this.ACTION.HeaderText = "ACTION";
            this.ACTION.Name = "ACTION";
            this.ACTION.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ACTION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ACTION.Text = "MANAGE";
            this.ACTION.Width = 107;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(70, 56);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(84, 15);
            this.label25.TabIndex = 52;
            this.label25.Text = "N OF N Cases";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(1077, 29);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 42);
            this.button4.TabIndex = 51;
            this.button4.Text = "EXPORT";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label27);
            this.groupBox5.Controls.Add(this.label26);
            this.groupBox5.Controls.Add(this.pictureBox3);
            this.groupBox5.Controls.Add(this.comboBox3);
            this.groupBox5.Controls.Add(this.comboBox2);
            this.groupBox5.Controls.Add(this.comboBox1);
            this.groupBox5.Controls.Add(this.textBox24);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(20, 86);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1219, 136);
            this.groupBox5.TabIndex = 49;
            this.groupBox5.TabStop = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(933, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 16);
            this.label13.TabIndex = 58;
            this.label13.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(624, 79);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 57;
            this.label11.Text = "Status";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(15, 80);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 56;
            this.label12.Text = "Search";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(307, 79);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(64, 16);
            this.label27.TabIndex = 55;
            this.label27.Text = "Severity";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(15, 50);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(150, 15);
            this.label26.TabIndex = 54;
            this.label26.Text = "Filter and search incidents";
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "ALL CATEGORIES",
            "MALWARE",
            "PHISHING",
            "DATA BREACH",
            "UNAUTHORIZED ACCESS",
            "DDOS",
            "OTHER"});
            this.comboBox3.Location = new System.Drawing.Point(936, 98);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(261, 21);
            this.comboBox3.TabIndex = 27;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ALL STATUSES",
            "NEW",
            "INVESTIGATING",
            "CONTAINED",
            "RESOLVED",
            "CLOSED"});
            this.comboBox2.Location = new System.Drawing.Point(627, 98);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(261, 21);
            this.comboBox2.TabIndex = 26;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "ALL SEVERITIES",
            "CRITICAL",
            "HIGH",
            "MEDIUM",
            "LOW"});
            this.comboBox1.Location = new System.Drawing.Point(310, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(261, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // textBox24
            // 
            this.textBox24.Location = new System.Drawing.Point(18, 99);
            this.textBox24.Name = "textBox24";
            this.textBox24.Size = new System.Drawing.Size(247, 20);
            this.textBox24.TabIndex = 24;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(48, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(105, 25);
            this.label10.TabIndex = 19;
            this.label10.Text = "FILTERS";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(70, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(253, 18);
            this.label9.TabIndex = 48;
            this.label9.Text = "CASES MANAGEMENT - ADMIN";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(909, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 42);
            this.button1.TabIndex = 71;
            this.button1.Text = "DELETE";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.ErrorImage = null;
            this.pictureBox3.InitialImage = null;
            this.pictureBox3.Location = new System.Drawing.Point(18, 22);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 25);
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::CyberTrack_Administrator.Properties.Resources.CyberTrack_Icon;
            this.pictureBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox4.ErrorImage = null;
            this.pictureBox4.InitialImage = null;
            this.pictureBox4.Location = new System.Drawing.Point(20, 29);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 42);
            this.pictureBox4.TabIndex = 47;
            this.pictureBox4.TabStop = false;
            // 
            // grbLogo_Administrator
            // 
            this.grbLogo_Administrator.Controls.Add(this.picCyberTrackLogo_Administrator);
            this.grbLogo_Administrator.Controls.Add(this.lblIncidentManagementSystem_Administrator);
            this.grbLogo_Administrator.Controls.Add(this.lblCyberTrack_Administrator);
            this.grbLogo_Administrator.Location = new System.Drawing.Point(12, 12);
            this.grbLogo_Administrator.Name = "grbLogo_Administrator";
            this.grbLogo_Administrator.Size = new System.Drawing.Size(754, 74);
            this.grbLogo_Administrator.TabIndex = 95;
            this.grbLogo_Administrator.TabStop = false;
            // 
            // picCyberTrackLogo_Administrator
            // 
            this.picCyberTrackLogo_Administrator.Image = ((System.Drawing.Image)(resources.GetObject("picCyberTrackLogo_Administrator.Image")));
            this.picCyberTrackLogo_Administrator.Location = new System.Drawing.Point(6, 19);
            this.picCyberTrackLogo_Administrator.Name = "picCyberTrackLogo_Administrator";
            this.picCyberTrackLogo_Administrator.Size = new System.Drawing.Size(44, 42);
            this.picCyberTrackLogo_Administrator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCyberTrackLogo_Administrator.TabIndex = 25;
            this.picCyberTrackLogo_Administrator.TabStop = false;
            // 
            // lblIncidentManagementSystem_Administrator
            // 
            this.lblIncidentManagementSystem_Administrator.AutoSize = true;
            this.lblIncidentManagementSystem_Administrator.Location = new System.Drawing.Point(60, 47);
            this.lblIncidentManagementSystem_Administrator.Name = "lblIncidentManagementSystem_Administrator";
            this.lblIncidentManagementSystem_Administrator.Size = new System.Drawing.Size(150, 13);
            this.lblIncidentManagementSystem_Administrator.TabIndex = 27;
            this.lblIncidentManagementSystem_Administrator.Text = "Incident Management Systtem";
            // 
            // lblCyberTrack_Administrator
            // 
            this.lblCyberTrack_Administrator.AutoSize = true;
            this.lblCyberTrack_Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCyberTrack_Administrator.Location = new System.Drawing.Point(57, 19);
            this.lblCyberTrack_Administrator.Name = "lblCyberTrack_Administrator";
            this.lblCyberTrack_Administrator.Size = new System.Drawing.Size(119, 18);
            this.lblCyberTrack_Administrator.TabIndex = 26;
            this.lblCyberTrack_Administrator.Text = "CYBERTRACK";
            // 
            // grbPermissions_Administrator
            // 
            this.grbPermissions_Administrator.Controls.Add(this.txtDelete_Administrator);
            this.grbPermissions_Administrator.Controls.Add(this.txtUpdate_Administrator);
            this.grbPermissions_Administrator.Controls.Add(this.txtCreate_Administrator);
            this.grbPermissions_Administrator.Controls.Add(this.lblDelete_Administrator);
            this.grbPermissions_Administrator.Controls.Add(this.lblUpdate_Administrator);
            this.grbPermissions_Administrator.Controls.Add(this.lblCreate_Administrator);
            this.grbPermissions_Administrator.Controls.Add(this.lblPermissions_Administrator);
            this.grbPermissions_Administrator.Location = new System.Drawing.Point(772, 12);
            this.grbPermissions_Administrator.Name = "grbPermissions_Administrator";
            this.grbPermissions_Administrator.Size = new System.Drawing.Size(311, 74);
            this.grbPermissions_Administrator.TabIndex = 93;
            this.grbPermissions_Administrator.TabStop = false;
            // 
            // txtDelete_Administrator
            // 
            this.txtDelete_Administrator.Location = new System.Drawing.Point(257, 40);
            this.txtDelete_Administrator.Multiline = true;
            this.txtDelete_Administrator.Name = "txtDelete_Administrator";
            this.txtDelete_Administrator.ReadOnly = true;
            this.txtDelete_Administrator.Size = new System.Drawing.Size(47, 20);
            this.txtDelete_Administrator.TabIndex = 25;
            this.txtDelete_Administrator.Text = "YES";
            this.txtDelete_Administrator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUpdate_Administrator
            // 
            this.txtUpdate_Administrator.Location = new System.Drawing.Point(157, 40);
            this.txtUpdate_Administrator.Multiline = true;
            this.txtUpdate_Administrator.Name = "txtUpdate_Administrator";
            this.txtUpdate_Administrator.ReadOnly = true;
            this.txtUpdate_Administrator.Size = new System.Drawing.Size(47, 20);
            this.txtUpdate_Administrator.TabIndex = 24;
            this.txtUpdate_Administrator.Text = "YES";
            this.txtUpdate_Administrator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCreate_Administrator
            // 
            this.txtCreate_Administrator.Location = new System.Drawing.Point(51, 40);
            this.txtCreate_Administrator.Multiline = true;
            this.txtCreate_Administrator.Name = "txtCreate_Administrator";
            this.txtCreate_Administrator.ReadOnly = true;
            this.txtCreate_Administrator.Size = new System.Drawing.Size(47, 20);
            this.txtCreate_Administrator.TabIndex = 23;
            this.txtCreate_Administrator.Text = "YES";
            this.txtCreate_Administrator.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblDelete_Administrator
            // 
            this.lblDelete_Administrator.AutoSize = true;
            this.lblDelete_Administrator.Location = new System.Drawing.Point(210, 43);
            this.lblDelete_Administrator.Name = "lblDelete_Administrator";
            this.lblDelete_Administrator.Size = new System.Drawing.Size(41, 13);
            this.lblDelete_Administrator.TabIndex = 6;
            this.lblDelete_Administrator.Text = "Delete:";
            // 
            // lblUpdate_Administrator
            // 
            this.lblUpdate_Administrator.AutoSize = true;
            this.lblUpdate_Administrator.Location = new System.Drawing.Point(106, 43);
            this.lblUpdate_Administrator.Name = "lblUpdate_Administrator";
            this.lblUpdate_Administrator.Size = new System.Drawing.Size(45, 13);
            this.lblUpdate_Administrator.TabIndex = 5;
            this.lblUpdate_Administrator.Text = "Update:";
            // 
            // lblCreate_Administrator
            // 
            this.lblCreate_Administrator.AutoSize = true;
            this.lblCreate_Administrator.Location = new System.Drawing.Point(6, 43);
            this.lblCreate_Administrator.Name = "lblCreate_Administrator";
            this.lblCreate_Administrator.Size = new System.Drawing.Size(41, 13);
            this.lblCreate_Administrator.TabIndex = 4;
            this.lblCreate_Administrator.Text = "Create:";
            // 
            // lblPermissions_Administrator
            // 
            this.lblPermissions_Administrator.AutoSize = true;
            this.lblPermissions_Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermissions_Administrator.Location = new System.Drawing.Point(6, 16);
            this.lblPermissions_Administrator.Name = "lblPermissions_Administrator";
            this.lblPermissions_Administrator.Size = new System.Drawing.Size(92, 16);
            this.lblPermissions_Administrator.TabIndex = 4;
            this.lblPermissions_Administrator.Text = "Permissions";
            // 
            // grbUserLogo_Administrator
            // 
            this.grbUserLogo_Administrator.Controls.Add(this.picUserPhoto_Administrator);
            this.grbUserLogo_Administrator.Controls.Add(this.lblUserRole_Administrator);
            this.grbUserLogo_Administrator.Controls.Add(this.lblUserName_Administrator);
            this.grbUserLogo_Administrator.Location = new System.Drawing.Point(1089, 12);
            this.grbUserLogo_Administrator.Name = "grbUserLogo_Administrator";
            this.grbUserLogo_Administrator.Size = new System.Drawing.Size(183, 74);
            this.grbUserLogo_Administrator.TabIndex = 94;
            this.grbUserLogo_Administrator.TabStop = false;
            // 
            // picUserPhoto_Administrator
            // 
            this.picUserPhoto_Administrator.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picUserPhoto_Administrator.BackgroundImage")));
            this.picUserPhoto_Administrator.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picUserPhoto_Administrator.ErrorImage = null;
            this.picUserPhoto_Administrator.InitialImage = null;
            this.picUserPhoto_Administrator.Location = new System.Drawing.Point(11, 19);
            this.picUserPhoto_Administrator.Name = "picUserPhoto_Administrator";
            this.picUserPhoto_Administrator.Size = new System.Drawing.Size(44, 42);
            this.picUserPhoto_Administrator.TabIndex = 5;
            this.picUserPhoto_Administrator.TabStop = false;
            // 
            // lblUserRole_Administrator
            // 
            this.lblUserRole_Administrator.AutoSize = true;
            this.lblUserRole_Administrator.Location = new System.Drawing.Point(71, 47);
            this.lblUserRole_Administrator.Name = "lblUserRole_Administrator";
            this.lblUserRole_Administrator.Size = new System.Drawing.Size(42, 13);
            this.lblUserRole_Administrator.TabIndex = 5;
            this.lblUserRole_Administrator.Text = "ADMIN";
            // 
            // lblUserName_Administrator
            // 
            this.lblUserName_Administrator.AutoSize = true;
            this.lblUserName_Administrator.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName_Administrator.Location = new System.Drawing.Point(71, 19);
            this.lblUserName_Administrator.Name = "lblUserName_Administrator";
            this.lblUserName_Administrator.Size = new System.Drawing.Size(99, 16);
            this.lblUserName_Administrator.TabIndex = 5;
            this.lblUserName_Administrator.Text = "Skibidi Toilet";
            // 
            // AllCases_Administrator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 961);
            this.Controls.Add(this.grbLogo_Administrator);
            this.Controls.Add(this.grbPermissions_Administrator);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbUserLogo_Administrator);
            this.Name = "AllCases_Administrator";
            this.Text = "AllCases_Administrator";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.grbLogo_Administrator.ResumeLayout(false);
            this.grbLogo_Administrator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCyberTrackLogo_Administrator)).EndInit();
            this.grbPermissions_Administrator.ResumeLayout(false);
            this.grbPermissions_Administrator.PerformLayout();
            this.grbUserLogo_Administrator.ResumeLayout(false);
            this.grbUserLogo_Administrator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUserPhoto_Administrator)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox24;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select_Box;
        private System.Windows.Forms.DataGridViewTextBoxColumn CASE_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn SEVERITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn CATEGORY;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTER;
        private System.Windows.Forms.DataGridViewComboBoxColumn ASSIGNED_TO;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLA_STATUS;
        private System.Windows.Forms.DataGridViewTextBoxColumn REPORTED_ON;
        private System.Windows.Forms.DataGridViewButtonColumn ACTION;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox grbLogo_Administrator;
        private System.Windows.Forms.PictureBox picCyberTrackLogo_Administrator;
        private System.Windows.Forms.Label lblIncidentManagementSystem_Administrator;
        private System.Windows.Forms.Label lblCyberTrack_Administrator;
        private System.Windows.Forms.GroupBox grbPermissions_Administrator;
        private System.Windows.Forms.TextBox txtDelete_Administrator;
        private System.Windows.Forms.TextBox txtUpdate_Administrator;
        private System.Windows.Forms.TextBox txtCreate_Administrator;
        private System.Windows.Forms.Label lblDelete_Administrator;
        private System.Windows.Forms.Label lblUpdate_Administrator;
        private System.Windows.Forms.Label lblCreate_Administrator;
        private System.Windows.Forms.Label lblPermissions_Administrator;
        private System.Windows.Forms.GroupBox grbUserLogo_Administrator;
        private System.Windows.Forms.PictureBox picUserPhoto_Administrator;
        private System.Windows.Forms.Label lblUserRole_Administrator;
        private System.Windows.Forms.Label lblUserName_Administrator;
    }
}