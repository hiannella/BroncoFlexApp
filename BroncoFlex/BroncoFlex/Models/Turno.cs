using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Turno
{
    public int Id { get; set; }

    public DateOnly Fecha { get; set; }

    public TimeOnly? Hora { get; set; }

    public string? Descripcion { get; set; }

    public int IdColor { get; set; }

    public bool PedidoQuirofano { get; set; }

    public bool ReservaCama { get; set; }

    public bool Urgencia { get; set; }

    public bool Confirmado { get; set; }

    public int IdFicha { get; set; }

    public virtual Colore IdColorNavigation { get; set; } = null!;

    public virtual Ficha IdFichaNavigation { get; set; } = null!;
}
