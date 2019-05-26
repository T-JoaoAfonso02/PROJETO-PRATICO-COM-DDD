using DomainValidation.Interfaces.Specification;
using RM.Domain.Interfaces.Repositories;
using RM.Domain.Models;
namespace RM.Domain.Specifications.Transportadoras
{
    public class TerCNPJUnicoNaBaseDeDadosSpecification : ISpecification<Transportadora>
    {
        private readonly ITransportadoraRepository _transportadoraRepository;
        public TerCNPJUnicoNaBaseDeDadosSpecification(ITransportadoraRepository transportadoraRepository)
        {
            _transportadoraRepository = transportadoraRepository;
        }
        public bool IsSatisfiedBy(Transportadora transportadora)
        {
            return _transportadoraRepository.ObterTransportadoraPorCnpj(transportadora.CNPJ) == null;
        }
    }
}
