using Clinic.Data.Entities;
using Clinic.ViewModels.Patient;

namespace Clinic.DataLayer.Repository
{
    public interface IPatietInfoService
    {
        List<listPatientViewModel> GetPatientName(string filter = "");
        List<PatientInfo> GetAll();
        int GetPatientIdByName(string fullName);
        string GetPatientNameById(int patientId);
        void CreatePatientInfo(PatientInfo patientInfo);
        void UpdatePatientInfo(PatientInfo patientInfo);
        void DeletePatientInfo(int id);
        PatientInfo GetPatientById(int id);
    }
}

