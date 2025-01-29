using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Personal
{
    public int Id { get; set; }

    public string Nombres { get; set; } = null!;

    public string Apellidos { get; set; } = null!;

    public string? NroMatricula { get; set; }

    public string? NroLegajo { get; set; }

    public int IdCargo { get; set; }

    public virtual ICollection<Ficha> Fichas { get; set; } = new List<Ficha>();

    public virtual Cargo IdCargoNavigation { get; set; } = null!;

    public virtual ICollection<Procedimiento> ProcedimientoIdAnestesiologoNavigations { get; set; } = new List<Procedimiento>();

    public virtual ICollection<Procedimiento> ProcedimientoIdAsistenteNavigations { get; set; } = new List<Procedimiento>();

    public virtual ICollection<Procedimiento> ProcedimientoIdAyudanteNavigations { get; set; } = new List<Procedimiento>();

    public virtual ICollection<Procedimiento> ProcedimientoIdOperadorNavigations { get; set; } = new List<Procedimiento>();

    public virtual ICollection<Procedimiento> ProcedimientoIdPatologoNavigations { get; set; } = new List<Procedimiento>();
}
