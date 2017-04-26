using longhu.his.Common;
using longhu.his.Model.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace longhu.his.Hospital.registration
{
    public partial class Registration : Form
    {
        private static readonly string txtPayName = "txt_pay";

        private List<VMRegisteration> list;
        private long regNumber;

        public Registration()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            list = new List<VMRegisteration>();

            dg_basic.AutoGenerateColumns = false;
            dg_detail.AutoGenerateColumns = false;

            dg_basic.ForeColor = Color.Black;
            dg_detail.ForeColor = Color.Black;

            txt_pay.Text = ConfigurationManager.AppSettings["RegisterPayMoney"];

            regNumber = long.Parse(ConfigurationManager.AppSettings["RegStartNumber"]);
        }

        private void btn_clean_Click(object sender, EventArgs e)
        {
            cleanAllControls(gb_patient);
            cleanAllControls(gb_department);
        }

        private void cleanAllControls(Control control)
        {
            foreach (Control ctl in control.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    if (!ctl.Name.Equals(txtPayName))
                    {
                        ctl.Text = string.Empty;
                    }                    
                }
                if (ctl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctl).SelectedItem = null;
                }
                if (ctl.GetType() == typeof(DataGridView))
                {
                    ((DataGridView)ctl).DataSource = null;
                }
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (InputValidation())
            {
                VMRegisteration reg = new VMRegisteration();
                reg.ID = regNumber;
                reg.Name = txt_name.Text.Trim();
                reg.Age = int.Parse(txt_age.Text.Trim());
                reg.Sex = cb_sex.Text;
                reg.IdentityCardNumber = txt_id.Text;

                reg.ChargeBack = GetChargeBack();
                reg.Comments = txt_comments.Text.Trim();
                reg.Department = cb_department.Text;
                reg.Doctor = cb_doctor.Text;
                reg.Pay = decimal.Parse(txt_pay.Text);
                reg.RealPay = decimal.Parse(txt_actualpay.Text);
                reg.RegisterDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                list.Add(reg);

                dg_basic.DataSource = new List<VMRegisteration>();
                dg_basic.DataSource = list;

                dg_detail.DataSource = new List<VMRegisteration>();
                dg_detail.DataSource = list;

                cleanAllControls(gb_patient);
                cleanAllControls(gb_department);

                regNumber++;
            }            
        }

        private decimal GetChargeBack()
        {
            return Utilities.CalculateChargeBack(decimal.Parse(txt_pay.Text), decimal.Parse(txt_actualpay.Text.Trim()));
        }

        private void txt_actualpay_MouseLeave(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txt_actualpay.Text.Trim()))
            {
                txt_actualpay.Text = string.Format("{0:F}", decimal.Parse(txt_actualpay.Text));
                txt_chargeback.Text = string.Format("{0:F}", GetChargeBack());
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool InputValidation()
        {
            if (string.IsNullOrEmpty(txt_name.Text.Trim()))
            {
                ShowErrorDialog("请填写姓名");
                return false;
            }
            if (string.IsNullOrEmpty(cb_sex.Text.Trim()))
            {
                ShowErrorDialog("请选择性别");
                return false;
            }
            if (string.IsNullOrEmpty(txt_age.Text.Trim()))
            {
                ShowErrorDialog("请填写年龄");
                return false;
            }
            if (string.IsNullOrEmpty(txt_id.Text.Trim()))
            {
                ShowErrorDialog("请填写身份证");
                return false;
            }
            if (string.IsNullOrEmpty(cb_department.Text.Trim()))
            {
                ShowErrorDialog("请选择科室");
                return false;
            }
            if (string.IsNullOrEmpty(cb_doctor.Text.Trim()))
            {
                ShowErrorDialog("请选择医生");
                return false;
            }
            if (string.IsNullOrEmpty(txt_actualpay.Text.Trim()))
            {
                ShowErrorDialog("请填写付款金额");
                return false;
            }
            return true;
        }

        private void ShowErrorDialog(string msg)
        {
            MessageBox.Show(msg, "提示信息");
        }
    }
}
