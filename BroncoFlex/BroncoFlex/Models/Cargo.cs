using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Cargo
{
    public int Id { get; set; }

    public string? Cargo1 { get; set; }

    public virtual ICollection<Personal> Personals { get; set; } = new List<Personal>();
}
