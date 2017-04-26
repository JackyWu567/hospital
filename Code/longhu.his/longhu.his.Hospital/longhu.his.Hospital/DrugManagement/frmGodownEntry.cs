using longhu.his.Business;
using longhu.his.Common;
using longhu.his.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace longhu.his.Hospital.DrugManagement
{
    public partial class frmGodownEntry : Form
    {
        public sys_users CurrentUser;
        private DrugEntryModel _drugEntryModel;
        private readonly DrugsManager gdManager = new DrugsManager();

        #region 构造函数

        public frmGodownEntry()
        {
            _drugEntryModel = new DrugEntryModel();
            InitializeComponent();
        }

        // 只读模式 构造函数
        public frmGodownEntry(bool isreadonly, DrugEntryModel drugEntry)
        {
            InitializeComponent();

            if (drugEntry == null)
            {
                MessageBox.Show("打开入库单操作失败，请稍后重试！", "出错啦", MessageBoxButtons.OK);
                return;
            }

            _drugEntryModel = drugEntry;

            Utilities.bindPropertiesToCtl(_drugEntryModel, this);
            SetReadonlyState();
        }

        #endregion

        #region 入库单 管理

        // 新建入库单
        private void btnNewDrugEntry_Click(object sender, EventArgs e)
        {
            this._drugEntryModel = null;
            this._drugEntryModel = new DrugEntryModel();
            // 重新绑定空值到form表单控件
            Utilities.bindPropertiesToCtl(_drugEntryModel, this);
        }

        // 撤销 新建
        private void btnCancelEntry_Click(object sender, EventArgs e)
        {

        }

        // 保存入库单
        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            var sources = this.dgvDurgEntries.DataSource as List<DrugEntryDvItem>;
            if (sources == null)
            {
                MessageBox.Show("获取入库但数据失败！", "提示", MessageBoxButtons.OK);
                return;
            }

            try
            {
                godown_entry entry = null;
                godown_entry_details details = null;
                foreach (var item in sources)
                {
                    entry = new godown_entry
                    {
                        billNumer = item.InvoiceCode,
                        bill_date = item.InvoiceDate,
                        Createdby = CurrentUser.Account,
                        Delete_flag = 0,
                        Created_date = item.EntryDate,
                        drug_entryType_id = drug_entryType.Get(item.EntryType).Id,
                        Entry_user_id = CurrentUser.Id, // 入库单创建人
                        purchase_auditor_id = 0,
                        purchase_note_id = item.EntryNoteNo,
                        Status = 0,
                        Updatedby = CurrentUser.Account,
                        Updated_date = item.EntryDate
                    };

                    entry.Create();

                    details = new godown_entry_details
                    {
                        godown_entry_Id       = godown_entry.GetByPurchaseNoteNo(item.EntryNoteNo).Id,
                        supplier_id           =drug_supplier.Get(item.Supplier).Id,
                        dg_Category_id        = drug_categories.Get(int.Parse(item.DrugCategory)).Id,
                        dg_specification_id   = drug_specification.Get(int.Parse(item.DrugSpecification)).id,
                        dg_units_id           =drug_units.Get(int.Parse(item.DrugUnits)).Id,

                        dg_name               =item.DrugName,
                        dg_name_ab            = Utilities.GetSpellCode(item.DrugName),
                        Description           =item.DrugName,
                        dg_brand              ="",
                        dg_plant              ="",
                        dg_price              =item.PurchasePrice,
                        Amount                =item.Amount,
                        Created_date          =item.EntryDate,
                        Createdby             =CurrentUser.Account,
                        Updated_date          =item.EntryDate,
                        Updatedby             =CurrentUser.Account,
                        Delete_flag           =0,
                        remark                =item.Remark,
                        dg_codes              =item.DrugCodes,
                        dg_ProduceArea        =item.ProduceArea,
                        dg_last_price         =item.LastPurchasePrice,
                        dg_whole_price        =item.WholeSalePrice,
                        drug_Packer           =item.DrugPacker,
                        dg_sales_price        =item.SalePrice,
                        Drug_batch_number     =item.DurgBatchNumber,
                        Dicount_rate          =item.PurchaserDiscount,
                        Default_discount_rate =item.DefaultDiscount,
                        dg_expiration_date    =item.ExpiredDate

                    };

                    details.Create();

                }
            }
            catch
            {
                MessageBox.Show("数据保存失败！", "提示", MessageBoxButtons.OK);
            }

        }

        //打印
        private void btnPrintEntry_Click(object sender, EventArgs e)
        {

        }

        // 记账
        private void btnKeepAccount_Click(object sender, EventArgs e)
        {

        }

        // 退出
        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 药品/药典 管理

        /// <summary>
        /// 药品字典维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDrugDictionaryMaintance_Click(object sender, EventArgs e)
        {
            // 需要弹出药品字典管理界面
        }

        //增加药品入库单据
        private void btnEntryDrug_Click(object sender, EventArgs e)
        {
            _drugEntryModel.DrugEntryDvItems.Add(new DrugEntryDvItem
            {
                // godown_entry_details properties
                DrugName = this.textDrugName.Text.Trim(),
                DrugCodes = this.textDrugCode.Text.Trim(),
                DrugSpecification = this.cmbxDgSpecific.SelectedValue.ToString(),
                DrugUnits = this.cmbxDgUnits.SelectedValue.ToString(),
                DrugCategory = this.cmbxDgCategory.SelectedValue.ToString(),
                ProduceArea = this.textProduceArea.Text.Trim(),
                WholeSalePrice = decimal.Parse(this.textWholeSalePrice.Text.Trim()),
                SalePrice = decimal.Parse(this.textSalesPrice.Text.Trim()),
                DrugPacker = this.textPackingCompany.Text.Trim(),
                LastPurchasePrice = decimal.Parse(this.textLastPurchasePrice.Text.Trim()),
                Amount = decimal.Parse(this.textAmount.Text.Trim()),
                PurchasePriceTotal = decimal.Parse(this.textPurchasePriceAmout.Text.Trim()),
                PurchasePrice = decimal.Parse(this.textLastPurchasePrice.Text.Trim()),
                PurchaserDiscount = decimal.Parse(this.textPurchaseDiscount.Text.Trim()),
                DefaultDiscount = decimal.Parse(textDefaultDiscount.Text.Trim()),
                DurgBatchNumber = this.textDrugBatchNumber.Text.Trim(),
                ExpiredDate = this.dtpExpirationDate.Value,
                Remark = this.textRemark.Text.Trim(),

                // godown_entry properties
                EntryDate = this.dtp_Entry_date.Value,
                EntryNoteNo = this.textGodownEntryNo.Text.Trim(),
                EntryType = this.cmbEntryType.SelectedValue.ToString(),
                InvoiceCode = this.textInvoiceCode.Text.Trim(),
                InvoiceDate = this.dtp_Bill_note.Value,
                Supplier = this.textSupplier.Text.Trim()
            });
            // refresh gridview
            this.dgvDurgEntries.DataSource = _drugEntryModel.DrugEntryDvItems;
        }

        // 删除单据数据
        private void btnDeleteDrugEntry_Click(object sender, EventArgs e)
        {
            try
            {
                var item = this.dgvDurgEntries.SelectedRows[0].DataBoundItem as DrugEntryDvItem;
                _drugEntryModel.DrugEntryDvItems.Remove(_drugEntryModel.DrugEntryDvItems.Find(m => m.EntryNoteNo == item.EntryNoteNo));
            }
            catch
            {
                MessageBox.Show("删除单据数据出错", "提示", MessageBoxButtons.OK);
            }
        }

        //修改
        private void btnChgDrugEntry_Click(object sender, EventArgs e)
        {

        }

        // 单击gridview 行 激活 修改/删除按钮
        private void dgvDurgEntries_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.btnDeleteDrugEntry.Enabled = true;
            this.btnChgDrugEntry.Enabled = true;
            // Set textbox combox values
            var dgv = sender as DataGridView;
            if (dgv != null)
            {
                var source = dgv.DataSource as List<DrugEntryDvItem>;
                if (source != null)
                {
                    var selected = source[e.RowIndex] as DrugEntryDvItem;
                    foreach(var ctl in this.Controls)
                    {
                        switch (ctl.GetType().Name)
                        {
                            case "cmbEntryType":
                                ((ComboBox)ctl).SelectedIndex = drug_entryType.Get(selected.EntryType).Id;
                                break;
                            case "textSupplier":
                                break;
                            case "dtp_Entry_date":
                                break;
                            case "textGodownEntryNo":
                                break;
                            case "textInvoiceCode":
                                break;
                            case "dtp_Bill_note":
                                break;
                            case "textDrugCode":
                                break;
                            case "cmbxDgSpecific":
                                break;
                            case "cmbxDgUnits":
                                break;
                            case "cmbxDgCategory":
                                break;
                            case "textDrugName":
                                break;
                            case "textWholeSalePrice":
                                break;
                            case "textSalesPrice":
                                break;
                            case "textProduceArea":
                                break;
                            case "textLastPurchasePrice":
                                break;
                            case "textAmount":
                                break;
                            case "textPurchasePriceAmout":
                                break;
                            case "textPurchasePrice":
                                break;
                            case "dtpExpirationDate":
                                break;
                            case "textPurchaseDiscount":
                                break;
                            case "textDefaultDiscount":
                                break;
                            case "textDrugBatchNumber":
                                break;
                            case "textPackingCompany":
                                break;
                            case "textRemark":
                                break;

                        }
                    }
                }
            }
        }

        #endregion

        #region 辅助函数

        private void SetReadonlyState()
        {
            foreach (var ctl in this.Controls)
            {
                if (ctl.GetType() == typeof(TextBox))
                {
                    ((TextBox)ctl).ReadOnly = true;
                }
                else if (ctl.GetType() == typeof(ComboBox))
                {
                    ((ComboBox)ctl).Enabled = false;
                }
                else if (ctl.GetType() == typeof(DateTimePicker))
                {
                    ((DateTimePicker)ctl).Enabled = false;
                }
                else if (ctl.GetType() == typeof(Button))
                {
                    ((Button)ctl).Enabled = false;
                }
                else if (ctl.GetType() == typeof(CheckBox))
                {
                    ((CheckBox)ctl).Enabled = false;
                }
                else
                {

                }
            }
        }

        private void UpdateStatusStrip()
        {
            // 记录数
            this.tsStatusLbl_RecordAmout.Text = _drugEntryModel.DrugEntryDvItems.Count.ToString();
            // 当前药品售价金额
            if (!string.IsNullOrEmpty(this.textSalesPrice.Text.Trim()) && string.IsNullOrEmpty(this.textAmount.Text.Trim()))
            {
                this.tsStatusLbl_SalesPrice.Text = (decimal.Parse(this.textSalesPrice.Text.Trim()) * (decimal.Parse(this.textAmount.Text.Trim()))).ToString();
            }
            // 进价金额
            if (!string.IsNullOrEmpty(this.textLastPurchasePrice.Text.Trim()) && string.IsNullOrEmpty(this.textAmount.Text.Trim()))
            {
                this.tsStatusLbl_PurchasePriceAmout.Text = (decimal.Parse(this.textLastPurchasePrice.Text.Trim()) * (decimal.Parse(this.textAmount.Text.Trim()))).ToString();
            }

            if (!string.IsNullOrEmpty(this.tsStatusLbl_SalesPrice.Text) && !string.IsNullOrEmpty(this.tsStatusLbl_SalesPrice.Text))
            {
                this.tsStatusLbl_PPrice_Sprice_banlance.Text = (decimal.Parse(this.tsStatusLbl_SalesPrice.Text) - decimal.Parse(this.tsStatusLbl_PurchasePriceAmout.Text)).ToString();
            }
        }

        #endregion

    }
}
