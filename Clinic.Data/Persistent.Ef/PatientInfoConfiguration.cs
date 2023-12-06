using Clinic.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Clinic.Data.Persistent.Ef
{
    public class PatientInfoConfiguration : IEntityTypeConfiguration<PatientInfo>
    {
        public void Configure(EntityTypeBuilder<PatientInfo> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.FullName).HasMaxLength(250).IsRequired();
        }
    }
}
