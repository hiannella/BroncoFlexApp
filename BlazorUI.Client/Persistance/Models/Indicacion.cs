﻿namespace BlazorUI.Client.Persistance.Models;

public partial class Indicacion
{
    public int Id { get; set; }

    public string Descripcion { get; set; } = null!;

    public virtual ICollection<Ficha> IdFichas { get; set; } = new List<Ficha>();
}
