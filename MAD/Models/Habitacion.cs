using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Habitacion
{
    public Guid IdHabitacion { get; set; }

    public int NumeroHabitacion { get; set; }

    public string Estatus { get; set; } = null!;

    public Guid? IdTipoHabitacion { get; set; }

    public Guid? IdHotel { get; set; }

    public virtual Hotel? IdHotelNavigation { get; set; }

    public virtual TipoHabitacion? IdTipoHabitacionNavigation { get; set; }

    public virtual ICollection<ReservacionHabitacion> ReservacionHabitacions { get; set; } = new List<ReservacionHabitacion>();
}
