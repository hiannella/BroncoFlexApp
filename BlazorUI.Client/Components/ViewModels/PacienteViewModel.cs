using BlazorUI.Client.Components.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace BlazorUI.Client.Components.Viewmodels;

public class PacienteViewModel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Tipo de documento es requerido.")]
    public string? TipoDocumento { get; set; }

    [Required(ErrorMessage = "Número de documento es requerido.")]
    [StringLength(20, ErrorMessage = "Número de documento no puede exceder 20 caracteres.")]
    public string? NroDocumento { get; set; }

    [Required(ErrorMessage = "Fecha de nacimiento es requerida.")]
    public DateTime FechaNacimiento { get; set; }

    [Required(ErrorMessage = "Nombres son requeridos.")]
    [StringLength(100, ErrorMessage = "Nombres no pueden exceder 100 caracteres.")]
    public string Nombres { get; set; } = null!;

    [Required(ErrorMessage = "Apellidos son requeridos.")]
    [StringLength(100, ErrorMessage = "Apellidos no pueden exceder 100 caracteres.")]
    public string Apellidos { get; set; } = null!;

    public string? Domicilio { get; set; }

    public string? GooglePlacesId { get; set; }

    [Phone(ErrorMessage = "Número de teléfono de línea no es válido.")]
    public string? NroTelefonoLinea { get; set; }

    [Phone(ErrorMessage = "Número de teléfono móvil no es válido.")]
    public string? NroTelefonoMovil { get; set; }

    [EmailAddress(ErrorMessage = "Correo electrónico no es válido.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "Cobertura es requerida.")]
    public int IdCobertura { get; set; }

    [Required(ErrorMessage = "Cobertura es requerida.")]
    public CoberturaViewModel Cobertura { get; set; } = new();

    public string? NroAfiliado { get; set; }

    public List<ProcedimientoGrillaViewModel> Procedimientos { get; set; } = [];
}

