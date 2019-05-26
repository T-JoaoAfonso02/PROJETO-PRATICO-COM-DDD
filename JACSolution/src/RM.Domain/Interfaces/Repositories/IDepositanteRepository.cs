using RM.Domain.Interfaces.Repositories.Base;
using RM.Domain.Models;
using System.Collections.Generic;

namespace RM.Domain.Interfaces.Repositories
{
    public interface IDepositanteRepository : IRepositoryBase<Depositante>
    {
        Depositante ObterDepositantesPorCnpj(string CNPJ);

        IEnumerable<Depositante> ObterDepositantesAtivas();

        IEnumerable<Depositante> ObterDepositantesInativas();
    }
}
