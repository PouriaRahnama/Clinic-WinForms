using Clinic.Core.Common;

namespace Clinic.Data.Entities
{
    public class Reception : BaseEntity
    {
        public int PatientId { get; set; }
        public string Reason { get; set; }
        public DateTime Data { get; set; }
        public TimeSpan Time { get; set; }
        public decimal CostOfVisit { get; set; }
        public ReceptionStatus Status { get; set; }


        // navigation property
        public PatientInfo Patient { get; set; }
        public PatientReport PatientReport { get; set; }
    }
    public enum ReceptionStatus
    {
        NoVisit,
        Visited
    }
}
