namespace Clinic.ViewModels.Patient
{
    public class PatientReportViewModel
    {
        public int ID { get; set; }
        public string PatientName { get; set; }
        public string Description { get; set; }
        public string medicine { get; set; }
        public string DoctorName { get; set; }
        public string Reason { get; set; }
        public decimal money { get; set; }
        public DateTime date { get; set; }
        public TimeSpan time { get; set; }

    }
}
