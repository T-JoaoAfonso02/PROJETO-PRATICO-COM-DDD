using RM.Data.Context;
using RM.Data.Repositories.Base;
using RM.Domain.Interfaces.Repositories;
using RM.Domain.Models;
using System;
using System.Collections.Generic;

namespace RM.Data.Repositories
{
    public class DepositanteRepository : RepositoryBase<Depositante> , IDepositanteRepository
    {
        public DepositanteRepository(RMContext context): base(context)
        {

        }
        public IEnumerable<Depositante> ObterDepositantesAtivas()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Depositante> ObterDepositantesInativas()
        {
            throw new NotImplementedException();
        }
        public Depositante ObterDepositantesPorCnpj(string CNPJ)
        {
            throw new NotImplementedException();
        }
    }
}
