namespace BroncoFlex.Models;

public partial class Determinacion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public string? Piso { get; set; }

    public string? Sector { get; set; }

    public bool EsDerivado { get; set; }

    public string? CentroReceptor { get; set; }

    public string? Comentarios { get; set; }

    public virtual ICollection<ProcedimientosPedidos> RelProcedimientosPedidos { get; set; } = new List<ProcedimientosPedidos>();
}
