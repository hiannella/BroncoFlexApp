using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Muestra
{
    public int Id { get; set; }

    public string Muestra1 { get; set; } = null!;

    public virtual ICollection<RelProcedimientosPedido> RelProcedimientosPedidos { get; set; } = new List<RelProcedimientosPedido>();
}
