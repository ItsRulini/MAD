using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Amenidad
{
    public Guid IdAmenidad { get; set; }

    public string Amenidad1 { get; set; } = null!;

    public Guid? IdClave { get; set; }

    public virtual ICollection<AmenidadTipoHabitacion> AmenidadTipoHabitacions { get; set; } = new List<AmenidadTipoHabitacion>();

    public virtual ClaveSat? IdClaveNavigation { get; set; }
}
