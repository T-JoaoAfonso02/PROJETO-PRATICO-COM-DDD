using RM.Data.Context;
using RM.Data.Repositories.Base;
using RM.Domain.Interfaces.Repositories;
using RM.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RM.Data.Repositories
{
    public class TransportadoraRepository : RepositoryBase<Transportadora>, ITransportadoraRepository
    {
        public TransportadoraRepository(RMContext context):base(context)
        {

        }
        public Transportadora ObterTransportadoraPorCnpj(string CNPJ)
        {
            return Buscar(t => t.CNPJ == CNPJ).FirstOrDefault();
        }

        public IEnumerable<Transportadora> ObterTransportadorasAtivas()
        {
            return Buscar(t => t.Ativo == true).ToList();
        }

        public IEnumerable<Transportadora> ObterTransportadorasInativas()
        {
            return Buscar(t => t.Ativo == false).ToList();
        }
    }
}
