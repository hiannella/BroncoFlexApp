using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Anestesia
{
    public int Id { get; set; }

    public string Anestesia1 { get; set; } = null!;

    public virtual ICollection<Ficha> Fichas { get; set; } = new List<Ficha>();

    public virtual ICollection<Procedimiento> Procedimientos { get; set; } = new List<Procedimiento>();
}
