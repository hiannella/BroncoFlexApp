namespace WebAPI.Server.Persistance.Models;

public partial class Entorno
{
    public int Id { get; set; }

    public string Entorno1 { get; set; } = null!;

    public virtual ICollection<Procedimiento> Procedimientos { get; set; } = new List<Procedimiento>();
}
