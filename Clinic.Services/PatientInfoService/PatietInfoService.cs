using Clinic.Data.Entities;
using Clinic.Data.Persistent.Ef.Context;
using Clinic.DataLayer.Repository;
using Clinic.ViewModels.Patient;
using Microsoft.EntityFrameworkCore;

namespace Clinic.DataLayer.Services
{
    public class PatietInfoService: IPatietInfoService
    {
        private SqlContext context;

        public PatietInfoService(SqlContext Context)
        {
            context = Context;
        }

        public List<PatientInfo> GetAll()
        {
            return context.PatientInfo.Where(c => c.IsDelete == false).ToList();
        }
        public List<listPatientViewModel> GetPatientName(string filter = "")
        {
            if (filter == null)
            {
                return context.PatientInfo.Where(c => c.IsDelete == false).Select(c => new listPatientViewModel()
                {
                    PatientID = c.Id,
                    FullName = c.FullName
                }).ToList();
            }

            return context.PatientInfo.Where(c => c.FullName.Contains(filter) && c.IsDelete == false).Select(c => new listPatientViewModel()
            {
                PatientID = c.Id,
                FullName = c.FullName
            }).ToList();
        }

        public int GetPatientIdByName(string fullName)
        {
            var customer = context.PatientInfo.FirstOrDefault(C => C.FullName == fullName);
            return customer.Id;
        }

        public string GetPatientNameById(int patientId)
        {
            var customer = context.PatientInfo.Find(patientId);
            return customer.FullName;
        }

        public void CreatePatientInfo(PatientInfo patientInfo)
        {
            context.PatientInfo.Add(patientInfo);
        }

        public void UpdatePatientInfo(PatientInfo patientInfo)
        {
            // model 1
            context.PatientInfo.Update(patientInfo);

            // model 2
            //var patient = context.PatientInfo.FirstOrDefault(f => f.Id == patientInfo.Id);
            //var state_1 = context.Entry(patient).State;
            //if (patient != null)
            //{
            //    context.Set<PatientInfo>().Entry(patient).State = EntityState.Detached;
            //    var state_2 = context.Entry(patient).State;
            //}
            //context.Entry(patientInfo).State = EntityState.Modified;
        }

        public void DeletePatientInfo(int id)
        {
            var PatietInformation = context.PatientInfo.Find(id);
            context.PatientInfo.Remove(PatietInformation);
        }

        public PatientInfo GetPatientById(int id)
        {
            return context.PatientInfo.Find(id);
        }
    }
}
