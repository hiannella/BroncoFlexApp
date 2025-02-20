using BlazorUI.Client.Persistance.Models;

namespace BlazorUI.Client.Components.ViewModels;

public class ProcedimientoGrillaViewModel
{
    public int Id { get; set; }

    public int IdPaciente { get; set; }

    public DateOnly Fecha { get; set; }

    public int IdEntorno { get; set; }

    public int IdOperador { get; set; }

    public int? IdAnestesia { get; set; }

    public bool CapturaVideo { get; set; }

    public Anestesia? Anestesia { get; set; }

    public required Entorno Entorno { get; set; }

    public required Personal Operador { get; set; }
}
