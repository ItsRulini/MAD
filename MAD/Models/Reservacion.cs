using System;
using System.Collections.Generic;

namespace MAD.Models;

public partial class Reservacion
{
    public Guid IdReservacion { get; set; }

    public string? MetodoPago { get; set; }

    public decimal? Anticipo { get; set; }

    public decimal? MontoTotal { get; set; }

    public DateOnly? FechaInicioHospedaje { get; set; }

    public DateOnly? FechaFinHospedaje { get; set; }

    public bool? CheckIn { get; set; }

    public bool? ChekOut { get; set; }

    public DateTime? FechaReservacion { get; set; }

    public Guid? IdComprador { get; set; }

    public Guid? IdVendedor { get; set; }

    public Guid? IdHotel { get; set; }

    public virtual Cancelacion? Cancelacion { get; set; }

    public virtual ICollection<Factura> Facturas { get; set; } = new List<Factura>();

    public virtual Cliente? IdCompradorNavigation { get; set; }

    public virtual Hotel? IdHotelNavigation { get; set; }

    public virtual Usuario? IdVendedorNavigation { get; set; }

    public virtual ICollection<ReservacionHabitacion> ReservacionHabitacions { get; set; } = new List<ReservacionHabitacion>();
}
