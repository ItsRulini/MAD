using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Unidad
{
    public string ClaveUnidad { get; set; } = null!;

    public string? Unidad1 { get; set; }

    public virtual ICollection<ClaveSat> ClaveSats { get; set; } = new List<ClaveSat>();
}
