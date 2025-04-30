using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class CamaTipoHabitacion
{
    public Guid IdTipoCama { get; set; }

    public Guid IdTipoHabitacion { get; set; }

    public string TipoCama { get; set; } = null!;

    public int CantidadCama { get; set; }

    public virtual TipoHabitacion IdTipoHabitacionNavigation { get; set; } = null!;
}
