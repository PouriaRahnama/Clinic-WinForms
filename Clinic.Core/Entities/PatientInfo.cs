using Clinic.Core.Common;

namespace Clinic.Data.Entities
{
    public class PatientInfo : BaseEntity
    {
        public string ImageName { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string Mobile { get; set; }
        public string Address { get; set; }


        // navigation property
        public ICollection<Reception> Reception { get; set; }
    }
}
