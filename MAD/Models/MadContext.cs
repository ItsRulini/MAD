using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MAD.Models;

public partial class MadContext : DbContext
{
    public MadContext()
    {
    }

    public MadContext(DbContextOptions<MadContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Amenidad> Amenidads { get; set; }

    public virtual DbSet<AmenidadTipoHabitacion> AmenidadTipoHabitacions { get; set; }

    public virtual DbSet<Cancelacion> Cancelacions { get; set; }

    public virtual DbSet<ClaveSat> ClaveSats { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Contraseña> Contraseñas { get; set; }

    public virtual DbSet<DatosFiscal> DatosFiscals { get; set; }

    public virtual DbSet<DatosPersona> DatosPersonas { get; set; }

    public virtual DbSet<Factura> Facturas { get; set; }

    public virtual DbSet<Habitacion> Habitacions { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<HotelServicio> HotelServicios { get; set; }

    public virtual DbSet<Reservacion> Reservacions { get; set; }

    public virtual DbSet<ReservacionHabitacion> ReservacionHabitacions { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<TipoHabitacion> TipoHabitacions { get; set; }

    public virtual DbSet<Ubicacion> Ubicacions { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=MERA; Database=MAD; Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Amenidad>(entity =>
        {
            entity.HasKey(e => e.IdAmenidad).HasName("PK__Amenidad__C0646E1AF54ED9CD");

            entity.ToTable("Amenidad");

            entity.Property(e => e.IdAmenidad)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idAmenidad");
            entity.Property(e => e.Amenidad1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("amenidad");
            entity.Property(e => e.IdClave).HasColumnName("idClave");

            entity.HasOne(d => d.IdClaveNavigation).WithMany(p => p.Amenidads)
                .HasForeignKey(d => d.IdClave)
                .HasConstraintName("FK__Amenidad__idClav__7B5B524B");
        });

        modelBuilder.Entity<AmenidadTipoHabitacion>(entity =>
        {
            entity.HasKey(e => new { e.IdTipoHabitacion, e.IdAmenidad }).HasName("PK__Amenidad__D8CB798800F6A286");

            entity.ToTable("Amenidad_TipoHabitacion");

            entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");
            entity.Property(e => e.IdAmenidad).HasColumnName("idAmenidad");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdAmenidadNavigation).WithMany(p => p.AmenidadTipoHabitacions)
                .HasForeignKey(d => d.IdAmenidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Amenidad___idAme__7F2BE32F");

            entity.HasOne(d => d.IdTipoHabitacionNavigation).WithMany(p => p.AmenidadTipoHabitacions)
                .HasForeignKey(d => d.IdTipoHabitacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Amenidad___idTip__7E37BEF6");
        });

        modelBuilder.Entity<Cancelacion>(entity =>
        {
            entity.HasKey(e => e.IdCancelacion).HasName("PK__Cancelac__43AFFBEBFF59E8F2");

            entity.ToTable("Cancelacion");

            entity.Property(e => e.IdCancelacion)
                .ValueGeneratedNever()
                .HasColumnName("idCancelacion");
            entity.Property(e => e.FechaCancelacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaCancelacion");
            entity.Property(e => e.IdAdministrador).HasColumnName("idAdministrador");

            entity.HasOne(d => d.IdAdministradorNavigation).WithMany(p => p.Cancelacions)
                .HasForeignKey(d => d.IdAdministrador)
                .HasConstraintName("FK__Cancelaci__idAdm__41EDCAC5");

            entity.HasOne(d => d.IdCancelacionNavigation).WithOne(p => p.Cancelacion)
                .HasForeignKey<Cancelacion>(d => d.IdCancelacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cancelaci__idCan__14270015");
        });

        modelBuilder.Entity<ClaveSat>(entity =>
        {
            entity.HasKey(e => e.IdClave).HasName("PK__ClaveSAT__1730A2862028C23D");

            entity.ToTable("ClaveSAT");

            entity.Property(e => e.IdClave)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idClave");
            entity.Property(e => e.ClaveSat1).HasColumnName("claveSAT");
            entity.Property(e => e.ClaveUnidad)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("claveUnidad");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente).HasName("PK__Cliente__885457EEFA337D63");

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente)
                .ValueGeneratedNever()
                .HasColumnName("idCliente");
            entity.Property(e => e.EstadoCivil)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("estadoCivil");
            entity.Property(e => e.IdUbicacion).HasColumnName("idUbicacion");
            entity.Property(e => e.Rfc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("rfc");

            entity.HasOne(d => d.IdClienteNavigation).WithOne(p => p.Cliente)
                .HasForeignKey<Cliente>(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Cliente__idClien__5AEE82B9");

            entity.HasOne(d => d.IdUbicacionNavigation).WithMany(p => p.Clientes)
                .HasForeignKey(d => d.IdUbicacion)
                .HasConstraintName("FK__Cliente__idUbica__5BE2A6F2");
        });

        modelBuilder.Entity<Contraseña>(entity =>
        {
            entity.HasKey(e => e.IdContraseña).HasName("PK__Contrase__8458F95376A9C9BF");

            entity.ToTable("Contraseña");

            entity.Property(e => e.IdContraseña)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idContraseña");
            entity.Property(e => e.Contraseña1)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("contraseña");
            entity.Property(e => e.FechaCreacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaCreacion");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Contraseñas)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Contraseñ__idUsu__30C33EC3");
        });

        modelBuilder.Entity<DatosFiscal>(entity =>
        {
            entity.HasKey(e => e.IdContribuyente).HasName("PK__DatosFis__79E6F33FD893ED1F");

            entity.ToTable("DatosFiscal");

            entity.Property(e => e.IdContribuyente)
                .ValueGeneratedNever()
                .HasColumnName("idContribuyente");
            entity.Property(e => e.RegimenFiscal)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("regimenFiscal");
            entity.Property(e => e.TipoContribuyente)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("tipoContribuyente");
        });

        modelBuilder.Entity<DatosPersona>(entity =>
        {
            entity.HasKey(e => e.IdPersona).HasName("PK__DatosPer__A47881417B5CA39E");

            entity.ToTable("DatosPersona");

            entity.HasIndex(e => e.Correo, "UQ__DatosPer__2A586E0B81223B59").IsUnique();

            entity.Property(e => e.IdPersona)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idPersona");
            entity.Property(e => e.Celular).HasColumnName("celular");
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("correo");
            entity.Property(e => e.FechaNacimiento).HasColumnName("fechaNacimiento");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.Materno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("materno");
            entity.Property(e => e.Nombres)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombres");
            entity.Property(e => e.Paterno)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("paterno");
            entity.Property(e => e.TelefonoCasa).HasColumnName("telefonoCasa");

            entity.HasOne(d => d.IdPersonaNavigation).WithOne(p => p.DatosPersona)
                .HasForeignKey<DatosPersona>(d => d.IdPersona)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__DatosPers__idPer__46E78A0C");
        });

        modelBuilder.Entity<Factura>(entity =>
        {
            entity.HasKey(e => e.IdFactura).HasName("PK__Factura__3CD5687EC567CCAB");

            entity.ToTable("Factura");

            entity.Property(e => e.IdFactura)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idFactura");
            entity.Property(e => e.IdReservacion).HasColumnName("idReservacion");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("montoTotal");

            entity.HasOne(d => d.IdReservacionNavigation).WithMany(p => p.Facturas)
                .HasForeignKey(d => d.IdReservacion)
                .HasConstraintName("FK__Factura__idReser__18EBB532");

            entity.HasMany(d => d.IdServicios).WithMany(p => p.IdFacturas)
                .UsingEntity<Dictionary<string, object>>(
                    "FacturaServicio",
                    r => r.HasOne<Servicio>().WithMany()
                        .HasForeignKey("IdServicio")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Factura_S__idSer__1CBC4616"),
                    l => l.HasOne<Factura>().WithMany()
                        .HasForeignKey("IdFactura")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__Factura_S__idFac__1BC821DD"),
                    j =>
                    {
                        j.HasKey("IdFactura", "IdServicio").HasName("PK__Factura___B03EF06FEBB1C84D");
                        j.ToTable("Factura_Servicio");
                        j.IndexerProperty<Guid>("IdFactura").HasColumnName("idFactura");
                        j.IndexerProperty<Guid>("IdServicio").HasColumnName("idServicio");
                    });
        });

        modelBuilder.Entity<Habitacion>(entity =>
        {
            entity.HasKey(e => e.IdHabitacion).HasName("PK__Habitaci__D9D53BE2D1FB339B");

            entity.ToTable("Habitacion");

            entity.Property(e => e.IdHabitacion)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idHabitacion");
            entity.Property(e => e.Estatus)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("estatus");
            entity.Property(e => e.IdHotel).HasColumnName("idHotel");
            entity.Property(e => e.IdTipoHabitacion).HasColumnName("idTipoHabitacion");
            entity.Property(e => e.NumeroHabitacion).HasColumnName("numeroHabitacion");

            entity.HasOne(d => d.IdHotelNavigation).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.IdHotel)
                .HasConstraintName("FK__Habitacio__idHot__04E4BC85");

            entity.HasOne(d => d.IdTipoHabitacionNavigation).WithMany(p => p.Habitacions)
                .HasForeignKey(d => d.IdTipoHabitacion)
                .HasConstraintName("FK__Habitacio__idTip__03F0984C");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.IdHotel).HasName("PK__Hotel__AE924C1C3C301816");

            entity.ToTable("Hotel");

            entity.Property(e => e.IdHotel)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idHotel");
            entity.Property(e => e.Domicilio)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("domicilio");
            entity.Property(e => e.FechaInicioOperaciones).HasColumnName("fechaInicioOperaciones");
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaRegistro");
            entity.Property(e => e.IdUbicacion).HasColumnName("idUbicacion");
            entity.Property(e => e.IdUsuario).HasColumnName("idUsuario");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NumeroPisos).HasColumnName("numeroPisos");
            entity.Property(e => e.Rfc)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("rfc");

            entity.HasOne(d => d.IdHotelNavigation).WithOne(p => p.Hotel)
                .HasForeignKey<Hotel>(d => d.IdHotel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Hotel__idHotel__6A30C649");

            entity.HasOne(d => d.IdUbicacionNavigation).WithMany(p => p.Hotels)
                .HasForeignKey(d => d.IdUbicacion)
                .HasConstraintName("FK__Hotel__idUbicaci__693CA210");

            entity.HasOne(d => d.IdUsuarioNavigation).WithMany(p => p.Hotels)
                .HasForeignKey(d => d.IdUsuario)
                .HasConstraintName("FK__Hotel__idUsuario__68487DD7");
        });

        modelBuilder.Entity<HotelServicio>(entity =>
        {
            entity.HasKey(e => new { e.IdHotel, e.IdServicio }).HasName("PK__Hotel_Se__2279D40DBF025294");

            entity.ToTable("Hotel_Servicio");

            entity.Property(e => e.IdHotel).HasColumnName("idHotel");
            entity.Property(e => e.IdServicio).HasColumnName("idServicio");
            entity.Property(e => e.Cantidad).HasColumnName("cantidad");
            entity.Property(e => e.Precio)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("precio");

            entity.HasOne(d => d.IdHotelNavigation).WithMany(p => p.HotelServicios)
                .HasForeignKey(d => d.IdHotel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Hotel_Ser__idHot__0F624AF8");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.HotelServicios)
                .HasForeignKey(d => d.IdServicio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Hotel_Ser__idSer__10566F31");
        });

        modelBuilder.Entity<Reservacion>(entity =>
        {
            entity.HasKey(e => e.IdReservacion).HasName("PK__Reservac__C813D8AD09F4127B");

            entity.ToTable("Reservacion");

            entity.Property(e => e.IdReservacion)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idReservacion");
            entity.Property(e => e.Anticipo)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("anticipo");
            entity.Property(e => e.CheckIn)
                .HasDefaultValue(false)
                .HasColumnName("checkIn");
            entity.Property(e => e.ChekOut)
                .HasDefaultValue(false)
                .HasColumnName("chekOut");
            entity.Property(e => e.FechaFinHospedaje).HasColumnName("fechaFinHospedaje");
            entity.Property(e => e.FechaInicioHospedaje).HasColumnName("fechaInicioHospedaje");
            entity.Property(e => e.FechaReservacion)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime")
                .HasColumnName("fechaReservacion");
            entity.Property(e => e.IdComprador).HasColumnName("idComprador");
            entity.Property(e => e.IdHotel).HasColumnName("idHotel");
            entity.Property(e => e.IdVendedor).HasColumnName("idVendedor");
            entity.Property(e => e.MetodoPago)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("metodoPago");
            entity.Property(e => e.MontoTotal)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("montoTotal");

            entity.HasOne(d => d.IdCompradorNavigation).WithMany(p => p.Reservacions)
                .HasForeignKey(d => d.IdComprador)
                .HasConstraintName("FK__Reservaci__idCom__71D1E811");

            entity.HasOne(d => d.IdHotelNavigation).WithMany(p => p.Reservacions)
                .HasForeignKey(d => d.IdHotel)
                .HasConstraintName("FK__Reservaci__idHot__73BA3083");

            entity.HasOne(d => d.IdVendedorNavigation).WithMany(p => p.Reservacions)
                .HasForeignKey(d => d.IdVendedor)
                .HasConstraintName("FK__Reservaci__idVen__72C60C4A");
        });

        modelBuilder.Entity<ReservacionHabitacion>(entity =>
        {
            entity.HasKey(e => new { e.IdReservacion, e.IdHabitacion }).HasName("PK__Reservac__F58E8B13E065B7D7");

            entity.ToTable("Reservacion_Habitacion");

            entity.Property(e => e.IdReservacion).HasColumnName("idReservacion");
            entity.Property(e => e.IdHabitacion).HasColumnName("idHabitacion");
            entity.Property(e => e.CantidadPersonas).HasColumnName("cantidadPersonas");

            entity.HasOne(d => d.IdHabitacionNavigation).WithMany(p => p.ReservacionHabitacions)
                .HasForeignKey(d => d.IdHabitacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservaci__idHab__08B54D69");

            entity.HasOne(d => d.IdReservacionNavigation).WithMany(p => p.ReservacionHabitacions)
                .HasForeignKey(d => d.IdReservacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reservaci__idRes__07C12930");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.IdServicio).HasName("PK__Servicio__CEB98119F240CE45");

            entity.ToTable("Servicio");

            entity.Property(e => e.IdServicio)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idServicio");
            entity.Property(e => e.IdClave).HasColumnName("idClave");
            entity.Property(e => e.Nombre)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombre");

            entity.HasOne(d => d.IdClaveNavigation).WithMany(p => p.Servicios)
                .HasForeignKey(d => d.IdClave)
                .HasConstraintName("FK__Servicio__idClav__0C85DE4D");
        });

        modelBuilder.Entity<TipoHabitacion>(entity =>
        {
            entity.HasKey(e => e.IdTipoHabitacion).HasName("PK__TipoHabi__64CD3F69143ADDB2");

            entity.ToTable("TipoHabitacion");

            entity.Property(e => e.IdTipoHabitacion)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idTipoHabitacion");
            entity.Property(e => e.CanidadMaximaPersonas).HasColumnName("canidadMaximaPersonas");
            entity.Property(e => e.NivelHabitacion)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("nivelHabitacion");
            entity.Property(e => e.NumeroCama).HasColumnName("numeroCama");
            entity.Property(e => e.PrecioPorNoche)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("precioPorNoche");
            entity.Property(e => e.PrecioPorPersona)
                .HasColumnType("decimal(7, 2)")
                .HasColumnName("precioPorPersona");
            entity.Property(e => e.TipoCama)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("tipoCama");
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ubicacion");
        });

        modelBuilder.Entity<Ubicacion>(entity =>
        {
            entity.HasKey(e => e.IdUbicacion).HasName("PK__Ubicacio__174D150E5FFD1089");

            entity.ToTable("Ubicacion");

            entity.Property(e => e.IdUbicacion)
                .HasDefaultValueSql("(newid())")
                .HasColumnName("idUbicacion");
            entity.Property(e => e.Ciudad)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("ciudad");
            entity.Property(e => e.Estado)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("estado");
            entity.Property(e => e.Pais)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("pais");
            entity.Property(e => e.ZonaTuristica)
                .HasDefaultValue(false)
                .HasColumnName("zonaTuristica");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.IdUsuario).HasName("PK__Usuario__645723A62FF11CC3");

            entity.ToTable("Usuario");

            entity.Property(e => e.IdUsuario)
                .ValueGeneratedNever()
                .HasColumnName("idUsuario");
            entity.Property(e => e.Estado)
                .HasDefaultValue(true)
                .HasColumnName("estado");
            entity.Property(e => e.Nomina).HasColumnName("nomina");
            entity.Property(e => e.TipoUsuario)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipoUsuario");

            entity.HasOne(d => d.IdUsuarioNavigation).WithOne(p => p.Usuario)
                .HasForeignKey<Usuario>(d => d.IdUsuario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Usuario__idUsuar__4F7CD00D");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
