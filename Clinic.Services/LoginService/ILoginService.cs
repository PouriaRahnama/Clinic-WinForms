using Clinic.Data.Entities;

namespace Clinic.DataLayer.Repository
{
    public interface ILoginService
    {
        Login GetFirstUser();
        bool IsExist(string name, string Password);
        void CreateUser(Login user);
        void UpdateUser(Login user);
        void DeleteUser(int UserId);

    }
}
