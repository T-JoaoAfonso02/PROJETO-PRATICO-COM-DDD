using RM.Domain.Interfaces.Repositories.Base;
using RM.Domain.Models;
using System.Collections.Generic;

namespace RM.Domain.Interfaces.Repositories
{
    public interface ITransportadoraRepository : IRepositoryBase<Transportadora>
    {
        Transportadora ObterTransportadoraPorCnpj(string CNPJ);

        IEnumerable<Transportadora> ObterTransportadorasAtivas();

        IEnumerable<Transportadora> ObterTransportadorasInativas();
    }
}
