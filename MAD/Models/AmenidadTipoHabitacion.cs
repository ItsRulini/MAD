using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class AmenidadTipoHabitacion
{
    public Guid IdTipoHabitacion { get; set; }

    public Guid IdAmenidad { get; set; }

    public int? Cantidad { get; set; }

    public virtual Amenidad IdAmenidadNavigation { get; set; } = null!;

    public virtual TipoHabitacion IdTipoHabitacionNavigation { get; set; } = null!;
}
