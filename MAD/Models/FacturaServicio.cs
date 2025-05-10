using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class FacturaServicio
{
    public Guid IdFactura { get; set; }

    public Guid IdServicio { get; set; }

    public int? Cantidad { get; set; }

    public virtual Factura IdFacturaNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
