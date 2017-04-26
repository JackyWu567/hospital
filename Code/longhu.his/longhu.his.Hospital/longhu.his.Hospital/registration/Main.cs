using longhu.his.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace longhu.his.Hospital.registration
{
    public partial class Main : Form
    {
        public sys_users m_user;

        public Main(sys_users user)
        {
            this.m_user = user;
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            tssl_name.Text = m_user.userName;
            tssl_type.Text = m_user.UserRoles.Roles[0].Rolename;
            tssl_time.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            time.Start();
        }

        private void tsmi_registered_Click(object sender, EventArgs e)
        {
            CleanMainFormControls();

            Registration reg = new Registration();
            reg.MdiParent = this;
            panel_main.Controls.Add(reg);
            reg.Show();
        }

        private void tsmi_search_Click(object sender, EventArgs e)
        {
            
            CleanMainFormControls();

            Search search = new Search();
            search.MdiParent = this;
            panel_main.Controls.Add(search);
            search.Show();
        }

        private void CleanMainFormControls()
        {
            panel_main.Controls.Clear();
        }

        private void tsmi_exist_Click(object sender, EventArgs e)
        {
            this.Close();

            Frm_login login = new Frm_login();
            login.Show();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            this.tssl_time.Text = "系统当前时间：" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
