using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class RelProcedimientosPedido
{
    public int IdProcedimiento { get; set; }

    public int IdMuestra { get; set; }

    public int IdDeterminacion { get; set; }

    public virtual Determinacione IdDeterminacionNavigation { get; set; } = null!;

    public virtual Muestra IdMuestraNavigation { get; set; } = null!;

    public virtual Procedimiento IdProcedimientoNavigation { get; set; } = null!;
}
