namespace WebAPI.Server.Persistance.Models;

public partial class Laboratorio
{
    public int Id { get; set; }

    public DateOnly? Fecha { get; set; }

    public decimal? Hto { get; set; }

    public decimal? Hb { get; set; }

    public int? Gb { get; set; }

    public int? Plaquetas { get; set; }

    public byte? Urea { get; set; }

    public decimal? Creatinina { get; set; }

    public byte? Tp { get; set; }

    public byte? Kptt { get; set; }

    public int IdFicha { get; set; }

    public virtual Ficha IdFichaNavigation { get; set; } = null!;
}
