using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class TipoHabitacion
{
    public Guid IdTipoHabitacion { get; set; }

    public string NivelHabitacion { get; set; } = null!;

    public int NumeroCama { get; set; }

    public string TipoCama { get; set; } = null!;

    public decimal PrecioPorPersona { get; set; }

    public decimal PrecioPorNoche { get; set; }

    public int? CanidadMaximaPersonas { get; set; }

    public string Ubicacion { get; set; } = null!;

    public virtual ICollection<AmenidadTipoHabitacion> AmenidadTipoHabitacions { get; set; } = new List<AmenidadTipoHabitacion>();

    public virtual ICollection<Habitacion> Habitacions { get; set; } = new List<Habitacion>();
}
