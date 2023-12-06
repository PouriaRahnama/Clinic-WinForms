using Clinic.Data.Entities;
using Clinic.DataLayer;
using ValidationComponents;

namespace Clinic.App.Patient_Visit
{
    public partial class PatientVisit : Form
    {
        public int frmid = 0;
        public PatientVisit()
        {
            InitializeComponent();
        }

        private void PatientVisit_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                var Patient = db.receptionService.GetById(frmid);
                txtDateTime.Text = Patient.Data.ToString("yyyy/MM/dd");
                txtNamePatient.Text = db.patietInfoService.GetPatientNameById(Patient.PatientId);
                txtPay.Text = Patient.CostOfVisit.ToString("#,0");
                txtReason.Text = Patient.Reason;
                txtTime.Text = Patient.Time.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    PatientReport patient_Doctor = new PatientReport()
                    {
                        ReceptionId = db.receptionService.GetById(frmid).Id,
                        Description = txtDescriptionDoctor.Text,
                        DoctorName = txtDoctor.Text,
                        medicine = txtMedicine.Text,
                    };               
                    db.patientReportService.CreatePatientReport(patient_Doctor);              
                    db.Save();             
                }
                DialogResult = DialogResult.OK;
                MessageBox.Show("عملیات با موفقیت انجام شد");
            }
        }
    }
}
