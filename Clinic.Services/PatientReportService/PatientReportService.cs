using Clinic.Data.Entities;
using Clinic.Data.Persistent.Ef.Context;
using Clinic.DataLayer.Repository;
using Clinic.ViewModels.Patient;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DataLayer.Services
{
    public class PatientReportService : IPatientReportService
    {
        private SqlContext context;

        public PatientReportService(SqlContext Context)
        {
            context = Context;
        }

        public void CreatePatientReport(PatientReport Patient_Report)
        {
            context.PatientReport.Add(Patient_Report);
        }

        public void DeletePatientReport(int Id)
        {
            var PatientReport = context.PatientReport.Find(Id);
            context.PatientReport.Remove(PatientReport);
        }

        public IEnumerable<PatientReportViewModel> GetAll()
        {
            var list = context.PatientReport.Include(c => c.Reception).ThenInclude(r => r.Patient).Where(p => p.IsDelete == false).Select(p => new PatientReportViewModel
            {
                Description = p.Description,
                DoctorName = p.DoctorName,
                ID = p.Id,
                PatientName = p.Reception.Patient.FullName,
                medicine = p.medicine,
                Reason = p.Reception.Reason,
                date = p.Reception.Data,
                money = p.Reception.CostOfVisit,
                time = p.Reception.Time
            }).ToList();
            return list;
        }

        public PatientReport GetPatientReportById(int id)
        {
            return context.PatientReport.Find(id);
        }

        public void UpdatePatientReport(PatientReport Patient_Report)
        {
            context.PatientReport.Update(Patient_Report);
        }
    }
}
