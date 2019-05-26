using RM.Data.Context;
using RM.Data.Interfaces;
namespace RM.Data.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly RMContext _context;
        public UnitOfWork(RMContext context)
        {
            _context = context;
        }
        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}
