using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using longhu.his.Business;
using longhu.his.Model;
using longhu.his.Common;
using longhu.his.Hospital.DrugManagement;

namespace longhu.his.Hospital
{
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (Utilities.VerifyUserStringEnter(this.textUsername.Text.Trim()) && Utilities.VerifyUserStringEnter(this.textPassword.Text.Trim()))
            {
                UserManager usrMgr = new UserManager();
                sys_users user=null;
                if(usrMgr.VerfyUserLogin(this.textUsername.Text.Trim(), this.textPassword.Text.Trim(),out user))
                {
                    this.Hide();

                    if (user.UserRoles.Roles[0].Id == 3)
                    {
                        registration.Main main = new registration.Main(user);
                        main.Show();
                    }
                    if (user.UserRoles.Roles[0].Id == 2)
                    {
                        OutpatientsManagement.FrmMedicalRecords form = new OutpatientsManagement.FrmMedicalRecords();
                        form.Show();
                    }
                    if (user.UserRoles.Roles[0].Id == 1)
                    {
                        FrmDrugManageMain frmDrugMgrMain = new FrmDrugManageMain();
                        frmDrugMgrMain.UserInfo = user;
                        frmDrugMgrMain.Show();
                    }                    
                }
                else
                {
                    MessageBox.Show("用户名或密码错误！请重新输入。", "提示", MessageBoxButtons.OK);
                }
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Frm_login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.Handled && (e.KeyChar == 13 || e.KeyChar.ToString() == Keys.Enter.ToString()))
            {
                btnLogin_Click(sender, null);
            }
        }

        private void Frm_login_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    btnLogin_Click(sender, null);
            //}
        }

        private void textPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!e.Handled && (e.KeyChar == 13 || e.KeyChar.ToString() == Keys.Enter.ToString()))
            {
                btnLogin_Click(sender, null);
            }
        }
    }
}
