using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
namespace RM.Application.ViewModels
{
    public class TransportadoraViewModel
    {
        public TransportadoraViewModel()
        {
            Id = Guid.NewGuid();
        }
        [Key]
        public Guid Id { get; set; }
        [Required(ErrorMessage = "Preencha o campo Razão Social")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Razão Social")]
        public string RazaoSocial { get; set; }
        [Required(ErrorMessage = "Preencha o campo Nome Fantasia")]
        [MinLength(5, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("Nome Fantasia")]
        public string Fantasia { get; set; }
        [Required(ErrorMessage = "Preencha o campo CNPJ")]
        [MinLength(12, ErrorMessage = "Minimo {0} caracteres")]
        [DisplayName("CNPJ")]
        public string CNPJ { get; set; }
        [Required(ErrorMessage = "Preencha o campo IE")]
        [DisplayName("Inscrição Estadual")]
        public string InscricaoEstadual { get; set; }
        [ScaffoldColumn(false)]
        public bool Ativo { get; set; }
        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }
        [ScaffoldColumn(false)]
        public ValidationResult ValidationResult { get; set; }
                
    }
}
