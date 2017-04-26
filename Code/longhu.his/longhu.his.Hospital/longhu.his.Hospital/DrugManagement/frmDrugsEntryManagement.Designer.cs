namespace longhu.his.Hospital.DrugManagement
{
    partial class frmDrugsEntryManagement
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatuslbl_CurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLbl_CurrentDateTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.purchase_note_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.billNumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bill_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Entry_user = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.purchase_auditor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplier_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupplierAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnAuditing = new System.Windows.Forms.Button();
            this.btnCreateGodownEntry = new System.Windows.Forms.Button();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnQuery = new System.Windows.Forms.Button();
            this.textSupplier = new System.Windows.Forms.TextBox();
            this.cbxSupplier = new System.Windows.Forms.CheckBox();
            this.textBillNumer = new System.Windows.Forms.TextBox();
            this.cbxBillNo = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatuslbl_CurrentUser,
            this.toolStripStatusLbl_CurrentDateTime,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel9});
            this.statusStrip1.Location = new System.Drawing.Point(0, 550);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1089, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatuslbl_CurrentUser
            // 
            this.toolStripStatuslbl_CurrentUser.Name = "toolStripStatuslbl_CurrentUser";
            this.toolStripStatuslbl_CurrentUser.Size = new System.Drawing.Size(358, 17);
            this.toolStripStatuslbl_CurrentUser.Spring = true;
            this.toolStripStatuslbl_CurrentUser.Text = "当前用户：Admin";
            this.toolStripStatuslbl_CurrentUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLbl_CurrentDateTime
            // 
            this.toolStripStatusLbl_CurrentDateTime.Name = "toolStripStatusLbl_CurrentDateTime";
            this.toolStripStatusLbl_CurrentDateTime.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(358, 17);
            this.toolStripStatusLabel3.Spring = true;
            this.toolStripStatusLabel3.Text = "2017-04-06 23:43:25";
            this.toolStripStatusLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(358, 17);
            this.toolStripStatusLabel8.Spring = true;
            this.toolStripStatusLabel8.Text = "药房";
            this.toolStripStatusLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1089, 545);
            this.panel1.TabIndex = 10001;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.purchase_note_id,
            this.entryName,
            this.billNumer,
            this.bill_date,
            this.Entry_user,
            this.purchase_auditor,
            this.supplier_name,
            this.SupplierAddress,
            this.status});
            this.dataGridView.Location = new System.Drawing.Point(0, 72);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 23;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.ShowCellErrors = false;
            this.dataGridView.ShowCellToolTips = false;
            this.dataGridView.ShowEditingIcon = false;
            this.dataGridView.Size = new System.Drawing.Size(1085, 408);
            this.dataGridView.TabIndex = 6;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView_CellMouseDoubleClick);
            // 
            // purchase_note_id
            // 
            this.purchase_note_id.DataPropertyName = "PurchaseNoteId";
            this.purchase_note_id.HeaderText = "入库单号";
            this.purchase_note_id.Name = "purchase_note_id";
            // 
            // entryName
            // 
            this.entryName.DataPropertyName = "DrugEntryType";
            this.entryName.HeaderText = "入库方式";
            this.entryName.Name = "entryName";
            // 
            // billNumer
            // 
            this.billNumer.DataPropertyName = "InvoiceCode";
            this.billNumer.HeaderText = "发票号码";
            this.billNumer.Name = "billNumer";
            // 
            // bill_date
            // 
            this.bill_date.DataPropertyName = "InvoiceDate";
            this.bill_date.HeaderText = "发票日期";
            this.bill_date.Name = "bill_date";
            // 
            // Entry_user
            // 
            this.Entry_user.DataPropertyName = "Purchaser";
            this.Entry_user.HeaderText = "采购员";
            this.Entry_user.Name = "Entry_user";
            // 
            // purchase_auditor
            // 
            this.purchase_auditor.DataPropertyName = "PurchaseAuditor";
            this.purchase_auditor.HeaderText = "采购审批人";
            this.purchase_auditor.Name = "purchase_auditor";
            // 
            // supplier_name
            // 
            this.supplier_name.DataPropertyName = "Supplier";
            this.supplier_name.HeaderText = "供货单位";
            this.supplier_name.Name = "supplier_name";
            // 
            // SupplierAddress
            // 
            this.SupplierAddress.DataPropertyName = "SupplierAddress";
            this.SupplierAddress.HeaderText = "供应商地址";
            this.SupplierAddress.Name = "SupplierAddress";
            // 
            // status
            // 
            this.status.DataPropertyName = "Status";
            this.status.HeaderText = "当前状态";
            this.status.Name = "status";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRefresh);
            this.panel3.Controls.Add(this.btnAuditing);
            this.panel3.Controls.Add(this.btnCreateGodownEntry);
            this.panel3.Controls.Add(this.btnModify);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnClose);
            this.panel3.Location = new System.Drawing.Point(3, 484);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1082, 56);
            this.panel3.TabIndex = 10009;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(75, 20);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "刷新【R】";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnAuditing
            // 
            this.btnAuditing.Location = new System.Drawing.Point(562, 20);
            this.btnAuditing.Name = "btnAuditing";
            this.btnAuditing.Size = new System.Drawing.Size(75, 23);
            this.btnAuditing.TabIndex = 11;
            this.btnAuditing.Text = "复核【A】";
            this.btnAuditing.UseVisualStyleBackColor = true;
            this.btnAuditing.Click += new System.EventHandler(this.btnAuditing_Click);
            // 
            // btnCreateGodownEntry
            // 
            this.btnCreateGodownEntry.Location = new System.Drawing.Point(189, 20);
            this.btnCreateGodownEntry.Name = "btnCreateGodownEntry";
            this.btnCreateGodownEntry.Size = new System.Drawing.Size(106, 23);
            this.btnCreateGodownEntry.TabIndex = 8;
            this.btnCreateGodownEntry.Text = "新建入库单【N】";
            this.btnCreateGodownEntry.UseVisualStyleBackColor = true;
            this.btnCreateGodownEntry.Click += new System.EventHandler(this.btnCreateGodownEntry_Click);
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(334, 20);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 9;
            this.btnModify.Text = "修改【M】";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(448, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "删除【D】";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(938, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "退出";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnQuery);
            this.panel2.Controls.Add(this.textSupplier);
            this.panel2.Controls.Add(this.cbxSupplier);
            this.panel2.Controls.Add(this.textBillNumer);
            this.panel2.Controls.Add(this.cbxBillNo);
            this.panel2.Location = new System.Drawing.Point(3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1082, 63);
            this.panel2.TabIndex = 10004;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(921, 16);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // textSupplier
            // 
            this.textSupplier.Location = new System.Drawing.Point(521, 18);
            this.textSupplier.Name = "textSupplier";
            this.textSupplier.Size = new System.Drawing.Size(326, 21);
            this.textSupplier.TabIndex = 4;
            // 
            // cbxSupplier
            // 
            this.cbxSupplier.AutoSize = true;
            this.cbxSupplier.Checked = true;
            this.cbxSupplier.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxSupplier.Location = new System.Drawing.Point(443, 21);
            this.cbxSupplier.Name = "cbxSupplier";
            this.cbxSupplier.Size = new System.Drawing.Size(72, 16);
            this.cbxSupplier.TabIndex = 3;
            this.cbxSupplier.Text = "供货单位";
            this.cbxSupplier.UseVisualStyleBackColor = true;
            this.cbxSupplier.CheckedChanged += new System.EventHandler(this.cbxSupplier_CheckedChanged);
            // 
            // textBillNumer
            // 
            this.textBillNumer.Location = new System.Drawing.Point(75, 18);
            this.textBillNumer.MaxLength = 50;
            this.textBillNumer.Name = "textBillNumer";
            this.textBillNumer.ReadOnly = true;
            this.textBillNumer.Size = new System.Drawing.Size(326, 21);
            this.textBillNumer.TabIndex = 2;
            // 
            // cbxBillNo
            // 
            this.cbxBillNo.AutoSize = true;
            this.cbxBillNo.CausesValidation = false;
            this.cbxBillNo.Location = new System.Drawing.Point(9, 21);
            this.cbxBillNo.Name = "cbxBillNo";
            this.cbxBillNo.Size = new System.Drawing.Size(60, 16);
            this.cbxBillNo.TabIndex = 1;
            this.cbxBillNo.Text = "发票号";
            this.cbxBillNo.UseVisualStyleBackColor = true;
            this.cbxBillNo.CheckedChanged += new System.EventHandler(this.cbxBillNo_CheckedChanged);
            // 
            // frmDrugsEntryManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 572);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "frmDrugsEntryManagement";
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "西安灞桥龙兴门诊部管理系统 -- 药房管理 -- 入库管理";
            this.Load += new System.EventHandler(this.frmDrugsEntryManagement_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatuslbl_CurrentUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLbl_CurrentDateTime;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAuditing;
        private System.Windows.Forms.Button btnCreateGodownEntry;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox textSupplier;
        private System.Windows.Forms.CheckBox cbxSupplier;
        private System.Windows.Forms.TextBox textBillNumer;
        private System.Windows.Forms.CheckBox cbxBillNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_note_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn entryName;
        private System.Windows.Forms.DataGridViewTextBoxColumn billNumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn bill_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Entry_user;
        private System.Windows.Forms.DataGridViewTextBoxColumn purchase_auditor;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplier_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}