using RM.Domain.Interfaces.Repositories;
using RM.Domain.Interfaces.Services;
using RM.Domain.Models;
using RM.Domain.Validations.Transportadoras;
using System;
namespace RM.Domain.Services
{
    public class TransportadoraService : ITransportadoraService
    {
        private readonly ITransportadoraRepository _transportadoraRepository;
        public TransportadoraService(ITransportadoraRepository transportadoraRepository)
        {
            _transportadoraRepository = transportadoraRepository;
        }
        public Transportadora Adicionar(Transportadora transportadora)
        {
            if (!transportadora.TransportadoraEhValido())
                return transportadora;
            transportadora.ValidationResult = new RegrasComPersistenciaValidations(_transportadoraRepository).Validate(transportadora);
            return !transportadora.ValidationResult.IsValid ? transportadora : _transportadoraRepository.Adicionar(transportadora);
        }
        public Transportadora Atualizar(Transportadora transportadora)
        {
            if (!transportadora.TransportadoraEhValido())
                return transportadora;
            _transportadoraRepository.Atualizar(transportadora);
            return transportadora;
        }

        public void Dispose()
        {
            _transportadoraRepository.Dispose();
        }

        public void Remover(Guid id)
        {
            _transportadoraRepository.Remover(id);
        }
    }
}
