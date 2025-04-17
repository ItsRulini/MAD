using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class DatosPersona
{
    public Guid IdPersona { get; set; }

    public string Correo { get; set; } = null!;

    public string Nombres { get; set; } = null!;

    public string Paterno { get; set; } = null!;

    public string Materno { get; set; } = null!;

    public DateOnly FechaNacimiento { get; set; }

    public long TelefonoCasa { get; set; }

    public long Celular { get; set; }

    public DateTime? FechaRegistro { get; set; }

    public virtual Cliente? Cliente { get; set; }

    public virtual DatosFiscal IdPersonaNavigation { get; set; } = null!;

    public virtual Usuario? Usuario { get; set; }
}
