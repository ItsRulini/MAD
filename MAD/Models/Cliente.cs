using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Cliente
{
    public Guid IdCliente { get; set; }

    public string? Rfc { get; set; }

    public string EstadoCivil { get; set; } = null!;

    public Guid? IdUbicacion { get; set; }

    public virtual DatosPersona IdClienteNavigation { get; set; } = null!;

    public virtual Ubicacion? IdUbicacionNavigation { get; set; }

    public virtual ICollection<Reservacion> Reservacions { get; set; } = new List<Reservacion>();
}
