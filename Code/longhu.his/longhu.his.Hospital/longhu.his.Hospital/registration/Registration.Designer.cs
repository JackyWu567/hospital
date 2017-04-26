namespace longhu.his.Hospital.registration
{
    partial class Registration
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
            this.btn_clean = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.gb_department = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_chargeback = new System.Windows.Forms.TextBox();
            this.txt_actualpay = new System.Windows.Forms.TextBox();
            this.cb_doctor = new System.Windows.Forms.ComboBox();
            this.txt_pay = new System.Windows.Forms.TextBox();
            this.cb_department = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.gb_patient = new System.Windows.Forms.GroupBox();
            this.cb_sex = new System.Windows.Forms.ComboBox();
            this.txt_age = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_comments = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_right = new System.Windows.Forms.Panel();
            this.gb_detail = new System.Windows.Forms.GroupBox();
            this.dg_detail = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_basic = new System.Windows.Forms.GroupBox();
            this.dg_basic = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel_left.SuspendLayout();
            this.gb_department.SuspendLayout();
            this.gb_patient.SuspendLayout();
            this.panel_right.SuspendLayout();
            this.gb_detail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_detail)).BeginInit();
            this.gb_basic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dg_basic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_left
            // 
            this.panel_left.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_left.Controls.Add(this.btn_close);
            this.panel_left.Controls.Add(this.btn_clean);
            this.panel_left.Controls.Add(this.btn_register);
            this.panel_left.Controls.Add(this.gb_department);
            this.panel_left.Controls.Add(this.textBox1);
            this.panel_left.Controls.Add(this.gb_patient);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(250, 660);
            this.panel_left.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(11, 600);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(228, 25);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "关  闭 [X]";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_clean
            // 
            this.btn_clean.Location = new System.Drawing.Point(11, 560);
            this.btn_clean.Name = "btn_clean";
            this.btn_clean.Size = new System.Drawing.Size(228, 25);
            this.btn_clean.TabIndex = 12;
            this.btn_clean.Text = "初始化 [C]";
            this.btn_clean.UseVisualStyleBackColor = true;
            this.btn_clean.Click += new System.EventHandler(this.btn_clean_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(11, 520);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(228, 25);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "挂  号 [S]";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // gb_department
            // 
            this.gb_department.Controls.Add(this.label14);
            this.gb_department.Controls.Add(this.label13);
            this.gb_department.Controls.Add(this.label12);
            this.gb_department.Controls.Add(this.txt_chargeback);
            this.gb_department.Controls.Add(this.txt_actualpay);
            this.gb_department.Controls.Add(this.cb_doctor);
            this.gb_department.Controls.Add(this.txt_pay);
            this.gb_department.Controls.Add(this.cb_department);
            this.gb_department.Controls.Add(this.label11);
            this.gb_department.Controls.Add(this.label10);
            this.gb_department.Controls.Add(this.label9);
            this.gb_department.Controls.Add(this.label8);
            this.gb_department.Controls.Add(this.label7);
            this.gb_department.Location = new System.Drawing.Point(3, 262);
            this.gb_department.Name = "gb_department";
            this.gb_department.Size = new System.Drawing.Size(242, 243);
            this.gb_department.TabIndex = 2;
            this.gb_department.TabStop = false;
            this.gb_department.Text = "[挂号信息]";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(17, 12);
            this.label14.TabIndex = 23;
            this.label14.Text = "元";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(219, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 12);
            this.label13.TabIndex = 22;
            this.label13.Text = "元";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(219, 110);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 12);
            this.label12.TabIndex = 21;
            this.label12.Text = "元";
            // 
            // txt_chargeback
            // 
            this.txt_chargeback.Enabled = false;
            this.txt_chargeback.Location = new System.Drawing.Point(70, 187);
            this.txt_chargeback.Name = "txt_chargeback";
            this.txt_chargeback.ReadOnly = true;
            this.txt_chargeback.Size = new System.Drawing.Size(143, 21);
            this.txt_chargeback.TabIndex = 10;
            // 
            // txt_actualpay
            // 
            this.txt_actualpay.Location = new System.Drawing.Point(70, 147);
            this.txt_actualpay.Name = "txt_actualpay";
            this.txt_actualpay.Size = new System.Drawing.Size(143, 21);
            this.txt_actualpay.TabIndex = 9;
            this.txt_actualpay.MouseLeave += new System.EventHandler(this.txt_actualpay_MouseLeave);
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
            this.cb_doctor.Location = new System.Drawing.Point(70, 67);
            this.cb_doctor.Name = "cb_doctor";
            this.cb_doctor.Size = new System.Drawing.Size(166, 20);
            this.cb_doctor.TabIndex = 7;
            // 
            // txt_pay
            // 
            this.txt_pay.Enabled = false;
            this.txt_pay.Location = new System.Drawing.Point(70, 107);
            this.txt_pay.Name = "txt_pay";
            this.txt_pay.ReadOnly = true;
            this.txt_pay.Size = new System.Drawing.Size(143, 21);
            this.txt_pay.TabIndex = 8;
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
            this.cb_department.Location = new System.Drawing.Point(70, 27);
            this.cb_department.Name = "cb_department";
            this.cb_department.Size = new System.Drawing.Size(166, 20);
            this.cb_department.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(20, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "找  零：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 16;
            this.label10.Text = "预  收：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "应  收：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 14;
            this.label8.Text = "医  生：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 13;
            this.label7.Text = "科  室：";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-16, -16);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 21);
            this.textBox1.TabIndex = 1;
            // 
            // gb_patient
            // 
            this.gb_patient.Controls.Add(this.cb_sex);
            this.gb_patient.Controls.Add(this.txt_age);
            this.gb_patient.Controls.Add(this.label6);
            this.gb_patient.Controls.Add(this.txt_comments);
            this.gb_patient.Controls.Add(this.txt_id);
            this.gb_patient.Controls.Add(this.txt_name);
            this.gb_patient.Controls.Add(this.label5);
            this.gb_patient.Controls.Add(this.label4);
            this.gb_patient.Controls.Add(this.label2);
            this.gb_patient.Controls.Add(this.label1);
            this.gb_patient.Location = new System.Drawing.Point(3, 6);
            this.gb_patient.Name = "gb_patient";
            this.gb_patient.Size = new System.Drawing.Size(242, 234);
            this.gb_patient.TabIndex = 0;
            this.gb_patient.TabStop = false;
            this.gb_patient.Text = "[病人信息]";
            // 
            // cb_sex
            // 
            this.cb_sex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_sex.FormattingEnabled = true;
            this.cb_sex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cb_sex.Location = new System.Drawing.Point(70, 67);
            this.cb_sex.Name = "cb_sex";
            this.cb_sex.Size = new System.Drawing.Size(166, 20);
            this.cb_sex.TabIndex = 2;
            // 
            // txt_age
            // 
            this.txt_age.Location = new System.Drawing.Point(70, 107);
            this.txt_age.MaxLength = 3;
            this.txt_age.Name = "txt_age";
            this.txt_age.Size = new System.Drawing.Size(166, 21);
            this.txt_age.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 10;
            this.label6.Text = "年  龄：";
            // 
            // txt_comments
            // 
            this.txt_comments.Location = new System.Drawing.Point(70, 187);
            this.txt_comments.Name = "txt_comments";
            this.txt_comments.Size = new System.Drawing.Size(166, 21);
            this.txt_comments.TabIndex = 5;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(70, 147);
            this.txt_id.MaxLength = 18;
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(166, 21);
            this.txt_id.TabIndex = 4;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(70, 27);
            this.txt_name.MaxLength = 4;
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(166, 21);
            this.txt_name.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "备  注：\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "身份证：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "性  别：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓  名：";
            // 
            // panel_right
            // 
            this.panel_right.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_right.Controls.Add(this.gb_detail);
            this.panel_right.Controls.Add(this.gb_basic);
            this.panel_right.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_right.Location = new System.Drawing.Point(250, 0);
            this.panel_right.Name = "panel_right";
            this.panel_right.Size = new System.Drawing.Size(758, 660);
            this.panel_right.TabIndex = 1;
            // 
            // gb_detail
            // 
            this.gb_detail.Controls.Add(this.dg_detail);
            this.gb_detail.ForeColor = System.Drawing.Color.ForestGreen;
            this.gb_detail.Location = new System.Drawing.Point(5, 329);
            this.gb_detail.Name = "gb_detail";
            this.gb_detail.Size = new System.Drawing.Size(748, 318);
            this.gb_detail.TabIndex = 1;
            this.gb_detail.TabStop = false;
            this.gb_detail.Text = "[挂号明细信息]";
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
            this.dg_detail.Location = new System.Drawing.Point(6, 30);
            this.dg_detail.Name = "dg_detail";
            this.dg_detail.RowTemplate.Height = 23;
            this.dg_detail.Size = new System.Drawing.Size(734, 282);
            this.dg_detail.TabIndex = 1;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "ID";
            this.Column8.HeaderText = "编号";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Department";
            this.Column9.HeaderText = "科室";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Doctor";
            this.Column10.HeaderText = "医生";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Pay";
            this.Column11.HeaderText = "挂号金额";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "RealPay";
            this.Column12.HeaderText = "实收金额";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "ChargeBack";
            this.Column13.HeaderText = "找零金额";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.DataPropertyName = "RegisterDate";
            this.Column14.HeaderText = "日期";
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            this.Column14.Width = 150;
            // 
            // gb_basic
            // 
            this.gb_basic.Controls.Add(this.dg_basic);
            this.gb_basic.ForeColor = System.Drawing.Color.ForestGreen;
            this.gb_basic.Location = new System.Drawing.Point(5, 6);
            this.gb_basic.Name = "gb_basic";
            this.gb_basic.Size = new System.Drawing.Size(748, 303);
            this.gb_basic.TabIndex = 0;
            this.gb_basic.TabStop = false;
            this.gb_basic.Text = "[挂号基本资料]";
            // 
            // dg_basic
            // 
            this.dg_basic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_basic.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column6,
            this.Column5,
            this.Column7});
            this.dg_basic.Location = new System.Drawing.Point(6, 36);
            this.dg_basic.Name = "dg_basic";
            this.dg_basic.RowTemplate.Height = 23;
            this.dg_basic.Size = new System.Drawing.Size(734, 261);
            this.dg_basic.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "编号";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "姓名";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Sex";
            this.Column3.HeaderText = "性别";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Age";
            this.Column4.HeaderText = "年龄";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Comments";
            this.Column6.HeaderText = "备注";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "IdentityCardNumber";
            this.Column5.HeaderText = "身份证";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "RegisterDate";
            this.Column7.HeaderText = "日期";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 660);
            this.Controls.Add(this.panel_right);
            this.Controls.Add(this.panel_left);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registration";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registration";
            this.panel_left.ResumeLayout(false);
            this.panel_left.PerformLayout();
            this.gb_department.ResumeLayout(false);
            this.gb_department.PerformLayout();
            this.gb_patient.ResumeLayout(false);
            this.gb_patient.PerformLayout();
            this.panel_right.ResumeLayout(false);
            this.gb_detail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_detail)).EndInit();
            this.gb_basic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dg_basic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel_right;
        private System.Windows.Forms.GroupBox gb_patient;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox txt_comments;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_sex;
        private System.Windows.Forms.TextBox txt_age;
        private System.Windows.Forms.GroupBox gb_department;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cb_department;
        private System.Windows.Forms.TextBox txt_pay;
        private System.Windows.Forms.TextBox txt_chargeback;
        private System.Windows.Forms.TextBox txt_actualpay;
        private System.Windows.Forms.ComboBox cb_doctor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_clean;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.GroupBox gb_basic;
        private System.Windows.Forms.GroupBox gb_detail;
        private System.Windows.Forms.DataGridView dg_basic;
        private System.Windows.Forms.DataGridView dg_detail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}