using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Usuario
{
    public Guid IdUsuario { get; set; }

    public string TipoUsuario { get; set; } = null!;

    public long Nomina { get; set; }

    public bool? Estado { get; set; }

    public virtual ICollection<Cancelacion> Cancelacions { get; set; } = new List<Cancelacion>();

    public virtual ICollection<Contraseña> Contraseñas { get; set; } = new List<Contraseña>();

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();

    public virtual DatosPersona IdUsuarioNavigation { get; set; } = null!;

    public virtual ICollection<Reservacion> Reservacions { get; set; } = new List<Reservacion>();
}
