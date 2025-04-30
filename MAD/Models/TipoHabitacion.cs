using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class TipoHabitacion
{
    public Guid IdTipoHabitacion { get; set; }

    public string NivelHabitacion { get; set; } = null!;

    public decimal PrecioPorPersona { get; set; }

    public decimal PrecioPorNoche { get; set; }

    public int? CanidadMaximaPersonas { get; set; }

    public string Ubicacion { get; set; } = null!;

    public Guid? IdHotel { get; set; }

    public virtual ICollection<AmenidadTipoHabitacion> AmenidadTipoHabitacions { get; set; } = new List<AmenidadTipoHabitacion>();

    public virtual ICollection<CamaTipoHabitacion> CamaTipoHabitacions { get; set; } = new List<CamaTipoHabitacion>();

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();

    public virtual Hotel? IdHotelNavigation { get; set; }
}
