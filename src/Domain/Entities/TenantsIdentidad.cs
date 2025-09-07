using System.ComponentModel.DataAnnotations;
using CleanArchitecture.Blazor.Domain.Common.Entities;

public class TenantsIdentidad : BaseAuditableEntity, IMayHaveTenant, IAuditTrial
{
    [Required]
    public string TenantId { get; set; } = string.Empty;
    public virtual Tenant? Tenant { get; set; }

    [MaxLength(255)]
    public string? Name { get; set; }

    [MaxLength(500)]
    public string? Direccion { get; set; }

    [MaxLength(20)]
    public string? Telefono { get; set; }

    [MaxLength(255)]
    public string? Email { get; set; }

    [MaxLength(255)]
    public string? Website { get; set; }

    // Relación con logos (hasta 5 o más)
    public List<TenantLogo> TenantLogos { get; set; } = new();
}

public class TenantLogo
{
    [Key]
    public int Id { get; set; }

    [Required, MaxLength(255)]
    public string Name { get; set; } = string.Empty;

    public decimal Size { get; set; }

    [Required, MaxLength(500)]
    public string Url { get; set; } = string.Empty;

    // Relación con TenantsIdentidad
    public int TenantsIdentidadId { get; set; }
    public virtual TenantsIdentidad? TenantsIdentidad { get; set; }

    // Opcional: Tipo de logo (principal, secundario, etc.)
    [MaxLength(50)]
    public string? TipoLogo { get; set; }

    // Orden de presentación
    public int Orden { get; set; } = 0;
}