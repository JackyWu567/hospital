namespace longhu.his.Hospital.OutpatientsManagement
{
    partial class FrmPrescriptionMgr
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrescriptionMgr));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.门诊医生ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.病历ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.处方ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ckAlwaysUsedPrescription = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddDrug = new System.Windows.Forms.Button();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.cbDrugQuantity = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDrugMethod = new System.Windows.Forms.TextBox();
            this.dgvPrescription = new System.Windows.Forms.DataGridView();
            this.dName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dSpec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pDrugMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtPrescriptionName = new System.Windows.Forms.TextBox();
            this.lblPrescriptionName = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.preNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.门诊医生ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1008, 25);
            this.menuStrip1.TabIndex = 1;
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
            this.病历ToolStripMenuItem.Click += new System.EventHandler(this.病历ToolStripMenuItem_Click);
            // 
            // 处方ToolStripMenuItem
            // 
            this.处方ToolStripMenuItem.Name = "处方ToolStripMenuItem";
            this.处方ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.处方ToolStripMenuItem.Text = "处方";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.ckAlwaysUsedPrescription);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnAddDrug);
            this.groupBox1.Controls.Add(this.txtDrugName);
            this.groupBox1.Controls.Add(this.cbDrugQuantity);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtDrugMethod);
            this.groupBox1.Controls.Add(this.dgvPrescription);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.txtPrescriptionName);
            this.groupBox1.Controls.Add(this.lblPrescriptionName);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(984, 637);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "处方列表";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(893, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 21);
            this.button2.TabIndex = 23;
            this.button2.Text = "删 除 处 方";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(801, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 21);
            this.button1.TabIndex = 22;
            this.button1.Text = "保 存 处 方";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ckAlwaysUsedPrescription
            // 
            this.ckAlwaysUsedPrescription.AutoSize = true;
            this.ckAlwaysUsedPrescription.Location = new System.Drawing.Point(602, 63);
            this.ckAlwaysUsedPrescription.Name = "ckAlwaysUsedPrescription";
            this.ckAlwaysUsedPrescription.Size = new System.Drawing.Size(96, 16);
            this.ckAlwaysUsedPrescription.TabIndex = 21;
            this.ckAlwaysUsedPrescription.Text = "是否常用处方";
            this.ckAlwaysUsedPrescription.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(243, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "数量：";
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.Location = new System.Drawing.Point(708, 59);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.Size = new System.Drawing.Size(74, 21);
            this.btnAddDrug.TabIndex = 20;
            this.btnAddDrug.Text = "添 加 药 品";
            this.btnAddDrug.UseVisualStyleBackColor = true;
            // 
            // txtDrugName
            // 
            this.txtDrugName.Location = new System.Drawing.Point(80, 61);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(148, 21);
            this.txtDrugName.TabIndex = 15;
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
            this.cbDrugQuantity.Location = new System.Drawing.Point(290, 60);
            this.cbDrugQuantity.Name = "cbDrugQuantity";
            this.cbDrugQuantity.Size = new System.Drawing.Size(89, 20);
            this.cbDrugQuantity.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 18;
            this.label6.Text = "用法：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "药品名称：";
            // 
            // txtDrugMethod
            // 
            this.txtDrugMethod.Location = new System.Drawing.Point(444, 61);
            this.txtDrugMethod.Name = "txtDrugMethod";
            this.txtDrugMethod.Size = new System.Drawing.Size(138, 21);
            this.txtDrugMethod.TabIndex = 17;
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
            this.dgvPrescription.Location = new System.Drawing.Point(244, 97);
            this.dgvPrescription.Name = "dgvPrescription";
            this.dgvPrescription.Size = new System.Drawing.Size(734, 534);
            this.dgvPrescription.TabIndex = 13;
            // 
            // dName
            // 
            this.dName.DataPropertyName = "DrugName";
            this.dName.HeaderText = "药品名称";
            this.dName.Name = "dName";
            this.dName.Width = 240;
            // 
            // dSpec
            // 
            this.dSpec.DataPropertyName = "dSpec";
            this.dSpec.HeaderText = "规格";
            this.dSpec.Name = "dSpec";
            this.dSpec.Width = 80;
            // 
            // dQuantity
            // 
            this.dQuantity.DataPropertyName = "DrugQuantity";
            this.dQuantity.HeaderText = "数量";
            this.dQuantity.Name = "dQuantity";
            this.dQuantity.Width = 60;
            // 
            // dUnit
            // 
            this.dUnit.DataPropertyName = "dUnit";
            this.dUnit.HeaderText = "单位";
            this.dUnit.Name = "dUnit";
            this.dUnit.Width = 60;
            // 
            // dPrice
            // 
            this.dPrice.DataPropertyName = "dPrice";
            this.dPrice.HeaderText = "单价";
            this.dPrice.Name = "dPrice";
            // 
            // pDrugMethod
            // 
            this.pDrugMethod.DataPropertyName = "DrugMethod";
            this.pDrugMethod.HeaderText = "用法";
            this.pDrugMethod.Name = "pDrugMethod";
            this.pDrugMethod.Width = 150;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(356, 25);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 21);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "搜 索";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // txtPrescriptionName
            // 
            this.txtPrescriptionName.Location = new System.Drawing.Point(80, 27);
            this.txtPrescriptionName.Name = "txtPrescriptionName";
            this.txtPrescriptionName.Size = new System.Drawing.Size(260, 21);
            this.txtPrescriptionName.TabIndex = 2;
            // 
            // lblPrescriptionName
            // 
            this.lblPrescriptionName.AutoSize = true;
            this.lblPrescriptionName.Location = new System.Drawing.Point(7, 30);
            this.lblPrescriptionName.Name = "lblPrescriptionName";
            this.lblPrescriptionName.Size = new System.Drawing.Size(65, 12);
            this.lblPrescriptionName.TabIndex = 1;
            this.lblPrescriptionName.Text = "处方名称：";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.preNO,
            this.preName});
            this.dataGridView1.Location = new System.Drawing.Point(6, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(222, 534);
            this.dataGridView1.TabIndex = 0;
            // 
            // preNO
            // 
            this.preNO.HeaderText = "序号";
            this.preNO.Name = "preNO";
            this.preNO.Width = 40;
            // 
            // preName
            // 
            this.preName.HeaderText = "处方名称";
            this.preName.Name = "preName";
            this.preName.Width = 150;
            // 
            // FrmPrescriptionMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 673);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrescriptionMgr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "门诊管理系统 - 处方管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 门诊医生ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 病历ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 处方ToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtPrescriptionName;
        private System.Windows.Forms.Label lblPrescriptionName;
        private System.Windows.Forms.DataGridView dgvPrescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn dName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dSpec;
        private System.Windows.Forms.DataGridViewTextBoxColumn dQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn pDrugMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn preNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn preName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddDrug;
        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.ComboBox cbDrugQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDrugMethod;
        private System.Windows.Forms.CheckBox ckAlwaysUsedPrescription;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}