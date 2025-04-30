using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Hotel
{
    public Guid IdHotel { get; set; }

    public string Rfc { get; set; } = null!;

    public string Nombre { get; set; } = null!;

    public string Domicilio { get; set; } = null!;

    public int NumeroPisos { get; set; }

    public DateOnly FechaInicioOperaciones { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public Guid? IdUsuario { get; set; }

    public Guid? IdUbicacion { get; set; }

    public virtual ICollection<HotelServicio> HotelServicios { get; set; } = new List<HotelServicio>();

    public virtual DatosFiscal IdHotelNavigation { get; set; } = null!;

    public virtual Ubicacion? IdUbicacionNavigation { get; set; }

    public virtual Usuario? IdUsuarioNavigation { get; set; }

    public virtual ICollection<Reservacion> Reservacions { get; set; } = new List<Reservacion>();

    public virtual ICollection<TipoHabitacion> TipoHabitacions { get; set; } = new List<TipoHabitacion>();
}
