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

namespace longhu.his.Hospital.DrugManagement
{
    public partial class frmDrugsEntryManagement : Form
    {
        DrugsManager drugMgr = new DrugsManager();

        public frmDrugsEntryManagement()
        {
            InitializeComponent();
        }

        #region Form Events

        private void frmDrugsEntryManagement_Load(object sender, EventArgs e)
        {
            if (drugMgr == null) drugMgr = new DrugsManager();
            try
            {
                var source = drugMgr.GetNotNotedEntries();
                if (source != null && source.Count > 0)
                {
                    this.dataGridView.DataSource = source;
                }
            }
            catch
            {
            }

        }

        #endregion

        #region Button Events

        /// <summary>
        /// 根据发票号码，供货商地址查询  模糊查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (drugMgr == null) drugMgr = new DrugsManager();
            try
            {
                var source = new List<DrugsNotNotedEntryModel>();
                if (this.cbxBillNo.Checked || this.cbxSupplier.Checked)
                    source = drugMgr.GetNotNotedEntriesByInvoiceAndSupplier(this.textBillNumer.Text.Trim(), this.textSupplier.Text.Trim());
                else
                {
                    source = drugMgr.GetNotNotedEntries();
                }

                if (source != null && source.Count > 0)
                {
                    this.dataGridView.DataSource = source;
                }
            }
            catch
            {
                MessageBox.Show("查询出错了！", "提示", MessageBoxButtons.OK);
            }
        }
        
        /// <summary>
        /// 新建入库单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCreateGodownEntry_Click(object sender, EventArgs e)
        {
            frmGodownEntry godown = new frmGodownEntry();
            godown.Show();
            this.Hide();

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (this.cbxBillNo.Checked)
            {

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAuditing_Click(object sender, EventArgs e)
        {
            // 复核以后 入库操作结束
        }

        /// <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

#endregion

        #region GridView Events

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (sender as DataGridView);
            if (dgv != null)
            {
                var source = dgv.DataSource as List<DrugsNotNotedEntryModel>;
                if (source != null)
                {
                    try
                    {
                        this.textBillNumer.Text = source[e.RowIndex].InvoiceCode;
                        this.textSupplier.Text = source[e.RowIndex].SupplierAddress;
                    }
                    catch
                    {

                    }
                }
            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = (sender as DataGridView);
            if (dgv != null)
            {
                var source = dgv.DataSource as List<DrugsNotNotedEntryModel>;
                if (source != null)
                {
                    try
                    {
                        this.textBillNumer.Text = source[e.RowIndex].InvoiceCode;
                        this.textSupplier.Text = source[e.RowIndex].SupplierAddress;
                    }
                    catch
                    {

                    }
                }
            }
        }

        /// <summary>
        /// 双击 数据行 打开入库单详细信息界面-- 入库单界面（只读）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var dgv = (sender as DataGridView);
            if (dgv != null)
            {
                var source = dgv.DataSource as List<DrugsNotNotedEntryModel>;
                if (source != null) {
                    var NoteNum = source[e.RowIndex].PurchaseNoteId;
                    DrugEntryModel model = new DrugEntryModel(NoteNum);
                    frmGodownEntry godown = new frmGodownEntry(true, model);
                    godown.Show();
                }
            }
        }

        #endregion

        #region CheckBox Events

        private void cbxSupplier_CheckedChanged(object sender, EventArgs e)
        {
            this.textBillNumer.Enabled = ((CheckBox)sender).Checked;
        }

        private void cbxBillNo_CheckedChanged(object sender, EventArgs e)
        {
            this.textSupplier.Enabled = ((CheckBox)sender).Checked;
        }

        #endregion

    }
}
