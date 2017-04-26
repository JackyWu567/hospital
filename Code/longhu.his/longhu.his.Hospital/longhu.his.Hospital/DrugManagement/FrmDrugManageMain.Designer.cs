namespace longhu.his.Hospital.DrugManagement
{
    partial class FrmDrugManageMain
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
            this.ms_WarehouseManagement = new System.Windows.Forms.MenuStrip();
            this.tsmItem_DrugWarehouseMgm = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_Depart_GetMedicine = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_GodownEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_WarehouseVerify = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_DeliveryCanceled = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_AdditionalBIllNo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_ReturnDrugs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_DrugDelivery = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmItem_GetMedicineEx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_DepartReturnDrugs = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_StockTaking = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_StockTakingEx = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_AdjustDrugPrice = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmItem_RecordDamage = new System.Windows.Forms.ToolStripMenuItem();
            this.ms_WarehouseManagement.SuspendLayout();
            this.SuspendLayout();
            // 
            // ms_WarehouseManagement
            // 
            this.ms_WarehouseManagement.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItem_DrugWarehouseMgm,
            this.tsmItem_Depart_GetMedicine,
            this.tsmItem_StockTaking});
            this.ms_WarehouseManagement.Location = new System.Drawing.Point(0, 0);
            this.ms_WarehouseManagement.Name = "ms_WarehouseManagement";
            this.ms_WarehouseManagement.Size = new System.Drawing.Size(1309, 25);
            this.ms_WarehouseManagement.TabIndex = 1;
            this.ms_WarehouseManagement.Text = "药房库存管理菜单";
            // 
            // tsmItem_DrugWarehouseMgm
            // 
            this.tsmItem_DrugWarehouseMgm.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItem_GodownEntry,
            this.tsmItem_AdditionalBIllNo,
            this.tsmItem_ReturnDrugs,
            this.toolStripSeparator1,
            this.tsmItem_DrugDelivery,
            this.tsmItem_WarehouseVerify,
            this.tsmItem_DeliveryCanceled});
            this.tsmItem_DrugWarehouseMgm.Name = "tsmItem_DrugWarehouseMgm";
            this.tsmItem_DrugWarehouseMgm.Size = new System.Drawing.Size(92, 21);
            this.tsmItem_DrugWarehouseMgm.Text = "药房库存管理";
            // 
            // tsmItem_Depart_GetMedicine
            // 
            this.tsmItem_Depart_GetMedicine.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItem_GetMedicineEx,
            this.tsmItem_DepartReturnDrugs});
            this.tsmItem_Depart_GetMedicine.Name = "tsmItem_Depart_GetMedicine";
            this.tsmItem_Depart_GetMedicine.Size = new System.Drawing.Size(68, 21);
            this.tsmItem_Depart_GetMedicine.Text = "科室发药";
            // 
            // tsmItem_GodownEntry
            // 
            this.tsmItem_GodownEntry.Name = "tsmItem_GodownEntry";
            this.tsmItem_GodownEntry.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_GodownEntry.Text = "药品入库";
            this.tsmItem_GodownEntry.Click += new System.EventHandler(this.tsmItem_GodownEntry_Click);
            // 
            // tsmItem_WarehouseVerify
            // 
            this.tsmItem_WarehouseVerify.Name = "tsmItem_WarehouseVerify";
            this.tsmItem_WarehouseVerify.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_WarehouseVerify.Text = "药品盘点";
            // 
            // tsmItem_DeliveryCanceled
            // 
            this.tsmItem_DeliveryCanceled.Name = "tsmItem_DeliveryCanceled";
            this.tsmItem_DeliveryCanceled.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_DeliveryCanceled.Text = "入库撤销";
            // 
            // tsmItem_AdditionalBIllNo
            // 
            this.tsmItem_AdditionalBIllNo.Name = "tsmItem_AdditionalBIllNo";
            this.tsmItem_AdditionalBIllNo.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_AdditionalBIllNo.Text = "在途冲正";
            // 
            // tsmItem_ReturnDrugs
            // 
            this.tsmItem_ReturnDrugs.Name = "tsmItem_ReturnDrugs";
            this.tsmItem_ReturnDrugs.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_ReturnDrugs.Text = "药品退货";
            // 
            // tsmItem_DrugDelivery
            // 
            this.tsmItem_DrugDelivery.Name = "tsmItem_DrugDelivery";
            this.tsmItem_DrugDelivery.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_DrugDelivery.Text = "药品出库";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // tsmItem_GetMedicineEx
            // 
            this.tsmItem_GetMedicineEx.Name = "tsmItem_GetMedicineEx";
            this.tsmItem_GetMedicineEx.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_GetMedicineEx.Text = "科室发药";
            // 
            // tsmItem_DepartReturnDrugs
            // 
            this.tsmItem_DepartReturnDrugs.Name = "tsmItem_DepartReturnDrugs";
            this.tsmItem_DepartReturnDrugs.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_DepartReturnDrugs.Text = "科室退药";
            // 
            // tsmItem_StockTaking
            // 
            this.tsmItem_StockTaking.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmItem_StockTakingEx,
            this.tsmItem_AdjustDrugPrice,
            this.tsmItem_RecordDamage});
            this.tsmItem_StockTaking.Name = "tsmItem_StockTaking";
            this.tsmItem_StockTaking.Size = new System.Drawing.Size(116, 21);
            this.tsmItem_StockTaking.Text = "药房管理系统菜单";
            // 
            // tsmItem_StockTakingEx
            // 
            this.tsmItem_StockTakingEx.Name = "tsmItem_StockTakingEx";
            this.tsmItem_StockTakingEx.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_StockTakingEx.Text = "库存盘点";
            // 
            // tsmItem_AdjustDrugPrice
            // 
            this.tsmItem_AdjustDrugPrice.Name = "tsmItem_AdjustDrugPrice";
            this.tsmItem_AdjustDrugPrice.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_AdjustDrugPrice.Text = "药品调价";
            // 
            // tsmItem_RecordDamage
            // 
            this.tsmItem_RecordDamage.Name = "tsmItem_RecordDamage";
            this.tsmItem_RecordDamage.Size = new System.Drawing.Size(152, 22);
            this.tsmItem_RecordDamage.Text = "药品报损";
            // 
            // FrmDrugManageMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 717);
            this.Controls.Add(this.ms_WarehouseManagement);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.ms_WarehouseManagement;
            this.MaximizeBox = false;
            this.Name = "FrmDrugManageMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "门诊管理系统 - 药房管理";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ms_WarehouseManagement.ResumeLayout(false);
            this.ms_WarehouseManagement.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip ms_WarehouseManagement;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_DrugWarehouseMgm;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_GodownEntry;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_AdditionalBIllNo;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_ReturnDrugs;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_WarehouseVerify;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_DeliveryCanceled;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_Depart_GetMedicine;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_DrugDelivery;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_GetMedicineEx;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_DepartReturnDrugs;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_StockTaking;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_StockTakingEx;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_AdjustDrugPrice;
        private System.Windows.Forms.ToolStripMenuItem tsmItem_RecordDamage;
    }
}