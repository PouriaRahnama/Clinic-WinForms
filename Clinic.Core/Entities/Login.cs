using Clinic.Core.Common;

namespace Clinic.Data.Entities
{
    public class Login : BaseEntity
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
