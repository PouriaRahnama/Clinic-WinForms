using Clinic.Data.Entities;
using Clinic.Data.Persistent.Ef.Context;

namespace Clinic.Business
{
    public class ReceptionService : IReceptionService
    {
        private SqlContext context;

        public ReceptionService(SqlContext Context)
        {
            context = Context;
        }
        public void Delete(int Id)
        {
            var Reception = context.Reception.Find(Id);
            context.Reception.Remove(Reception);
        }

        public IEnumerable<Reception> Get()
        {
           return context.Reception.Where(c => c.Status == ReceptionStatus.NoVisit).ToList();
        }

        public Reception GetById(int Id)
        {
            return context.Reception.Find(Id);
        }

        public void Insert(Reception entity)
        {
            context.Reception.Add(entity);
        }

        public bool IsExist(int id)
        {
            return context.Reception.Any(c => c.Id == id);
        }

        public void Update(Reception entity)
        {
            context.Reception.Update(entity);
        }
    }

}
