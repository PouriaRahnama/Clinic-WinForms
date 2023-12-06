using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic.Data.Persistent.Ef
{
    public class PatientReportConfiguration : IEntityTypeConfiguration<PatientReport>
    {
        public void Configure(EntityTypeBuilder<PatientReport> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
