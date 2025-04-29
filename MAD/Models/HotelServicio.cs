using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class HotelServicio
{
    public Guid IdHotel { get; set; }

    public Guid IdServicio { get; set; }

    public decimal? Precio { get; set; }

    public virtual Hotel IdHotelNavigation { get; set; } = null!;

    public virtual Servicio IdServicioNavigation { get; set; } = null!;
}
