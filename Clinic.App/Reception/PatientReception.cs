using Clinic.Data.Entities;
using Clinic.DataLayer;
using ValidationComponents;

namespace Clinic.App.Patient_Reception
{
    public partial class PatientReception : Form
    {
        public int AccountID = 0;
        public PatientReception()
        {
            InitializeComponent();
        }

        private void PatientReception_Load(object sender, EventArgs e)
        {
            if (AccountID == 0)
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    dgName.AutoGenerateColumns = false;
                    dgName.DataSource = db.patietInfoService.GetPatientName();
                }
            }
            else
            {
                using (UnitOfWork db = new UnitOfWork())
                {

                    var account = db.receptionService.GetById(AccountID);
                    txtPay.Text = account.CostOfVisit.ToString();
                    txtReason.Text = account.Reason;
                    txtTime.Text = account.Time.ToString();
                    txtDateTime.Text = account.Data.ToString("yyyy/MM/dd");
                    txtNamePatient.Text = db.patietInfoService.GetPatientNameById(account.PatientId);
                    txtSearch.Text = txtNamePatient.Text;
                    this.Text = "ویرایش";
                    btnSave.Text = "ویرایش";
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                dgName.AutoGenerateColumns = false;
                dgName.DataSource = db.patietInfoService.GetPatientName(txtSearch.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork db = new UnitOfWork())
                {
                    Reception reception = new Reception()
                    {
                        PatientId = db.patietInfoService.GetPatientIdByName(txtNamePatient.Text),
                        Reason = txtReason.Text,
                        CostOfVisit = Convert.ToDecimal(txtPay.Text.ToString()),
                        Data = Convert.ToDateTime(txtDateTime.Text),
                        Time = TimeSpan.Parse(txtTime.Text),
                        Status = ReceptionStatus.NoVisit
                    };

                    if (AccountID == 0)
                    {
                        db.receptionService.Insert(reception);
                    }
                    else
                    {
                        reception.Id = AccountID;
                        db.receptionService.Update(reception);
                    }

                    db.Save();
                    DialogResult = DialogResult.OK;
                }


            }
        }

        private void dgName_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNamePatient.Text = dgName.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
