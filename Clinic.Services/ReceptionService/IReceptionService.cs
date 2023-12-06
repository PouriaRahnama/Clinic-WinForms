using Clinic.Data.Entities;

namespace Clinic.Business
{
    public interface IReceptionService
    {
        IEnumerable<Reception> Get();
        Reception GetById(int Id);
        void Insert(Reception entity);
        void Update(Reception entity);
        void Delete(int Id);
        bool IsExist(int Id);
    }
}
