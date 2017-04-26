namespace longhu.his.Hospital.registration
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.MenuStrip ms_main;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tsm_registration = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_registered = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_search = new System.Windows.Forms.ToolStripMenuItem();
            this.tsm_system = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmi_exist = new System.Windows.Forms.ToolStripMenuItem();
            this.ss_main = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_name = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_type = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_time = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel_main = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Timer(this.components);
            ms_main = new System.Windows.Forms.MenuStrip();
            ms_main.SuspendLayout();
            this.ss_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_main
            // 
            ms_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_registration,
            this.tsm_system});
            ms_main.Location = new System.Drawing.Point(0, 0);
            ms_main.Name = "ms_main";
            ms_main.Size = new System.Drawing.Size(1008, 25);
            ms_main.TabIndex = 0;
            ms_main.Text = "menuStrip1";
            // 
            // tsm_registration
            // 
            this.tsm_registration.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_registered,
            this.tsmi_search});
            this.tsm_registration.Name = "tsm_registration";
            this.tsm_registration.Size = new System.Drawing.Size(85, 21);
            this.tsm_registration.Text = "门诊挂号(G)";
            // 
            // tsmi_registered
            // 
            this.tsmi_registered.Name = "tsmi_registered";
            this.tsmi_registered.Size = new System.Drawing.Size(124, 22);
            this.tsmi_registered.Text = "门诊挂号";
            this.tsmi_registered.Click += new System.EventHandler(this.tsmi_registered_Click);
            // 
            // tsmi_search
            // 
            this.tsmi_search.Name = "tsmi_search";
            this.tsmi_search.Size = new System.Drawing.Size(124, 22);
            this.tsmi_search.Text = "挂号查询";
            this.tsmi_search.Click += new System.EventHandler(this.tsmi_search_Click);
            // 
            // tsm_system
            // 
            this.tsm_system.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmi_exist});
            this.tsm_system.Name = "tsm_system";
            this.tsm_system.Size = new System.Drawing.Size(59, 21);
            this.tsm_system.Text = "系统(S)";
            // 
            // tsmi_exist
            // 
            this.tsmi_exist.Name = "tsmi_exist";
            this.tsmi_exist.Size = new System.Drawing.Size(100, 22);
            this.tsmi_exist.Text = "退出";
            this.tsmi_exist.Click += new System.EventHandler(this.tsmi_exist_Click);
            // 
            // ss_main
            // 
            this.ss_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.tssl_name,
            this.toolStripStatusLabel3,
            this.tssl_type,
            this.tssl_time});
            this.ss_main.Location = new System.Drawing.Point(0, 706);
            this.ss_main.Name = "ss_main";
            this.ss_main.Size = new System.Drawing.Size(1008, 26);
            this.ss_main.TabIndex = 1;
            this.ss_main.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(56, 21);
            this.toolStripStatusLabel1.Text = "用户名：";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 21);
            // 
            // tssl_name
            // 
            this.tssl_name.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssl_name.Name = "tssl_name";
            this.tssl_name.Size = new System.Drawing.Size(47, 21);
            this.tssl_name.Text = "Name";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(68, 21);
            this.toolStripStatusLabel3.Text = "用户类型：";
            // 
            // tssl_type
            // 
            this.tssl_type.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.tssl_type.Name = "tssl_type";
            this.tssl_type.Size = new System.Drawing.Size(37, 21);
            this.tssl_type.Text = "type";
            // 
            // tssl_time
            // 
            this.tssl_time.Name = "tssl_time";
            this.tssl_time.Size = new System.Drawing.Size(785, 21);
            this.tssl_time.Spring = true;
            this.tssl_time.Text = "time";
            this.tssl_time.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel_main
            // 
            this.panel_main.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel_main.BackgroundImage")));
            this.panel_main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_main.Location = new System.Drawing.Point(0, 25);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(1008, 681);
            this.panel_main.TabIndex = 0;
            // 
            // time
            // 
            this.time.Interval = 1000;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 732);
            this.Controls.Add(this.panel_main);
            this.Controls.Add(this.ss_main);
            this.Controls.Add(ms_main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = ms_main;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "门诊管理系统 - 门诊挂号";
            ms_main.ResumeLayout(false);
            ms_main.PerformLayout();
            this.ss_main.ResumeLayout(false);
            this.ss_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem tsm_registration;
        private System.Windows.Forms.ToolStripMenuItem tsmi_registered;
        private System.Windows.Forms.ToolStripMenuItem tsmi_search;
        private System.Windows.Forms.StatusStrip ss_main;
        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.ToolStripMenuItem tsm_system;
        private System.Windows.Forms.ToolStripMenuItem tsmi_exist;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tssl_name;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tssl_type;
        private System.Windows.Forms.ToolStripStatusLabel tssl_time;
        private System.Windows.Forms.Timer time;
    }
}