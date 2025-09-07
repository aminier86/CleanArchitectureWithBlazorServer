#nullable enable
#nullable disable warnings

using CleanArchitecture.Blazor.Application.Features.Identity.DTOs;
using CleanArchitecture.Blazor.Application.Features.Tenants.DTOs;

namespace CleanArchitecture.Blazor.Application.Features.Departamentos.DTOs;

[Description("Departamentos")]
public class DepartamentoDto
{
    [Description("Id")]
    public int Id { get; set; }
    [Description("Nombre")]
    public string? Nombre { get; set; }
    [Description("Descripcion")]
    public string? Descripcion { get; set; }
    [Description("Encargado id")]
    public string? EncargadoId { get; set; }
    public ApplicationUserDto? Encargado { get; set; }

    [Description("Tenant id")]
    public string? TenantId { get; set; }
    [Description("Tenant")]
    public TenantDto? Tenant { get; set; }


    private class Mapping : Profile
    {
        public Mapping()
        {
            CreateMap<Departamento, DepartamentoDto>(MemberList.None);
            CreateMap<DepartamentoDto, Departamento>(MemberList.None)
            .ForMember(dest => dest.CreatedAt, opt => opt.Ignore())
            .ForMember(dest => dest.CreatedById, opt => opt.Ignore())
            .ForMember(dest => dest.LastModifiedAt, opt => opt.Ignore())
            .ForMember(dest => dest.LastModifiedById, opt => opt.Ignore())
            .ForMember(dest => dest.DomainEvents, opt => opt.Ignore());

            CreateMap<DepartamentoDto, Departamento>(MemberList.None)
           .ForMember(x => x.EncargadoId, s => s.MapFrom(y => y.Encargado != null ? y.Encargado.Id : null));
        }
    }
}

