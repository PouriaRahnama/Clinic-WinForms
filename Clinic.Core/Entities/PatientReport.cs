using Clinic.Core.Common;

namespace Clinic.Data.Entities
{
    public class PatientReport : BaseRelation
    {
        public int ReceptionId { get; set; }
        public string DoctorName { get; set; }
        public string medicine { get; set; }
        public string Description { get; set; }


        // navigation property
        public Reception Reception { get; set; }
    }
}
