namespace WebAPI.Server.Persistance.Models;

public partial class Broncoscopio
{
    public int Id { get; set; }

    public string Modelo { get; set; } = null!;

    public string? NroPatrimonio { get; set; }

    public bool EsVideo { get; set; }

    public bool EsEbus { get; set; }

    public decimal? Diametro { get; set; }

    public decimal? Canal { get; set; }

    public virtual ICollection<Procedimiento> Procedimientos { get; set; } = new List<Procedimiento>();
}
