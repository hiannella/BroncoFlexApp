using System.ComponentModel.DataAnnotations;

namespace BlazorUI.Client.Components.ViewModels;

public class CoberturaViewModel
{
    public int Id { get; set; }

    [StringLength(10, ErrorMessage = "Sigla no puede exceder 10 caracteres.")]
    public string? Sigla { get; set; }

    [StringLength(20, ErrorMessage = "Rnos no puede exceder 20 caracteres.")]
    public string? Rnos { get; set; }

    [StringLength(100, ErrorMessage = "Nombre completo no puede exceder 100 caracteres.")]
    public string? NombreCompleto { get; set; } = null!;
}
