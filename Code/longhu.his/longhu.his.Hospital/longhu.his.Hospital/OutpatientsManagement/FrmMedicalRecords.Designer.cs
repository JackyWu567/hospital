namespace longhu.his.Hospital.OutpatientsManagement
{
    partial class FrmMedicalRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMedicalRecords));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.门诊医生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.处方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPatients = new System.Windows.Forms.DataGridView();
            this.pNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStatusBar = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblSystemUserName = new System.Windows.Forms.Label();
            this.lblSystemUser = new System.Windows.Forms.Label();
            this.lblSystemDateDisplay = new System.Windows.Forms.Label();
            this.lblSystemDate = new System.Windows.Forms.Label();
            this.gbPatientBasicInfo = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFirstDate = new System.Windows.Forms.TextBox();
            this.cbDoctor = new System.Windows.Forms.ComboBox();
            this.lblDoctor = new System.Windows.Forms.Label();
            this.cbDepartment = new System.Windows.Forms.ComboBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbGender = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.gbMedicalRecords = new System.Windows.Forms.GroupBox();
            this.cblCheck = new System.Windows.Forms.CheckedListBox();
            this.txtDoctorAdvice = new System.Windows.Forms.TextBox();
            this.txtJudgement = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbPrescription = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAlwaysUsedPrescription = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddDrug = new System.Windows.Forms.Button();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDrugMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbDrugQuantity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDrugMethod = new System.Windows.Forms.TextBox();
            this.btnSaveMedicalRecord = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnPrintPrescription = new System.Windows.Forms.Button();
            this.btnPrintMedicalRecord = new System.Windows.Forms.Button();
            this.gbPrescriptionList = new System.Windows.Forms.GroupBox();
            this.dgvPrescriptionList = new System.Windows.Forms.DataGridView();
            this.pPrescriptionNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pPrescriptionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbPatients = new System.Windows.Forms.GroupBox();
            this.btnSavePrescription = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).BeginInit();
            this.gbStatusBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.gbPatientBasicInfo.SuspendLayout();
            this.gbMedicalRecords.SuspendLayout();
            this.gbPrescription.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            this.gbPrescriptionList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionList)).BeginInit();
            this.gbPatients.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.门诊医生ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 门诊医生ToolStripMenuItem
            // 
            this.门诊医生ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.病历ToolStripMenuItem,
            this.处方ToolStripMenuItem});
            this.门诊医生ToolStripMenuItem.Name = "门诊医生ToolStripMenuItem";
            this.门诊医生ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.门诊医生ToolStripMenuItem.Text = "门诊医生";
            // 
            // 病历ToolStripMenuItem
            // 
            this.病历ToolStripMenuItem.Name = "病历ToolStripMenuItem";
            this.病历ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.病历ToolStripMenuItem.Text = "病历";
            // 
            // 处方ToolStripMenuItem
            // 
            this.处方ToolStripMenuItem.Name = "处方ToolStripMenuItem";
            this.处方ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.处方ToolStripMenuItem.Text = "处方";
            this.处方ToolStripMenuItem.Click += new System.EventHandler(this.处方ToolStripMenuItem_Click);
            // 
            // dgvPatients
            // 
            this.dgvPatients.AllowUserToAddRows = false;
            this.dgvPatients.AllowUserToDeleteRows = false;
            this.dgvPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pNO,
            this.pName,
            this.pGender});
            this.dgvPatients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPatients.Location = new System.Drawing.Point(3, 17);
            this.dgvPatients.MultiSelect = false;
            this.dgvPatients.Name = "dgvPatients";
            this.dgvPatients.ReadOnly = true;
            this.dgvPatients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatients.Size = new System.Drawing.Size(210, 261);
            this.dgvPatients.TabIndex = 0;
            this.dgvPatients.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatients_CellClick);
            // 
            // pNO
            // 
            this.pNO.DataPropertyName = "ID";
            this.pNO.HeaderText = "序号";
            this.pNO.Name = "pNO";
            this.pNO.ReadOnly = true;
            this.pNO.Width = 40;
            // 
            // pName
            // 
            this.pName.DataPropertyName = "Name";
            this.pName.HeaderText = "姓名";
            this.pName.Name = "pName";
            this.pName.ReadOnly = true;
            this.pName.Width = 65;
            // 
            // pGender
            // 
            this.pGender.DataPropertyName = "Gender";
            this.pGender.HeaderText = "性别";
            this.pGender.Name = "pGender";
            this.pGender.ReadOnly = true;
            this.pGender.Width = 60;
            // 
            // gbStatusBar
            // 
            this.gbStatusBar.Controls.Add(this.splitContainer1);
            this.gbStatusBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbStatusBar.Location = new System.Drawing.Point(0, 626);
            this.gbStatusBar.Name = "gbStatusBar";
            this.gbStatusBar.Size = new System.Drawing.Size(1008, 47);
            this.gbStatusBar.TabIndex = 2;
            this.gbStatusBar.TabStop = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 17);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblSystemUserName);
            this.splitContainer1.Panel1.Controls.Add(this.lblSystemUser);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblSystemDateDisplay);
            this.splitContainer1.Panel2.Controls.Add(this.lblSystemDate);
            this.splitContainer1.Size = new System.Drawing.Size(1002, 27);
            this.splitContainer1.SplitterDistance = 604;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblSystemUserName
            // 
            this.lblSystemUserName.AutoSize = true;
            this.lblSystemUserName.Location = new System.Drawing.Point(99, 8);
            this.lblSystemUserName.Name = "lblSystemUserName";
            this.lblSystemUserName.Size = new System.Drawing.Size(41, 12);
            this.lblSystemUserName.TabIndex = 1;
            this.lblSystemUserName.Text = "侯亮平";
            // 
            // lblSystemUser
            // 
            this.lblSystemUser.AutoSize = true;
            this.lblSystemUser.Location = new System.Drawing.Point(26, 8);
            this.lblSystemUser.Name = "lblSystemUser";
            this.lblSystemUser.Size = new System.Drawing.Size(65, 12);
            this.lblSystemUser.TabIndex = 0;
            this.lblSystemUser.Text = "系统用户：";
            // 
            // lblSystemDateDisplay
            // 
            this.lblSystemDateDisplay.AutoSize = true;
            this.lblSystemDateDisplay.Location = new System.Drawing.Point(305, 9);
            this.lblSystemDateDisplay.Name = "lblSystemDateDisplay";
            this.lblSystemDateDisplay.Size = new System.Drawing.Size(65, 12);
            this.lblSystemDateDisplay.TabIndex = 1;
            this.lblSystemDateDisplay.Text = "2017-04-22";
            // 
            // lblSystemDate
            // 
            this.lblSystemDate.AutoSize = true;
            this.lblSystemDate.Location = new System.Drawing.Point(257, 9);
            this.lblSystemDate.Name = "lblSystemDate";
            this.lblSystemDate.Size = new System.Drawing.Size(41, 12);
            this.lblSystemDate.TabIndex = 0;
            this.lblSystemDate.Text = "日期：";
            // 
            // gbPatientBasicInfo
            // 
            this.gbPatientBasicInfo.Controls.Add(this.label2);
            this.gbPatientBasicInfo.Controls.Add(this.txtFirstDate);
            this.gbPatientBasicInfo.Controls.Add(this.cbDoctor);
            this.gbPatientBasicInfo.Controls.Add(this.lblDoctor);
            this.gbPatientBasicInfo.Controls.Add(this.cbDepartment);
            this.gbPatientBasicInfo.Controls.Add(this.lblDepartment);
            this.gbPatientBasicInfo.Controls.Add(this.cbGender);
            this.gbPatientBasicInfo.Controls.Add(this.label1);
            this.gbPatientBasicInfo.Controls.Add(this.txtAge);
            this.gbPatientBasicInfo.Controls.Add(this.lblGender);
            this.gbPatientBasicInfo.Controls.Add(this.txtPatientName);
            this.gbPatientBasicInfo.Controls.Add(this.lblName);
            this.gbPatientBasicInfo.Location = new System.Drawing.Point(225, 26);
            this.gbPatientBasicInfo.Name = "gbPatientBasicInfo";
            this.gbPatientBasicInfo.Size = new System.Drawing.Size(771, 99);
            this.gbPatientBasicInfo.TabIndex = 3;
            this.gbPatientBasicInfo.TabStop = false;
            this.gbPatientBasicInfo.Text = "病人基本信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "初诊日期：";
            // 
            // txtFirstDate
            // 
            this.txtFirstDate.Enabled = false;
            this.txtFirstDate.Location = new System.Drawing.Point(579, 63);
            this.txtFirstDate.Name = "txtFirstDate";
            this.txtFirstDate.Size = new System.Drawing.Size(176, 21);
            this.txtFirstDate.TabIndex = 10;
            // 
            // cbDoctor
            // 
            this.cbDoctor.Enabled = false;
            this.cbDoctor.FormattingEnabled = true;
            this.cbDoctor.Location = new System.Drawing.Point(286, 63);
            this.cbDoctor.Name = "cbDoctor";
            this.cbDoctor.Size = new System.Drawing.Size(190, 20);
            this.cbDoctor.TabIndex = 9;
            // 
            // lblDoctor
            // 
            this.lblDoctor.AutoSize = true;
            this.lblDoctor.Location = new System.Drawing.Point(237, 66);
            this.lblDoctor.Name = "lblDoctor";
            this.lblDoctor.Size = new System.Drawing.Size(41, 12);
            this.lblDoctor.TabIndex = 8;
            this.lblDoctor.Text = "医师：";
            // 
            // cbDepartment
            // 
            this.cbDepartment.Enabled = false;
            this.cbDepartment.FormattingEnabled = true;
            this.cbDepartment.Location = new System.Drawing.Point(56, 63);
            this.cbDepartment.Name = "cbDepartment";
            this.cbDepartment.Size = new System.Drawing.Size(159, 20);
            this.cbDepartment.TabIndex = 7;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(10, 66);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(41, 12);
            this.lblDepartment.TabIndex = 6;
            this.lblDepartment.Text = "科室：";
            // 
            // cbGender
            // 
            this.cbGender.Enabled = false;
            this.cbGender.FormattingEnabled = true;
            this.cbGender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbGender.Location = new System.Drawing.Point(286, 24);
            this.cbGender.Name = "cbGender";
            this.cbGender.Size = new System.Drawing.Size(190, 20);
            this.cbGender.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(530, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "年龄：";
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(579, 25);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(176, 21);
            this.txtAge.TabIndex = 3;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(237, 27);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(41, 12);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "性别：";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Enabled = false;
            this.txtPatientName.Location = new System.Drawing.Point(56, 24);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(159, 21);
            this.txtPatientName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(10, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名：";
            // 
            // gbMedicalRecords
            // 
            this.gbMedicalRecords.Controls.Add(this.cblCheck);
            this.gbMedicalRecords.Controls.Add(this.txtDoctorAdvice);
            this.gbMedicalRecords.Controls.Add(this.txtJudgement);
            this.gbMedicalRecords.Controls.Add(this.label5);
            this.gbMedicalRecords.Controls.Add(this.label4);
            this.gbMedicalRecords.Controls.Add(this.label3);
            this.gbMedicalRecords.Location = new System.Drawing.Point(225, 130);
            this.gbMedicalRecords.Name = "gbMedicalRecords";
            this.gbMedicalRecords.Size = new System.Drawing.Size(771, 138);
            this.gbMedicalRecords.TabIndex = 4;
            this.gbMedicalRecords.TabStop = false;
            this.gbMedicalRecords.Text = "患者病历";
            // 
            // cblCheck
            // 
            this.cblCheck.CheckOnClick = true;
            this.cblCheck.FormattingEnabled = true;
            this.cblCheck.Items.AddRange(new object[] {
            "血常规",
            "尿常规",
            "肝功五项",
            "胸透"});
            this.cblCheck.Location = new System.Drawing.Point(544, 18);
            this.cblCheck.Name = "cblCheck";
            this.cblCheck.Size = new System.Drawing.Size(211, 100);
            this.cblCheck.TabIndex = 5;
            // 
            // txtDoctorAdvice
            // 
            this.txtDoctorAdvice.Location = new System.Drawing.Point(56, 73);
            this.txtDoctorAdvice.Multiline = true;
            this.txtDoctorAdvice.Name = "txtDoctorAdvice";
            this.txtDoctorAdvice.Size = new System.Drawing.Size(420, 46);
            this.txtDoctorAdvice.TabIndex = 4;
            // 
            // txtJudgement
            // 
            this.txtJudgement.Location = new System.Drawing.Point(56, 18);
            this.txtJudgement.Multiline = true;
            this.txtJudgement.Name = "txtJudgement";
            this.txtJudgement.Size = new System.Drawing.Size(420, 46);
            this.txtJudgement.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "医嘱：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "检查：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "诊断：";
            // 
            // gbPrescription
            // 
            this.gbPrescription.Controls.Add(this.textBox1);
            this.gbPrescription.Controls.Add(this.lblAlwaysUsedPrescription);
            this.gbPrescription.Controls.Add(this.label7);
            this.gbPrescription.Controls.Add(this.btnAddDrug);
            this.gbPrescription.Controls.Add(this.txtDrugName);
            this.gbPrescription.Controls.Add(this.dgvPrescription);
            this.gbPrescription.Controls.Add(this.cbDrugQuantity);
            this.gbPrescription.Controls.Add(this.label6);
            this.gbPrescription.Controls.Add(this.label8);
            this.gbPrescription.Controls.Add(this.txtDrugMethod);
            this.gbPrescription.Location = new System.Drawing.Point(226, 274);
            this.gbPrescription.Name = "gbPrescription";
            this.gbPrescription.Size = new System.Drawing.Size(770, 308);
            this.gbPrescription.TabIndex = 5;
            this.gbPrescription.TabStop = false;
            this.gbPrescription.Text = "处方";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(96, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 21);
            this.textBox1.TabIndex = 15;
            // 
            // lblAlwaysUsedPrescription
            // 
            this.lblAlwaysUsedPrescription.AutoSize = true;
            this.lblAlwaysUsedPrescription.Location = new System.Drawing.Point(17, 53);
            this.lblAlwaysUsedPrescription.Name = "lblAlwaysUsedPrescription";
            this.lblAlwaysUsedPrescription.Size = new System.Drawing.Size(65, 12);
            this.lblAlwaysUsedPrescription.TabIndex = 14;
            this.lblAlwaysUsedPrescription.Text = "常用处方：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(346, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "数量：";
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.Location = new System.Drawing.Point(679, 21);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.Size = new System.Drawing.Size(74, 21);
            this.btnAddDrug.TabIndex = 13;
            this.btnAddDrug.Text = "添 加";
            this.btnAddDrug.UseVisualStyleBackColor = true;
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(96, 23);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(229, 21);
            this.txtDrugName.TabIndex = 7;
            // 
            // dgvPrescription
            // 
            this.dgvPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescription.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dName,
            this.dSpec,
            this.dQuantity,
            this.dUnit,
            this.dPrice,
            this.pDrugMethod});
            this.dgvPrescription.Location = new System.Drawing.Point(16, 85);
            this.dgvPrescription.MultiSelect = false;
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.ReadOnly = true;
            this.dgvPrescription.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescription.Size = new System.Drawing.Size(736, 203);
            this.dgvPrescription.TabIndex = 12;
            // 
            // dName
            // 
            this.dName.DataPropertyName = "DrugName";
            this.dName.HeaderText = "药品名称";
            this.dName.Name = "dName";
            this.dName.ReadOnly = true;
            this.dName.Width = 240;
            // 
            // dSpec
            // 
            this.dSpec.DataPropertyName = "dSpec";
            this.dSpec.HeaderText = "规格";
            this.dSpec.Name = "dSpec";
            this.dSpec.ReadOnly = true;
            this.dSpec.Width = 80;
            // 
            // dQuantity
            // 
            this.dQuantity.DataPropertyName = "DrugQuantity";
            this.dQuantity.HeaderText = "数量";
            this.dQuantity.Name = "dQuantity";
            this.dQuantity.ReadOnly = true;
            this.dQuantity.Width = 60;
            // 
            // dUnit
            // 
            this.dUnit.DataPropertyName = "dUnit";
            this.dUnit.HeaderText = "单位";
            this.dUnit.Name = "dUnit";
            this.dUnit.ReadOnly = true;
            this.dUnit.Width = 60;
            // 
            // dPrice
            // 
            this.dPrice.DataPropertyName = "dPrice";
            this.dPrice.HeaderText = "单价";
            this.dPrice.Name = "dPrice";
            this.dPrice.ReadOnly = true;
            // 
            // pDrugMethod
            // 
            this.pDrugMethod.DataPropertyName = "DrugMethod";
            this.pDrugMethod.HeaderText = "用法";
            this.pDrugMethod.Name = "pDrugMethod";
            this.pDrugMethod.ReadOnly = true;
            this.pDrugMethod.Width = 150;
            // 
            // cbDrugQuantity
            // 
            this.cbDrugQuantity.FormattingEnabled = true;
            this.cbDrugQuantity.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.cbDrugQuantity.Location = new System.Drawing.Point(395, 22);
            this.cbDrugQuantity.Name = "cbDrugQuantity";
            this.cbDrugQuantity.Size = new System.Drawing.Size(66, 20);
            this.cbDrugQuantity.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(478, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "用法：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 26);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 6;
            this.label8.Text = "药品名称：";
            // 
            // txtDrugMethod
            // 
            this.txtDrugMethod.Location = new System.Drawing.Point(527, 23);
            this.txtDrugMethod.Name = "txtDrugMethod";
            this.txtDrugMethod.Size = new System.Drawing.Size(138, 21);
            this.txtDrugMethod.TabIndex = 9;
            // 
            // btnSaveMedicalRecord
            // 
            this.btnSaveMedicalRecord.Location = new System.Drawing.Point(243, 588);
            this.btnSaveMedicalRecord.Name = "btnSaveMedicalRecord";
            this.btnSaveMedicalRecord.Size = new System.Drawing.Size(119, 32);
            this.btnSaveMedicalRecord.TabIndex = 7;
            this.btnSaveMedicalRecord.Text = "保 存 病 历";
            this.btnSaveMedicalRecord.UseVisualStyleBackColor = true;
            // 
            // btnPreview
            // 
            this.btnPreview.Enabled = false;
            this.btnPreview.Location = new System.Drawing.Point(553, 588);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(119, 32);
            this.btnPreview.TabIndex = 8;
            this.btnPreview.Text = "预 览";
            this.btnPreview.UseVisualStyleBackColor = true;
            // 
            // btnPrintPrescription
            // 
            this.btnPrintPrescription.Enabled = false;
            this.btnPrintPrescription.Location = new System.Drawing.Point(707, 588);
            this.btnPrintPrescription.Name = "btnPrintPrescription";
            this.btnPrintPrescription.Size = new System.Drawing.Size(119, 32);
            this.btnPrintPrescription.TabIndex = 9;
            this.btnPrintPrescription.Text = "打 印 处 方";
            this.btnPrintPrescription.UseVisualStyleBackColor = true;
            // 
            // btnPrintMedicalRecord
            // 
            this.btnPrintMedicalRecord.Enabled = false;
            this.btnPrintMedicalRecord.Location = new System.Drawing.Point(858, 588);
            this.btnPrintMedicalRecord.Name = "btnPrintMedicalRecord";
            this.btnPrintMedicalRecord.Size = new System.Drawing.Size(119, 32);
            this.btnPrintMedicalRecord.TabIndex = 10;
            this.btnPrintMedicalRecord.Text = "打 印 病 历";
            this.btnPrintMedicalRecord.UseVisualStyleBackColor = true;
            // 
            // gbPrescriptionList
            // 
            this.gbPrescriptionList.Controls.Add(this.dgvPrescriptionList);
            this.gbPrescriptionList.Location = new System.Drawing.Point(3, 312);
            this.gbPrescriptionList.Name = "gbPrescriptionList";
            this.gbPrescriptionList.Size = new System.Drawing.Size(216, 308);
            this.gbPrescriptionList.TabIndex = 11;
            this.gbPrescriptionList.TabStop = false;
            this.gbPrescriptionList.Text = "处方列表";
            // 
            // dgvPrescriptionList
            // 
            this.dgvPrescriptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrescriptionList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pPrescriptionNO,
            this.pPrescriptionName});
            this.dgvPrescriptionList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPrescriptionList.Location = new System.Drawing.Point(3, 17);
            this.dgvPrescriptionList.MultiSelect = false;
            this.dgvPrescriptionList.Name = "dgvPrescriptionList";
            this.dgvPrescriptionList.ReadOnly = true;
            this.dgvPrescriptionList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPrescriptionList.Size = new System.Drawing.Size(210, 288);
            this.dgvPrescriptionList.TabIndex = 0;
            // 
            // pPrescriptionNO
            // 
            this.pPrescriptionNO.DataPropertyName = "NO";
            this.pPrescriptionNO.HeaderText = "序号";
            this.pPrescriptionNO.Name = "pPrescriptionNO";
            this.pPrescriptionNO.ReadOnly = true;
            this.pPrescriptionNO.Width = 40;
            // 
            // pPrescriptionName
            // 
            this.pPrescriptionName.DataPropertyName = "Name";
            this.pPrescriptionName.HeaderText = "处方";
            this.pPrescriptionName.Name = "pPrescriptionName";
            this.pPrescriptionName.ReadOnly = true;
            this.pPrescriptionName.Width = 120;
            // 
            // gbPatients
            // 
            this.gbPatients.Controls.Add(this.dgvPatients);
            this.gbPatients.Location = new System.Drawing.Point(3, 26);
            this.gbPatients.Name = "gbPatients";
            this.gbPatients.Size = new System.Drawing.Size(216, 281);
            this.gbPatients.TabIndex = 12;
            this.gbPatients.TabStop = false;
            this.gbPatients.Text = "待诊病人";
            // 
            // btnSavePrescription
            // 
            this.btnSavePrescription.Location = new System.Drawing.Point(400, 588);
            this.btnSavePrescription.Name = "btnSavePrescription";
            this.btnSavePrescription.Size = new System.Drawing.Size(119, 32);
            this.btnSavePrescription.TabIndex = 13;
            this.btnSavePrescription.Text = "保 存 处 方";
            this.btnSavePrescription.UseVisualStyleBackColor = true;
            this.btnSavePrescription.Click += new System.EventHandler(this.btnSavePrescription_Click);
            // 
            // FrmMedicalRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 673);
            this.Controls.Add(this.btnSavePrescription);
            this.Controls.Add(this.gbPatients);
            this.Controls.Add(this.gbPrescriptionList);
            this.Controls.Add(this.btnPrintMedicalRecord);
            this.Controls.Add(this.btnPrintPrescription);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnSaveMedicalRecord);
            this.Controls.Add(this.gbPrescription);
            this.Controls.Add(this.gbMedicalRecords);
            this.Controls.Add(this.gbPatientBasicInfo);
            this.Controls.Add(this.gbStatusBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMedicalRecords";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "门诊管理系统 - 门诊管理";
            this.Load += new System.EventHandler(this.FrmMedicalRecords_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatients)).EndInit();
            this.gbStatusBar.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.gbPatientBasicInfo.ResumeLayout(false);
            this.gbPatientBasicInfo.PerformLayout();
            this.gbMedicalRecords.ResumeLayout(false);
            this.gbMedicalRecords.PerformLayout();
            this.gbPrescription.ResumeLayout(false);
            this.gbPrescription.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            this.gbPrescriptionList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescriptionList)).EndInit();
            this.gbPatients.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 门诊医生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 处方ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvPatients;
        private System.Windows.Forms.GroupBox gbStatusBar;
        private System.Windows.Forms.GroupBox gbPatientBasicInfo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbDepartment;
        private System.Windows.Forms.Label lblDoctor;
        private System.Windows.Forms.ComboBox cbDoctor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFirstDate;
        private System.Windows.Forms.GroupBox gbMedicalRecords;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDoctorAdvice;
        private System.Windows.Forms.TextBox txtJudgement;
        private System.Windows.Forms.CheckedListBox cblCheck;
        private System.Windows.Forms.GroupBox gbPrescription;
        private System.Windows.Forms.ComboBox cbDrugQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDrugMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddDrug;
        private System.Windows.Forms.DataGridView dgvPrescription;
        private System.Windows.Forms.Button btnSaveMedicalRecord;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnPrintPrescription;
        private System.Windows.Forms.Button btnPrintMedicalRecord;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblSystemUserName;
        private System.Windows.Forms.Label lblSystemUser;
        private System.Windows.Forms.Label lblSystemDate;
        private System.Windows.Forms.Label lblSystemDateDisplay;
        private System.Windows.Forms.GroupBox gbPrescriptionList;
        private System.Windows.Forms.DataGridView dgvPrescriptionList;
        private System.Windows.Forms.GroupBox gbPatients;
        private System.Windows.Forms.Button btnSavePrescription;
        private System.Windows.Forms.Label lblAlwaysUsedPrescription;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDrugMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn pNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn pName;
        private System.Windows.Forms.DataGridViewTextBoxColumn pGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrescriptionNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn pPrescriptionName;
    }
}