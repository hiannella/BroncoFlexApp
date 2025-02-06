namespace WebAPI.Server.Persistance.Models;

public partial class ProcedimientosPedidos
{
    public int IdProcedimiento { get; set; }

    public int IdMuestra { get; set; }

    public int IdDeterminacion { get; set; }

    public virtual Determinacion IdDeterminacionNavigation { get; set; } = null!;

    public virtual Muestra IdMuestraNavigation { get; set; } = null!;

    public virtual Procedimiento IdProcedimientoNavigation { get; set; } = null!;
}
