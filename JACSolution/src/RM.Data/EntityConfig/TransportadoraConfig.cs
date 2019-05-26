using RM.Domain.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Data.EntityConfig
{
    public class TransportadoraConfig : EntityTypeConfiguration<Transportadora>
    {
        public TransportadoraConfig()
        {
            HasKey(d => d.Id);
            Property(d => d.CNPJ)
                .IsRequired()
                .HasMaxLength(14)
                .IsFixedLength()
                .HasColumnAnnotation("Index", new IndexAnnotation(
                    new IndexAttribute("IX_CNPJTRANSPORTADORA") { IsUnique = true }));
            Property(D => D.RazaoSocial)
                .IsRequired()
                .HasMaxLength(150);
            Property(D => D.Fantasia)
                .IsRequired()
                .HasMaxLength(150);
            Ignore(D => D.ValidationResult);
        }
    }
}
