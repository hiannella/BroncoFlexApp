namespace BlazorUI.Client.Persistance.Models;

public partial class Cobertura
{
    public int Id { get; set; }

    public string? Sigla { get; set; }

    public string? Rnos { get; set; }

    public string NombreCompleto { get; set; } = null!;
}
