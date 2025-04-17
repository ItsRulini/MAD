using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class DatosFiscal
{
    public Guid IdContribuyente { get; set; }

    public string? TipoContribuyente { get; set; }

    public string? RegimenFiscal { get; set; }

    public virtual DatosPersona? DatosPersona { get; set; }

    public virtual Hotel? Hotel { get; set; }
}
