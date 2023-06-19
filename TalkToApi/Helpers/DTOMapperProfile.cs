using AutoMapper;
using TalkToApi.V1.Models;
using TalkToApi.V1.Models.DTO;

namespace TalkToApi.Helpers
{
    public class DTOMapperProfile : Profile
    {
        public DTOMapperProfile()
        {
            CreateMap<ApplicationUser, UsuarioDTO>()
                .ForMember(dest => dest.Nome, orig => orig.MapFrom(src => src.FullName)).ReverseMap();

            CreateMap<ApplicationUser, UsuarioDTOSemHyperlink>()
                .ForMember(dest => dest.Nome, orig => orig.MapFrom(src => src.FullName)).ReverseMap();
                                
            CreateMap<Mensagem, MensagemDTO>();
            //CreateMap<PaginationList<Palavra>, PaginationList<PalavraDTO>>();
        }
    }
}
