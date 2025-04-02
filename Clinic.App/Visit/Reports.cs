using Clinic.App._Utilities.RtlMessageBox;
using Clinic.DataLayer;
using ClosedXML.Excel;
using System.Data;
using System.Globalization;
using System.Windows.Forms;
using System.Xml.Linq;

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
                if (dgShow.Rows.Count != 0)
                    dgShow.Rows[0].Selected = false;

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
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add("Data");
                        worksheet.RightToLeft = true; 
                                                   
                        worksheet.Rows().Height = 25; // ارتفاع ردیف‌ها
                                               
                        for (int i = 1; i <= dgShow.Columns.Count; i++)
                        {
                            worksheet.Column(i).Width = 17; // عرض ستون‌ها را بزرگ‌تر می‌کنیم
                        }

                        for (int i = 1; i < dgShow.Columns.Count; i++)
                            worksheet.Cell(1, i).Value = dgShow.Columns[i].HeaderText;

                        for (int i = 0; i < dgShow.Rows.Count; i++)
                            for (int j = 1; j < dgShow.Columns.Count; j++)
                                worksheet.Cell(i + 2, j).Value = dgShow?.Rows[i]?.Cells[j]?.Value?.ToString() ?? "";

                        // ذخیره‌ی فایل
                        workbook.SaveAs(sfd.FileName);
                        MessageBox.Show("Export successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

        }

        private string ToShamsiExcelOutput(DateTime value)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(value) + "-" + pc.GetMonth(value).ToString("00") + "-" + pc.GetDayOfMonth(value).ToString("00");
        }
    }
}

