using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Ubicacion
{
    public Guid IdUbicacion { get; set; }

    public string Pais { get; set; } = null!;

    public string Estado { get; set; } = null!;

    public string Ciudad { get; set; } = null!;

    public bool? ZonaTuristica { get; set; }

    public virtual ICollection<Cliente> Clientes { get; set; } = new List<Cliente>();

    public virtual ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}
