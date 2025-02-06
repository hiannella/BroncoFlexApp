namespace WebAPI.Server.Persistance.Models;

public partial class Paciente
{
    public int Id { get; set; }

    public string? TipoDocumento { get; set; }

    public string? NroDocumento { get; set; }

    public DateTime FechaNacimiento { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? Domicilio { get; set; }

    public string? GooglePlacesId { get; set; }

    public string? NroTelefonoLinea { get; set; }

    public string? NroTelefonoMovil { get; set; }

    public string? Email { get; set; }

    public int IdCobertura { get; set; }

    public string? NroAfiliado { get; set; }

    public virtual ICollection<Ficha> Fichas { get; set; } = new List<Ficha>();

    public virtual Cobertura IdCoberturaNavigation { get; set; } = null!;

    public virtual ICollection<Procedimiento> Procedimientos { get; set; } = new List<Procedimiento>();
}
