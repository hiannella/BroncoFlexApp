using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Colore
{
    public int Id { get; set; }

    public string Color { get; set; } = null!;

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();
}
