using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Indicacione
{
    public int Id { get; set; }

    public string Indicacion { get; set; } = null!;

    public virtual ICollection<Ficha> IdFichas { get; set; } = new List<Ficha>();
}
