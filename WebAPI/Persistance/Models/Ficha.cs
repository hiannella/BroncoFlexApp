namespace WebAPI.Server.Persistance.Models;

public partial class Ficha
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    public int IdPaciente { get; set; }

    public bool Ambulatorio { get; set; }

    public int? IdServicio { get; set; }

    public string? EnfermedadActual { get; set; }

    public string? Antecedentes { get; set; }

    public string? EstudiosPrevios { get; set; }

    public string? Medicacion { get; set; }

    public int IdMedicoAtencion { get; set; }

    public int IdAnestesiaPrevista { get; set; }

    public string? Observaciones { get; set; }

    public virtual Anestesia IdAnestesiaPrevistaNavigation { get; set; } = null!;

    public virtual Personal IdMedicoAtencionNavigation { get; set; } = null!;

    public virtual Paciente IdPacienteNavigation { get; set; } = null!;

    public virtual Servicio? IdServicioNavigation { get; set; }

    public virtual ICollection<Imagen> Imagenes { get; set; } = new List<Imagen>();

    public virtual ICollection<Laboratorio> Laboratorios { get; set; } = new List<Laboratorio>();

    public virtual Procedimiento? Procedimiento { get; set; }

    public virtual ICollection<Turno> Turnos { get; set; } = new List<Turno>();

    public virtual ICollection<Indicacion> IdIndicacions { get; set; } = new List<Indicacion>();

    public virtual ICollection<Pendiente> IdPendientes { get; set; } = new List<Pendiente>();

    public virtual ICollection<Precaucion> IdPrecaucions { get; set; } = new List<Precaucion>();
}
