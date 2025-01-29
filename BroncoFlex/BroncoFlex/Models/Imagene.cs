using System;
using System.Collections.Generic;

namespace BroncoFlex.Models;

public partial class Imagene
{
    public int Id { get; set; }

    public DateOnly? Fecha { get; set; }

    public string? Descripcion { get; set; }

    public bool Dvd { get; set; }

    public bool Usb { get; set; }

    public bool Impresion { get; set; }

    public string? Url { get; set; }

    public string? Usuario { get; set; }

    public string? Password { get; set; }

    public int IdFicha { get; set; }

    public virtual Ficha IdFichaNavigation { get; set; } = null!;
}
