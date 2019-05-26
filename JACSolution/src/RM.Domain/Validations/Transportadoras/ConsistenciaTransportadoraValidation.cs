using DomainValidation.Validation;
using RM.Domain.Models;
using RM.Domain.Specifications.Transportadoras;
namespace RM.Domain.Validations.Transportadoras
{
    public class ConsistenciaTransportadoraValidation : Validator<Transportadora>
    {
        public ConsistenciaTransportadoraValidation()
        {
            var cnpjValido = new TerCNPJValidoSpecification();
            base.Add("cnpjValido", new Rule<Transportadora>(cnpjValido,"Transportadora com CNPJ Invalido"));
        }
    }
}
