using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Servicio
{
    public int Id { get; set; }

    public string Servicio1 { get; set; } = null!;

    public virtual ICollection<Ficha> Fichas { get; set; } = new List<Ficha>();
}
