using AutoMapper;
using RM.Application.ViewModels;
using RM.Domain.Models;

namespace RM.Application.AutoMapper
{
    public class DomainToViewModelMapping : Profile
    {
        public DomainToViewModelMapping()
        {
            CreateMap<Transportadora, TransportadoraViewModel>();
        }
    }
}
