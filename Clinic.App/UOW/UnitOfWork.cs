using Clinic.Business;
using Clinic.Data.Persistent.Ef.Context;
using Clinic.DataLayer.Repository;
using Clinic.DataLayer.Services;

namespace Clinic.DataLayer
{
    public class UnitOfWork : IDisposable
    {
        private SqlContext db = new SqlContext();

        private IPatietInfoService _patietInfoService;
        public IPatietInfoService patietInfoService
        {
            get
            {
                if (_patietInfoService == null)
                {
                    _patietInfoService = new PatietInfoService(db);
                }
                return _patietInfoService;
            }
        }

        private IReceptionService _receptionService;
        public IReceptionService receptionService
        {
            get
            {
                if (_receptionService == null)
                {
                    _receptionService = new ReceptionService(db);
                }
                return _receptionService;
            }
        }

        private IPatientReportService _patientReportService;
        public IPatientReportService patientReportService
        {
            get
            {
                if (_patientReportService == null)
                {
                    _patientReportService = new PatientReportService(db);
                }
                return _patientReportService;
            }
        }


        private ILoginService _loginService;
        public ILoginService loginService
        {
            get
            {
                if (_loginService == null)
                {
                    _loginService = new LoginService(db);
                }
                return _loginService;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }
        public void Dispose()
        {
            db.Dispose();
        }
    }
}
