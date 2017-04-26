using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using longhu.his.Model;

namespace longhu.his.Hospital.DrugManagement
{
    public partial class FrmDrugManageMain : Form
    {
        public sys_users UserInfo { get; set; }

        public FrmDrugManageMain()
        {
            InitializeComponent();
        }

        private void tsmItem_GodownEntry_Click(object sender, EventArgs e)
        {
            frmDrugsEntryManagement frmDrugEntryMgm = new frmDrugsEntryManagement();
            frmDrugEntryMgm.MdiParent = this;
            frmDrugEntryMgm.Show();
        }
    }
}
