using RM.Application.Interfaces;
using RM.Application.Services;
using RM.Data.Context;
using RM.Data.Interfaces;
using RM.Data.Repositories;
using RM.Data.UoW;
using RM.Domain.Interfaces.Repositories;
using RM.Domain.Interfaces.Services;
using RM.Domain.Services;
using SimpleInjector;
namespace RM.Infra.CrossCutting.IoC
{
    public class SimpleInjector
    {
        public static void Register(Container container)
        {            
            container.Register<ITransportadoraRepository, TransportadoraRepository>(Lifestyle.Scoped);
            container.Register<ITransportadoraService, TransportadoraService>(Lifestyle.Scoped);
            container.Register<ITransportadoraApplication, TransportadoraApplication>(Lifestyle.Scoped);

            container.Register<IDepositanteRepository, DepositanteRepository>(Lifestyle.Scoped);
            container.Register<IDepositanteService, DepositanteService>(Lifestyle.Scoped);
            //container.Register<IDepositanteApplication, DepositanteApplication>(Lifestyle.Scoped);

            container.Register<IUnitOfWork, UnitOfWork>(Lifestyle.Scoped);
            container.Register<RMContext>(Lifestyle.Scoped);
        }
    }
}
