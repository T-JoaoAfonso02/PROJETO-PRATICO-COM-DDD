using RM.Application.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;

namespace RM.Application.Interfaces
{
    public interface ITransportadoraApplication : IDisposable
    {
        TransportadoraViewModel Adicionar(TransportadoraViewModel transportadora);
        TransportadoraViewModel Atualizar(TransportadoraViewModel transportadora);
        void Remover(Guid id);



        TransportadoraViewModel ObterTransportadoraPorCnpj(string cnpj);
        IEnumerable<TransportadoraViewModel> ObterTransportadorasAtivas();
        IEnumerable<TransportadoraViewModel> ObterTransportadorasInativas();
        TransportadoraViewModel ObterTransportadoraPorId(Guid id);
        IEnumerable<TransportadoraViewModel> ObterTodos();
        
    }
}
