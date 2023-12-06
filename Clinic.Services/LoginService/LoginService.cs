using Clinic.Data.Entities;
using Clinic.Data.Persistent.Ef.Context;
using Clinic.DataLayer.Repository;

namespace Clinic.DataLayer.Services
{
    public class LoginService : ILoginService
    {
        private SqlContext context;

        public LoginService(SqlContext Context)
        {
            context = Context;
        }

        public void CreateUser(Login user)
        {
            context.Login.Add(user);
        }

        public void DeleteUser(int id)
        {
            var user = context.Login.Find(id);
            context.Login.Remove(user);
        }

        public Login GetFirstUser()
        {
            return context.Login.First();
        }

        public bool IsExist(string name, string Password)
        {
            return context.Login.Any(u => u.UserName == name && u.Password == Password && u.IsDelete == false);
        }

        public void UpdateUser(Login user)
        {
            context.Login.Update(user);
        }


    }
}
