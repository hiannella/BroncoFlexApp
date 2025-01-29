using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Pendiente
{
    public int Id { get; set; }

    public string Pendiente1 { get; set; } = null!;

    public virtual ICollection<Ficha> IdFichas { get; set; } = new List<Ficha>();
}
