using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using longhu.his.Model.ViewModel;
using longhu.his.Model;

namespace longhu.his.Hospital.OutpatientsManagement
{
    public partial class FrmMedicalRecords : Form
    {
        private List<VMRegisteration> patList;
        private List<Prescription> prescriptionList;
        private List<PrescriptionDrug> drugsList;
        public FrmMedicalRecords()
        {
            InitializeComponent();
            LoadPatients();
        }

        private void LoadPatients()
        {
            InitPatientList();
            this.dgvPatients.AutoGenerateColumns = false;
            this.dgvPatients.DataSource = patList;
        }

        private void InitPatientList()
        {
            if (null == patList)
            {
                patList = new List<VMRegisteration>();
            }
            string[] patNames = { "张军", "吴兆", "李浩", "刘亚男", "魏海军", "王曼丽", };
            int[] patAges = { 28, 31, 65, 33, 42, 19 };
            string[] patGender = { "男", "女" };
            string[] doctors = { "张新生", "马爱军", "吴秀丽" };
            for (int i = 0; i < 6; i++)
            {
                VMPatient patient = new VMPatient()
                {
                    
                };
                VMRegisteration model = new VMRegisteration()
                {
                    ID = i + 1,
                    Age = patAges[i],
                    Name = patNames[i],
                    Sex = i % 3 == 0 ? patGender[0] : patGender[1],
                    Department = "内科",
                    Doctor = doctors[(i % 3)],
                    RegisterDate = DateTime.Now.ToString()
                };
                patList.Add(model);
            }
        }

        private void btnAddDrug_Click(object sender, EventArgs e)
        {
            string drugName = this.txtDrugName.Text.Trim();
            string drugQuantity = this.cbDrugQuantity.Text;
            string drugMethod = this.txtDrugMethod.Text.Trim();
            if (string.IsNullOrWhiteSpace(drugName))
            {
                MessageBox.Show("请填写药品名称");
                return;
            }
            if (null == drugsList)
            {
                drugsList = new List<PrescriptionDrug>();
            }
            PrescriptionDrug drug = new PrescriptionDrug()
            {
                DrugName = drugName,
                DrugQuantity = drugQuantity,
                DrugMethod = drugMethod
            };
            drugsList.Add(drug);
            this.dgvPrescription.AutoGenerateColumns = false;
            this.dgvPrescription.DataSource = null;
            this.dgvPrescription.DataSource = drugsList;
            ClearDrugInfo();
        }

        private void ClearDrugInfo()
        {
            this.txtDrugName.Text = string.Empty;
            this.cbDrugQuantity.Text = string.Empty;
            this.txtDrugMethod.Text = string.Empty;
        }

        private void dgvPatients_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ID = Convert.ToInt32(e.RowIndex + 1);
            VMRegisteration pat = patList.Where(p => p.ID == ID).FirstOrDefault();
            if (null != pat)
            {
                this.txtPatientName.Text = pat.Name;
                this.cbGender.Text = pat.Sex;
                this.txtAge.Text = pat.Age.ToString();
                this.cbDepartment.Text = pat.Department;
                this.cbDoctor.Text = pat.Doctor;
                this.txtFirstDate.Text = pat.RegisterDate == null ? "" : Convert.ToDateTime(pat.RegisterDate).ToShortDateString();
            }
        }

        private void 处方ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrescriptionMgr prescription = new FrmPrescriptionMgr();
            prescription.Show();
            this.Hide();
        }

        private void FrmMedicalRecords_Load(object sender, EventArgs e)
        {
            this.dgvPatients.ClearSelection();
        }

        private void btnSavePrescription_Click(object sender, EventArgs e)
        {
            if (null == prescriptionList)
            {
                prescriptionList = new List<Prescription>();
            }
            if (null != drugsList)
            {
                string patientName = this.txtPatientName.Text;
                Prescription model = new Prescription()
                {
                    NO = prescriptionList == null ? 1 : prescriptionList.Count + 1,
                    Name = string.Format("{0} - 处方 - {1}", patientName, prescriptionList == null ? 1 : prescriptionList.Count + 1),
                    GrugList = drugsList
                };
                prescriptionList.Add(model);
                this.dgvPrescriptionList.DataSource = null;
                this.dgvPrescriptionList.AutoGenerateColumns = false;
                this.dgvPrescriptionList.DataSource = prescriptionList;
                this.dgvPrescription.DataSource = null;
            }
        }
    }
}
