using AutoMapper;
using RM.Application.ViewModels;
using RM.Domain.Models;

namespace RM.Application.AutoMapper
{
    public class ViewModelToDomainMapping : Profile
    {
        public ViewModelToDomainMapping()
        {
            CreateMap<TransportadoraViewModel, Transportadora>();
        }
    }
}
