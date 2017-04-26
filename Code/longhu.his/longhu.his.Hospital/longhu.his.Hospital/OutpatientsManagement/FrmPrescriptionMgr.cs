using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace longhu.his.Hospital.OutpatientsManagement
{
    public partial class FrmPrescriptionMgr : Form
    {
        public FrmPrescriptionMgr()
        {
            InitializeComponent();
        }

        private void 病历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMedicalRecords medicalRecords = new FrmMedicalRecords();
            medicalRecords.Show();
            this.Hide();
        }
    }
}
