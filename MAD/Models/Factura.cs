using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Factura
{
    public Guid IdFactura { get; set; }

    public Guid? IdReservacion { get; set; }

    public decimal? MontoTotal { get; set; }

    public virtual ICollection<FacturaServicio> FacturaServicios { get; set; } = new List<FacturaServicio>();

    public virtual Reservacion? IdReservacionNavigation { get; set; }
}
