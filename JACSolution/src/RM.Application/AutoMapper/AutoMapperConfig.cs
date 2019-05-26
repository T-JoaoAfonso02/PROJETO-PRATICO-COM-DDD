using AutoMapper;

namespace RM.Application.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegisterMap()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<ViewModelToDomainMapping>();
                x.AddProfile<DomainToViewModelMapping>();
            });
        }
    }
}
