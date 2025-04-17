using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Cancelacion
{
    public Guid IdCancelacion { get; set; }

    public DateTime? FechaCancelacion { get; set; }

    public Guid? IdAdministrador { get; set; }

    public virtual Usuario? IdAdministradorNavigation { get; set; }

    public virtual Reservacion IdCancelacionNavigation { get; set; } = null!;
}
