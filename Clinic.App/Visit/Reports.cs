using Clinic.App._Utilities.RtlMessageBox;
using Clinic.DataLayer;
using System.Data;
using System.Windows.Forms;

namespace Clinic.App.Patient_Visit
{
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void Reports_Load(object sender, EventArgs e)
        {
            BindGrid();
        }

        private void BindGrid()
        {
            using (UnitOfWork db = new UnitOfWork())
            {

                dgShow.AutoGenerateColumns = false;
                var list = db.patientReportService.GetAll();
                foreach (var Patient in list)
                {
                    dgShow.Rows.Add(Patient.ID, Patient.PatientName, Patient.Reason, Patient.DoctorName,
                        Patient.medicine, Patient.money.ToString("#,0"), Patient.date.ToString("yyyy/MM/dd"), Patient.time, Patient.Description);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgShow.CurrentRow != null)
            {
                int Id = int.Parse(dgShow.CurrentRow.Cells[0].Value.ToString());
                using (UnitOfWork db = new UnitOfWork())
                {
                    if (RtlMessageBox.Show($"  آیا از حذف مطمئن هستید ؟", "هشدار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        var PatientReport =  db.patientReportService.GetPatientReportById(Id);
                        PatientReport.IsDelete = true;
                        db.patientReportService.UpdatePatientReport(PatientReport);
                        db.Save();
                        dgShow.Rows.Clear();
                        BindGrid();
                    }
                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            DataTable dtPrint = new DataTable();
            dtPrint.Columns.Add("PatientName");
            dtPrint.Columns.Add("ReasonForReferral");
            dtPrint.Columns.Add("DoctorName");
            dtPrint.Columns.Add("medicine");
            dtPrint.Columns.Add("money");
            dtPrint.Columns.Add("date");
            dtPrint.Columns.Add("time");
            dtPrint.Columns.Add("Description");

            foreach (DataGridViewRow item in dgShow.Rows)
            {
                dtPrint.Rows.Add(


                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString(),
                    item.Cells[4].Value.ToString(),
                    item.Cells[5].Value.ToString(),
                    item.Cells[6].Value.ToString(),
                    item.Cells[7].Value.ToString(),
                    item.Cells[8].Value.ToString()
                   );
            }
            //stiReport1.Load(Application.StartupPath + "/Report.mrt");
            //stiReport1.RegData("dt", dtPrint);
            //stiReport1.Show();
        }
    }
}

