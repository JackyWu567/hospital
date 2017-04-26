namespace longhu.his.Hospital.registration
{
    partial class Search
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
            this.panel_left = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_invalid = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.gb_department = new System.Windows.Forms.GroupBox();
            this.cb_doctor = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gb_date = new System.Windows.Forms.GroupBox();
            this.dtp_end = new System.Windows.Forms.DateTimePicker();
            this.dtp_start = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dg_detail = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.dg_basic = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_left.SuspendLayout();
            this.gb_department.SuspendLayout();
            this.gb_date.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detail)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_basic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_left.Controls.Add(this.btn_close);
            this.panel_left.Controls.Add(this.btn_invalid);
            this.panel_left.Controls.Add(this.btn_search);
            this.panel_left.Controls.Add(this.gb_department);
            this.panel_left.Controls.Add(this.gb_date);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(250, 660);
            this.panel_left.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(26, 580);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(200, 25);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "关闭 [X]";
            this.btn_close.UseVisualStyleBackColor = true;
            // 
            // btn_invalid
            // 
            this.btn_invalid.Location = new System.Drawing.Point(26, 540);
            this.btn_invalid.Name = "btn_invalid";
            this.btn_invalid.Size = new System.Drawing.Size(200, 25);
            this.btn_invalid.TabIndex = 3;
            this.btn_invalid.Text = "作废 [D]";
            this.btn_invalid.UseVisualStyleBackColor = true;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(26, 500);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(200, 25);
            this.btn_search.TabIndex = 2;
            this.btn_search.Text = "查询 [V]";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // gb_department
            // 
            this.gb_department.Controls.Add(this.cb_doctor);
            this.gb_department.Controls.Add(this.label4);
            this.gb_department.Controls.Add(this.cb_department);
            this.gb_department.Controls.Add(this.label3);
            this.gb_department.Location = new System.Drawing.Point(3, 258);
            this.gb_department.Name = "gb_department";
            this.gb_department.Size = new System.Drawing.Size(240, 217);
            this.gb_department.TabIndex = 1;
            this.gb_department.TabStop = false;
            this.gb_department.Text = "[科室设置]";
            // 
            // cb_doctor
            // 
            this.cb_doctor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_doctor.FormattingEnabled = true;
            this.cb_doctor.Items.AddRange(new object[] {
            "于慧卿",
            "陶静华",
            "邹一萍",
            "王宏卫",
            "张海滨"});
            this.cb_doctor.Location = new System.Drawing.Point(23, 156);
            this.cb_doctor.Name = "cb_doctor";
            this.cb_doctor.Size = new System.Drawing.Size(200, 20);
            this.cb_doctor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "诊疗医生：";
            // 
            // cb_department
            // 
            this.cb_department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_department.FormattingEnabled = true;
            this.cb_department.Items.AddRange(new object[] {
            "内科",
            "外科",
            "儿科",
            "牙科",
            "妇科"});
            this.cb_department.Location = new System.Drawing.Point(23, 80);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(200, 20);
            this.cb_department.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "诊疗科室：";
            // 
            // gb_date
            // 
            this.gb_date.Controls.Add(this.dtp_end);
            this.gb_date.Controls.Add(this.dtp_start);
            this.gb_date.Controls.Add(this.label2);
            this.gb_date.Controls.Add(this.label1);
            this.gb_date.Location = new System.Drawing.Point(3, 11);
            this.gb_date.Name = "gb_date";
            this.gb_date.Size = new System.Drawing.Size(240, 216);
            this.gb_date.TabIndex = 0;
            this.gb_date.TabStop = false;
            this.gb_date.Text = "[时间设置]";
            // 
            // dtp_end
            // 
            this.dtp_end.Location = new System.Drawing.Point(23, 150);
            this.dtp_end.Name = "dtp_end";
            this.dtp_end.Size = new System.Drawing.Size(200, 21);
            this.dtp_end.TabIndex = 3;
            // 
            // dtp_start
            // 
            this.dtp_start.Location = new System.Drawing.Point(23, 72);
            this.dtp_start.Name = "dtp_start";
            this.dtp_start.Size = new System.Drawing.Size(200, 21);
            this.dtp_start.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "终止日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "起始日期：";
            // 
            // panel_right
            // 
            this.panel_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_right.Controls.Add(this.groupBox3);
            this.panel_right.Controls.Add(this.groupBox2);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(250, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(758, 660);
            this.panel_right.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.dg_detail);
            this.groupBox3.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox3.Location = new System.Drawing.Point(5, 333);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(748, 318);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "[挂号明细信息]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.DarkOrange;
            this.label5.Location = new System.Drawing.Point(33, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "作废记录";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkOrange;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(7, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(20, 18);
            this.panel1.TabIndex = 2;
            // 
            // dg_detail
            // 
            this.dg_detail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_detail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
            this.dg_detail.Location = new System.Drawing.Point(6, 49);
            this.dg_detail.Name = "dg_detail";
            this.dg_detail.RowTemplate.Height = 23;
            this.dg_detail.Size = new System.Drawing.Size(734, 263);
            this.dg_detail.TabIndex = 1;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "编号";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "科室";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "医生";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "挂号金额";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "实收金额";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "找零金额";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "日期";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_delete);
            this.groupBox2.Controls.Add(this.dg_basic);
            this.groupBox2.ForeColor = System.Drawing.Color.ForestGreen;
            this.groupBox2.Location = new System.Drawing.Point(5, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 303);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[挂号基本资料]";
            // 
            // btn_delete
            // 
            this.btn_delete.ForeColor = System.Drawing.Color.Red;
            this.btn_delete.Location = new System.Drawing.Point(6, 22);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 1;
            this.btn_delete.Text = "删除";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // dg_basic
            // 
            this.dg_basic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_basic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dg_basic.Location = new System.Drawing.Point(6, 57);
            this.dg_basic.Name = "dg_basic";
            this.dg_basic.RowTemplate.Height = 23;
            this.dg_basic.Size = new System.Drawing.Size(734, 240);
            this.dg_basic.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "年龄";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "病人类型";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "日期";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 660);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Search";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Search";
            this.panel_left.ResumeLayout(false);
            this.gb_department.ResumeLayout(false);
            this.gb_department.PerformLayout();
            this.gb_date.ResumeLayout(false);
            this.gb_date.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detail)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_basic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.GroupBox gb_department;
        private System.Windows.Forms.GroupBox gb_date;
        private System.Windows.Forms.DateTimePicker dtp_end;
        private System.Windows.Forms.DateTimePicker dtp_start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_doctor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_invalid;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dg_basic;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dg_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
    }
}