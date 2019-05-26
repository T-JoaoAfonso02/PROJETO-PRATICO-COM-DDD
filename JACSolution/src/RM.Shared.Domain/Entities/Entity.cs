using DomainValidation.Validation;
using System;
namespace RM.Shared.Domain.Entities
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
                 Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
        public ValidationResult ValidationResult { get; set; }
    }
}
