namespace Clinic.Core.Common
{
    public abstract class BaseRelation
    {
        public bool IsDelete { get; set; }
        public DateTime CreationDate { get; set; }

        public BaseRelation()
        {
            CreationDate = DateTime.Now;
            IsDelete = false;
        }
    }
}
