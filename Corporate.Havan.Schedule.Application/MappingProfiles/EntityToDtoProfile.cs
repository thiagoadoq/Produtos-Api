using AutoMapper;
using Corporate.Havan.Schedule.Application.Mapping.Dto;
using Corporate.Havan.Schedule.Domain.Entities.Produtos;

namespace Corporate.Havan.Schedule.Application.MappingProfiles
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            CreateMap<Produto, ProdutoDto>().ReverseMap();           
        }
    }
}
