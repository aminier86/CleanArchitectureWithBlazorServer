using System.ComponentModel.DataAnnotations;
using CleanArchitecture.Blazor.Domain.Common.Entities;
using CleanArchitecture.Blazor.Domain.Identity;

namespace CleanArchitecture.Blazor.Domain.Entities;
public class Departamento : BaseAuditableEntity, IMayHaveTenant, IAuditTrial
{
    [Required]
    public string Nombre { get; set; } = string.Empty;
    public string? Descripcion { get; set; }


    public string? EncargadoId { get; set; }
    public ApplicationUser? Encargado { get; set; }

    public string? TenantId { get; set; }
    public virtual Tenant? Tenant { get; set; }

}
