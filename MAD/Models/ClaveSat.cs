using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class ClaveSat
{
    public Guid IdClave { get; set; }

    public long? ClaveSat1 { get; set; }

    public string? ClaveUnidad { get; set; }

    public virtual ICollection<Amenidad> Amenidads { get; set; } = new List<Amenidad>();

    public virtual Unidad? ClaveUnidadNavigation { get; set; }

    public virtual ICollection<Servicio> Servicios { get; set; } = new List<Servicio>();
}
