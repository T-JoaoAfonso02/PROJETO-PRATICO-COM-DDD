using AutoMapper;
using RM.Application.Interfaces;
using RM.Application.Uow;
using RM.Application.ViewModels;
using RM.Data.Interfaces;
using RM.Domain.Interfaces.Repositories;
using RM.Domain.Interfaces.Services;
using RM.Domain.Models;
using RM.Shared.Domain.Helpers;
using RM.Shared.Domain.ObjectValues;
using System;
using System.Collections.Generic;
namespace RM.Application.Services
{
    public class TransportadoraApplication : UnitOfWorkApplication, ITransportadoraApplication
    {
        private readonly ITransportadoraRepository _transportadoraRepository;
        private readonly ITransportadoraService _transportadoraService;
        public TransportadoraApplication(ITransportadoraRepository transportadoraRepository,
                                         ITransportadoraService transportadoraService, IUnitOfWork uow) : base(uow)
        {
            _transportadoraRepository = transportadoraRepository;
            _transportadoraService = transportadoraService;
        }
        public TransportadoraViewModel Adicionar(TransportadoraViewModel transportadora)
        {
            var mapperTransportadora = Mapper.Map<Transportadora>(transportadora);
            mapperTransportadora.Ativo = true;
            mapperTransportadora.CNPJ = TextoHelper.GetNumeros(mapperTransportadora.CNPJ);
            var adicionaTransportadora = _transportadoraService.Adicionar(mapperTransportadora);            
            if (mapperTransportadora.ValidationResult.IsValid)
            {
                Commit();
            }
            //transportadora = Mapper.Map<TransportadoraViewModel>(adicionaTransportadora);
            return transportadora;
        }
        public TransportadoraViewModel Atualizar(TransportadoraViewModel transportadora)
        {
            var atualizaTransportadora = Mapper.Map<Transportadora>(transportadora);
            atualizaTransportadora.Ativo = true;
            atualizaTransportadora.CNPJ = TextoHelper.GetNumeros(atualizaTransportadora.CNPJ);
            _transportadoraService.Atualizar(atualizaTransportadora);
            Commit();
            return transportadora;
        }
        public void Remover(Guid id)
        {
            _transportadoraService.Remover(id);
            Commit();
        }
        public IEnumerable<TransportadoraViewModel> ObterTodos()
        {
            return Mapper.Map<IEnumerable<TransportadoraViewModel>>(_transportadoraRepository.ObterTodos());
        }
        public TransportadoraViewModel ObterTransportadoraPorCnpj(string cnpj)
        {
            return Mapper.Map<TransportadoraViewModel>(_transportadoraRepository.ObterTransportadoraPorCnpj(cnpj));
        }
        public TransportadoraViewModel ObterTransportadoraPorId(Guid id)
        {
            return Mapper.Map<TransportadoraViewModel>(_transportadoraRepository.ObterPorId(id));
        }
        public IEnumerable<TransportadoraViewModel> ObterTransportadorasAtivas()
        {
            return Mapper.Map<IEnumerable<TransportadoraViewModel>>(_transportadoraRepository.ObterTransportadorasAtivas());
        }
        public IEnumerable<TransportadoraViewModel> ObterTransportadorasInativas()
        {
            return Mapper.Map<IEnumerable<TransportadoraViewModel>>(_transportadoraRepository.ObterTransportadorasInativas());
        }
        public void Dispose()
        {
            _transportadoraRepository.Dispose();
        }
    }
}
