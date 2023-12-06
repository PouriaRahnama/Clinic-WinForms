using Clinic.Data.Entities;
using Clinic.ViewModels.Patient;

namespace Clinic.DataLayer.Repository
{
    public interface IPatientReportService
    {
        IEnumerable<PatientReportViewModel> GetAll();
        PatientReport GetPatientReportById(int id);
        void CreatePatientReport(PatientReport Patient_Report);
        void UpdatePatientReport(PatientReport Patient_Report);
        void DeletePatientReport(int Id);
    }
}
