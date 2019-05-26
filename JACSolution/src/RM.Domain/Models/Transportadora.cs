using RM.Domain.Validations.Transportadoras;
using RM.Shared.Domain.Entities;
using RM.Shared.Domain.ObjectValues;
using System;

namespace RM.Domain.Models
{
    public class Transportadora : Entity
    {
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public string CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public bool Ativo { get; set; }               
        public DateTime DataCadastro { get; set; }

        public bool TransportadoraEhValido()
        {
            ValidationResult = new ConsistenciaTransportadoraValidation().Validate(this);
            return ValidationResult.IsValid;
        }
    }
}
