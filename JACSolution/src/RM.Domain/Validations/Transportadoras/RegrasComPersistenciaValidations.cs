using DomainValidation.Validation;
using RM.Domain.Interfaces.Repositories;
using RM.Domain.Models;
using RM.Domain.Specifications.Transportadoras;

namespace RM.Domain.Validations.Transportadoras
{
    public class RegrasComPersistenciaValidations : Validator<Transportadora>
    {
        public RegrasComPersistenciaValidations(ITransportadoraRepository transportadoraRepository)
        {
            var cnpjUnico = new TerCNPJUnicoNaBaseDeDadosSpecification(transportadoraRepository);
            base.Add("cnpjUnico", new Rule<Transportadora>(cnpjUnico, "Já existe uma transportadora cadastrado com este CNPJ"));
        }
    }
}
