using RM.Shared.Domain.Entities;
using RM.Shared.Domain.ObjectValues;
using System;
namespace RM.Domain.Models
{
    public class Depositante : Entity
    {
        public string RazaoSocial { get; set; }
        public string Fantasia { get; set; }
        public CNPJ CNPJ { get; set; }
        public string InscricaoEstadual { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool DepositanteEhValido()
        {
            return true;
        }
    }
}
