using RM.Domain.Models;
using System;
namespace RM.Domain.Interfaces.Services
{
    public interface IDepositanteService : IDisposable
    {
        Depositante Adicionar(Depositante transportadora);
        Depositante Atualizar(Depositante transportadora);
        void Remover(Guid id);
    }
}
