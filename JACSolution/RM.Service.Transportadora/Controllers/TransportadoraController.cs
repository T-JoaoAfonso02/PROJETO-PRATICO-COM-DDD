using RM.Application.Interfaces;
using RM.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Web.Http;
namespace RM.Service.Transportadora.Controllers
{
    public class TransportadoraController : ApiController
    {
        private readonly ITransportadoraApplication _transportadoraApplication;
        public TransportadoraController(ITransportadoraApplication transportadoraApplication)
        {
            _transportadoraApplication = transportadoraApplication;
        }
        [HttpGet]
        public IEnumerable<TransportadoraViewModel> ObterTodos()
        {
            return _transportadoraApplication.ObterTodos();
        }
        [HttpGet]
        public IEnumerable<TransportadoraViewModel> ObterTransportadorasAtivas()
        {
            return _transportadoraApplication.ObterTransportadorasAtivas();
        }
        [HttpGet]
        public TransportadoraViewModel Get(Guid id)
        {
            return _transportadoraApplication.ObterTransportadoraPorId(id);
        }        
        public void Post([FromBody] TransportadoraViewModel transportadora)
        {
            _transportadoraApplication.Adicionar(transportadora);
        }        
        public void Put(Guid id, [FromBody]TransportadoraViewModel transportadora)
        {
            _transportadoraApplication.Atualizar(transportadora);
        }        
        public void Delete(Guid id)
        {
            _transportadoraApplication.Remover(id);
        }
    }
}
