using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Contraseña
{
    public Guid IdContraseña { get; set; }

    public string? Contraseña1 { get; set; }

    public DateTime? FechaCreacion { get; set; }

    public Guid? IdUsuario { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }
}
