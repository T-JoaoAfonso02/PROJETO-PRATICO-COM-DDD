using RM.Data.Interfaces;
namespace RM.Application.Uow
{
    public class UnitOfWorkApplication
    {
        private readonly IUnitOfWork _uow;
        public UnitOfWorkApplication(IUnitOfWork uow)
        {
            _uow = uow;
        }
        public void Commit()
        {
            _uow.Commit();
        }
    }
}
