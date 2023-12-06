using Clinic.App._Utilities.RtlMessageBox;
using Clinic.Data.Entities;
using Clinic.DataLayer;

namespace Clinic.App.Patient_Info
{
    public partial class PatientInfo : Form
    {
        public PatientInfo()
        {
            InitializeComponent();
        }

        private void PatientInfo_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        #region Refresh Form Method
        public void BindGrid()
        {
         
            using (UnitOfWork db = new UnitOfWork())
            {
                // Model 1
                //dgPatient.AutoGenerateColumns = false;
                //dgPatient.DataSource = db.patietInfoService.GetAll();


                // Model 2
                List<Data.Entities.PatientInfo> resualt = new List<Data.Entities.PatientInfo>();
                resualt.AddRange(db.patietInfoService.GetAll());

                dgPatient.Rows.Clear();
                foreach (var Patient in resualt)
                {
                    dgPatient.Rows.Add(Patient.Id,Patient.FullName,Patient.Age,Patient.Mobile,Patient.Address);
                }

            }
        }
        #endregion

        #region Insert Patient Information
        private void btnInsert_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            if (addPatient.ShowDialog() == DialogResult.OK)
            {
                BindGrid();
            }
        }
        #endregion

        #region Update Patient Information
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            AddPatient frmAddPatient = new AddPatient();
            if (dgPatient.CurrentRow != null)
            {
                frmAddPatient._patient = int.Parse(dgPatient.CurrentRow.Cells[0].Value.ToString());

                if (frmAddPatient.ShowDialog() == DialogResult.OK)
                {
                    BindGrid();
                }
            }
        }
        #endregion

        #region Delete Patient Information
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgPatient.CurrentRow != null)
            {
                string FullName = dgPatient.CurrentRow.Cells[1].Value.ToString();
                if (RtlMessageBox.Show($"  آیا از حذف {FullName} مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int id = int.Parse(dgPatient.CurrentRow.Cells[0].Value.ToString());
                    using (UnitOfWork db = new UnitOfWork())
                    {
                        var Patient = db.patietInfoService.GetPatientById(id);
                        System.IO.File.Delete(Application.StartupPath + "/Images/" + Patient.ImageName);
                        db.patietInfoService.DeletePatientInfo(id);
                        db.Save();
                    }
                    BindGrid();
                }
            }
            else
            {
                RtlMessageBox.Show("لطفا شخصی را انتخاب کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Refresh Patient Information
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            BindGrid();
        }
        #endregion
    }
}
