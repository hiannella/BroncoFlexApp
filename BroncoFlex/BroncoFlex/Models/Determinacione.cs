using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Determinacione
{
    public int Id { get; set; }

    public string Determinacion { get; set; } = null!;

    public string? Piso { get; set; }

    public string? Sector { get; set; }

    public bool EsDerivado { get; set; }

    public string? CentroReceptor { get; set; }

    public string? Comentarios { get; set; }

    public virtual ICollection<RelProcedimientosPedido> RelProcedimientosPedidos { get; set; } = new List<RelProcedimientosPedido>();
}
