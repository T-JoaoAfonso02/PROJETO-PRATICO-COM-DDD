using RM.Domain.Interfaces.Repositories;
using RM.Domain.Interfaces.Services;
using RM.Domain.Models;
using System;

namespace RM.Domain.Services
{
    public class DepositanteService : IDepositanteService
    {
        private readonly IDepositanteRepository _depositanteRepository;
        public DepositanteService(IDepositanteRepository depositanteRepository)
        {
            _depositanteRepository = depositanteRepository;
        }

        public Depositante Adicionar(Depositante transportadora)
        {
            throw new NotImplementedException();
        }

        public Depositante Atualizar(Depositante transportadora)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _depositanteRepository.Dispose();
        }

        public void Remover(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
