using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Servicio
{
    public Guid IdServicio { get; set; }

    public string Nombre { get; set; } = null!;

    public Guid? IdClave { get; set; }

    public virtual ICollection<HotelServicio> HotelServicios { get; set; } = new List<HotelServicio>();

    public virtual ClaveSat? IdClaveNavigation { get; set; }

    public virtual ICollection<Factura> IdFacturas { get; set; } = new List<Factura>();
}
