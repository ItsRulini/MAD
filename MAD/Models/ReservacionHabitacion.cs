using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class ReservacionHabitacion
{
    public Guid IdReservacion { get; set; }

    public Guid IdHabitacion { get; set; }

    public int CantidadPersonas { get; set; }

    public virtual Habitacion IdHabitacionNavigation { get; set; } = null!;

    public virtual Reservacion IdReservacionNavigation { get; set; } = null!;
}
