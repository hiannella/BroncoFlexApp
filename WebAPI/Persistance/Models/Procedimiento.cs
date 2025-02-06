namespace WebAPI.Server.Persistance.Models;

public partial class Procedimiento
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public int IdFicha { get; set; }

    public DateOnly Fecha { get; set; }

    public int IdEntorno { get; set; }

    public int IdOperador { get; set; }

    public int? IdAyudante { get; set; }

    public int? IdAsistente { get; set; }

    public int? IdAnestesiologo { get; set; }

    public int? IdAnestesia { get; set; }

    public int? IdPatologo { get; set; }

    public bool Rose { get; set; }

    public int IdBroncoscopio { get; set; }

    public string Informe { get; set; } = null!;

    public string? Comentarios { get; set; }

    public bool CapturaVideo { get; set; }

    public virtual Anestesia? IdAnestesiaNavigation { get; set; }

    public virtual Personal? IdAnestesiologoNavigation { get; set; }

    public virtual Personal? IdAsistenteNavigation { get; set; }

    public virtual Personal? IdAyudanteNavigation { get; set; }

    public virtual Broncoscopio IdBroncoscopioNavigation { get; set; } = null!;

    public virtual Entorno IdEntornoNavigation { get; set; } = null!;

    public virtual Ficha IdFichaNavigation { get; set; } = null!;

    public virtual Personal IdOperadorNavigation { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;

    public virtual Personal? IdPatologoNavigation { get; set; }

    public virtual ICollection<ProcedimientosPedidos> RelProcedimientosPedidos { get; set; } = new List<ProcedimientosPedidos>();
}
