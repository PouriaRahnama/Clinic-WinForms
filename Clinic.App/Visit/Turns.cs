using Clinic.App._Utilities.RtlMessageBox;
using Clinic.App.Patient_Reception;
using Clinic.Data.Entities;
using Clinic.DataLayer;
using System.Data;

namespace Clinic.App.Patient_Visit
{
    public partial class Turns : Form
    {
        public Turns()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PatientVisit frmVisit = new PatientVisit();
            if (dgPatient.CurrentRow != null)
            {
                int id = int.Parse(dgPatient.CurrentRow.Cells[0].Value.ToString());
                frmVisit.frmid = id;
                if (frmVisit.ShowDialog() == DialogResult.OK)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var reception = db.receptionService.GetById(id);
                        reception.Status = ReceptionStatus.Visited;
                        db.receptionService.Update(reception);
                        db.Save();
                    }
                    filter();
                }         
            }
        }


        private void btnRefresh_Click(object sender, EventArgs e)
        {
            filter();
        }

        private void Turns_Load(object sender, EventArgs e)
        {
            filter();
        }

        private void btnUpdateNobat_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow != null)
            {
                int id = int.Parse(dgPatient.CurrentRow.Cells[0].Value.ToString());
                PatientReception frm = new PatientReception();
                frm.AccountID = id;
                if (frm.ShowDialog() == DialogResult.OK)
                {                
                    filter();
                }
            }
        }

        private void btnDeleteNobat_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow != null)
            {

                int id = int.Parse(dgPatient.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آیا از حذف مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        db.receptionService.Delete(id);
                        db.Save();
                        filter();
                    }
                }
            }
        }

        public void filter()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                List<Reception> resualt = new List<Reception>();
                resualt.AddRange(db.receptionService.Get());

                if (txtFromDate.MaskFull)
                {
                    string StartDate = txtFromDate.Text;
                    resualt = resualt.Where(c => c.Data == Convert.ToDateTime(StartDate)).ToList();
                }
                dgPatient.Rows.Clear();
                foreach (var Patient in resualt)
                {
                    string PatientName = db.patietInfoService.GetPatientNameById(Patient.PatientId);
                    dgPatient.Rows.Add(Patient.Id, PatientName, Patient.Reason, Patient.Data.ToString("yyyy/MM/dd"), Patient.Time.ToString(), Patient.CostOfVisit.ToString("#,0 تومان"));
                }
                if (dgPatient.Rows.Count != 0)
                    dgPatient.Rows[0].Selected = false;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            filter();
        }
    }
}
