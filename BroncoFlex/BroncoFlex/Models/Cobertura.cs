using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Cobertura
{
    public int Id { get; set; }

    public string? Sigla { get; set; }

    public string? Rnos { get; set; }

    public string Cobertura1 { get; set; } = null!;

    public virtual ICollection<Paciente> Pacientes { get; set; } = new List<Paciente>();
}
