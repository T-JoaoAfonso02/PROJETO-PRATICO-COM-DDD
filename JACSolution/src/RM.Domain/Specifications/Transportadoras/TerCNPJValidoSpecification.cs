using DomainValidation.Interfaces.Specification;
using RM.Domain.Models;
using RM.Shared.Domain.ObjectValues;
namespace RM.Domain.Specifications.Transportadoras
{
    public class TerCNPJValidoSpecification : ISpecification<Transportadora>
    {
        public bool IsSatisfiedBy(Transportadora transportadora)
        {
            return CNPJ.Validar(transportadora.CNPJ);
        }
    }
}
