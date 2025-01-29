using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Precaucione
{
    public int Id { get; set; }

    public string Precaucion { get; set; } = null!;

    public virtual ICollection<Ficha> IdFichas { get; set; } = new List<Ficha>();
}
