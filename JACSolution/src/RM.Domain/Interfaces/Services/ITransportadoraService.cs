using RM.Domain.Models;
using System;
namespace RM.Domain.Interfaces.Services
{
    public interface ITransportadoraService : IDisposable
    {
        Transportadora Adicionar(Transportadora transportadora);
        Transportadora Atualizar(Transportadora transportadora);
        void Remover(Guid id);
    }
}
