namespace Clinic.Core.Common
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public bool IsDelete { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseEntity()
        {
            CreationDate = DateTime.Now;
            IsDelete = false;
        }
    }
}
