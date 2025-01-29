using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BroncoFlex.Models;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Anestesia> Anestesias { get; set; }

    public virtual DbSet<Broncoscopio> Broncoscopios { get; set; }

    public virtual DbSet<Cargo> Cargos { get; set; }

    public virtual DbSet<Cobertura> Coberturas { get; set; }

    public virtual DbSet<Colore> Colores { get; set; }

    public virtual DbSet<Determinacione> Determinaciones { get; set; }

    public virtual DbSet<Entorno> Entornos { get; set; }

    public virtual DbSet<Ficha> Fichas { get; set; }

    public virtual DbSet<Imagene> Imagenes { get; set; }

    public virtual DbSet<Indicacione> Indicaciones { get; set; }

    public virtual DbSet<Laboratorio> Laboratorios { get; set; }

    public virtual DbSet<Muestra> Muestras { get; set; }

    public virtual DbSet<Paciente> Pacientes { get; set; }

    public virtual DbSet<Pendiente> Pendientes { get; set; }

    public virtual DbSet<Personal> Personals { get; set; }

    public virtual DbSet<Precaucione> Precauciones { get; set; }

    public virtual DbSet<Procedimiento> Procedimientos { get; set; }

    public virtual DbSet<RelProcedimientosPedido> RelProcedimientosPedidos { get; set; }

    public virtual DbSet<Servicio> Servicios { get; set; }

    public virtual DbSet<Turno> Turnos { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=tcp:broncoflex.database.windows.net,1433;Initial Catalog=BroncoFlexDB;Persist Security Info=False;User ID=hiannella;Password=K^HWFDSwQn+,.U@D@8-0;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=90;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Anestesia>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Anestesi__3214EC071FF95E64");

            entity.Property(e => e.Anestesia1)
                .HasMaxLength(50)
                .HasColumnName("Anestesia");
        });

        modelBuilder.Entity<Broncoscopio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Broncosc__3214EC075BE26BC3");

            entity.Property(e => e.Canal).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.Diametro).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.EsEbus).HasColumnName("EsEBUS");
            entity.Property(e => e.Modelo).HasMaxLength(100);
            entity.Property(e => e.NroPatrimonio).HasMaxLength(6);
        });

        modelBuilder.Entity<Cargo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cargos__3214EC07C519D779");

            entity.Property(e => e.Cargo1)
                .HasMaxLength(50)
                .HasColumnName("Cargo");
        });

        modelBuilder.Entity<Cobertura>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Cobertur__3214EC07E898994B");

            entity.Property(e => e.Cobertura1)
                .HasMaxLength(200)
                .HasColumnName("Cobertura");
            entity.Property(e => e.Rnos)
                .HasMaxLength(50)
                .HasColumnName("RNOS");
            entity.Property(e => e.Sigla).HasMaxLength(50);
        });

        modelBuilder.Entity<Colore>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Colores__3214EC078096DA0B");

            entity.Property(e => e.Color)
                .HasMaxLength(7)
                .IsFixedLength();
            entity.Property(e => e.Descripcion).HasMaxLength(50);
        });

        modelBuilder.Entity<Determinacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Determin__3214EC0748002F93");

            entity.Property(e => e.CentroReceptor).HasMaxLength(50);
            entity.Property(e => e.Comentarios).HasMaxLength(250);
            entity.Property(e => e.Determinacion).HasMaxLength(100);
            entity.Property(e => e.Piso).HasMaxLength(2);
            entity.Property(e => e.Sector).HasMaxLength(50);
        });

        modelBuilder.Entity<Entorno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Entornos__3214EC077DE6BC52");

            entity.Property(e => e.Entorno1)
                .HasMaxLength(50)
                .HasColumnName("Entorno");
        });

        modelBuilder.Entity<Ficha>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Fichas__3214EC070222CA39");

            entity.Property(e => e.Antecedentes).HasMaxLength(250);
            entity.Property(e => e.EnfermedadActual).HasMaxLength(250);
            entity.Property(e => e.EstudiosPrevios).HasMaxLength(250);
            entity.Property(e => e.Medicacion).HasMaxLength(250);
            entity.Property(e => e.Observaciones).HasMaxLength(250);

            entity.HasOne(d => d.IdAnestesiaPrevistaNavigation).WithMany(p => p.Fichas)
                .HasForeignKey(d => d.IdAnestesiaPrevista)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ficha_Anestesia");

            entity.HasOne(d => d.IdMedicoAtencionNavigation).WithMany(p => p.Fichas)
                .HasForeignKey(d => d.IdMedicoAtencion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ficha_Personal");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Fichas)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Ficha_Paciente");

            entity.HasOne(d => d.IdServicioNavigation).WithMany(p => p.Fichas)
                .HasForeignKey(d => d.IdServicio)
                .HasConstraintName("FK_Ficha_Servicios");

            entity.HasMany(d => d.IdIndicacions).WithMany(p => p.IdFichas)
                .UsingEntity<Dictionary<string, object>>(
                    "RelFichasIndicacione",
                    r => r.HasOne<Indicacione>().WithMany()
                        .HasForeignKey("IdIndicacion")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_relFichas_Indicaciones_Indicaciones"),
                    l => l.HasOne<Ficha>().WithMany()
                        .HasForeignKey("IdFicha")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_relFichas_Indicaciones_Fichas"),
                    j =>
                    {
                        j.HasKey("IdFicha", "IdIndicacion");
                        j.ToTable("relFichas_Indicaciones");
                    });

            entity.HasMany(d => d.IdPendientes).WithMany(p => p.IdFichas)
                .UsingEntity<Dictionary<string, object>>(
                    "RelFichasPendiente",
                    r => r.HasOne<Pendiente>().WithMany()
                        .HasForeignKey("IdPendiente")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_relFichas_Pendientes_Pendientes"),
                    l => l.HasOne<Ficha>().WithMany()
                        .HasForeignKey("IdFicha")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_relFichas_Pendientes_Fichas"),
                    j =>
                    {
                        j.HasKey("IdFicha", "IdPendiente");
                        j.ToTable("relFichas_Pendientes");
                    });

            entity.HasMany(d => d.IdPrecaucions).WithMany(p => p.IdFichas)
                .UsingEntity<Dictionary<string, object>>(
                    "RelFichasPrecaucione",
                    r => r.HasOne<Precaucione>().WithMany()
                        .HasForeignKey("IdPrecaucion")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_relFichas_Precauciones_Precauciones"),
                    l => l.HasOne<Ficha>().WithMany()
                        .HasForeignKey("IdFicha")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK_relFichas_Precauciones_Fichas"),
                    j =>
                    {
                        j.HasKey("IdFicha", "IdPrecaucion");
                        j.ToTable("relFichas_Precauciones");
                    });
        });

        modelBuilder.Entity<Imagene>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Imagenes__3214EC07679E9BE3");

            entity.Property(e => e.Descripcion).HasMaxLength(250);
            entity.Property(e => e.Dvd).HasColumnName("DVD");
            entity.Property(e => e.Password).HasMaxLength(100);
            entity.Property(e => e.Url)
                .HasMaxLength(100)
                .HasColumnName("URL");
            entity.Property(e => e.Usb).HasColumnName("USB");
            entity.Property(e => e.Usuario).HasMaxLength(50);

            entity.HasOne(d => d.IdFichaNavigation).WithMany(p => p.Imagenes)
                .HasForeignKey(d => d.IdFicha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fichas_Imagenes");
        });

        modelBuilder.Entity<Indicacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Indicaci__3214EC07DE4F4C10");

            entity.Property(e => e.Indicacion).HasMaxLength(100);
        });

        modelBuilder.Entity<Laboratorio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Laborato__3214EC07BAE70388");

            entity.Property(e => e.Creatinina).HasColumnType("decimal(1, 1)");
            entity.Property(e => e.Gb).HasColumnName("GB");
            entity.Property(e => e.Hb).HasColumnType("decimal(1, 1)");
            entity.Property(e => e.Hto).HasColumnType("decimal(2, 1)");
            entity.Property(e => e.Kptt).HasColumnName("KPTT");
            entity.Property(e => e.Tp).HasColumnName("TP");

            entity.HasOne(d => d.IdFichaNavigation).WithMany(p => p.Laboratorios)
                .HasForeignKey(d => d.IdFicha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fichas_Laboratorios");
        });

        modelBuilder.Entity<Muestra>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Muestras__3214EC07D65A05BE");

            entity.Property(e => e.Muestra1)
                .HasMaxLength(100)
                .HasColumnName("Muestra");
        });

        modelBuilder.Entity<Paciente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Paciente__3214EC0715217F5F");

            entity.Property(e => e.Apellidos).HasMaxLength(50);
            entity.Property(e => e.Domicilio).HasMaxLength(200);
            entity.Property(e => e.Email)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.GooglePlacesId)
                .HasMaxLength(200)
                .HasColumnName("GooglePlacesID");
            entity.Property(e => e.Nombres).HasMaxLength(50);
            entity.Property(e => e.NroAfiliado).HasMaxLength(50);
            entity.Property(e => e.NroDocumento)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NroTelefonoLinea)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.NroTelefonoMovil)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.TipoDocumento)
                .HasMaxLength(29)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCoberturaNavigation).WithMany(p => p.Pacientes)
                .HasForeignKey(d => d.IdCobertura)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Paciente_Cobertura");
        });

        modelBuilder.Entity<Pendiente>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Pendient__3214EC07609A84D1");

            entity.Property(e => e.Pendiente1)
                .HasMaxLength(100)
                .HasColumnName("Pendiente");
        });

        modelBuilder.Entity<Personal>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Personal__3214EC07AD6D507E");

            entity.ToTable("Personal");

            entity.Property(e => e.Apellidos).HasMaxLength(50);
            entity.Property(e => e.Nombres).HasMaxLength(50);
            entity.Property(e => e.NroLegajo)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.NroMatricula)
                .HasMaxLength(6)
                .IsUnicode(false);

            entity.HasOne(d => d.IdCargoNavigation).WithMany(p => p.Personals)
                .HasForeignKey(d => d.IdCargo)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Personal_Cargo");
        });

        modelBuilder.Entity<Precaucione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Precauci__3214EC07CAF73989");

            entity.Property(e => e.Precaucion).HasMaxLength(100);
        });

        modelBuilder.Entity<Procedimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Procedim__3214EC07A52E174E");

            entity.HasIndex(e => e.IdFicha, "AK_Procedimientos_IdFicha").IsUnique();

            entity.Property(e => e.Comentarios).HasMaxLength(400);
            entity.Property(e => e.Informe).HasMaxLength(4000);
            entity.Property(e => e.Rose).HasColumnName("ROSE");

            entity.HasOne(d => d.IdAnestesiaNavigation).WithMany(p => p.Procedimientos)
                .HasForeignKey(d => d.IdAnestesia)
                .HasConstraintName("FK_Procedimientos_Anestesias");

            entity.HasOne(d => d.IdAnestesiologoNavigation).WithMany(p => p.ProcedimientoIdAnestesiologoNavigations)
                .HasForeignKey(d => d.IdAnestesiologo)
                .HasConstraintName("FK_Procedimientos_Personal_4");

            entity.HasOne(d => d.IdAsistenteNavigation).WithMany(p => p.ProcedimientoIdAsistenteNavigations)
                .HasForeignKey(d => d.IdAsistente)
                .HasConstraintName("FK_Procedimientos_Personal_3");

            entity.HasOne(d => d.IdAyudanteNavigation).WithMany(p => p.ProcedimientoIdAyudanteNavigations)
                .HasForeignKey(d => d.IdAyudante)
                .HasConstraintName("FK_Procedimientos_Personal_2");

            entity.HasOne(d => d.IdBroncoscopioNavigation).WithMany(p => p.Procedimientos)
                .HasForeignKey(d => d.IdBroncoscopio)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Procedimientos_Broncoscopios");

            entity.HasOne(d => d.IdEntornoNavigation).WithMany(p => p.Procedimientos)
                .HasForeignKey(d => d.IdEntorno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Procedimientos_Entornos");

            entity.HasOne(d => d.IdFichaNavigation).WithOne(p => p.Procedimiento)
                .HasForeignKey<Procedimiento>(d => d.IdFicha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Procedimientos_Fichas");

            entity.HasOne(d => d.IdOperadorNavigation).WithMany(p => p.ProcedimientoIdOperadorNavigations)
                .HasForeignKey(d => d.IdOperador)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Procedimientos_Personal_1");

            entity.HasOne(d => d.IdPacienteNavigation).WithMany(p => p.Procedimientos)
                .HasForeignKey(d => d.IdPaciente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Procedimientos_Paciente");

            entity.HasOne(d => d.IdPatologoNavigation).WithMany(p => p.ProcedimientoIdPatologoNavigations)
                .HasForeignKey(d => d.IdPatologo)
                .HasConstraintName("FK_Procedimientos_Personal_5");
        });

        modelBuilder.Entity<RelProcedimientosPedido>(entity =>
        {
            entity.HasKey(e => new { e.IdProcedimiento, e.IdMuestra, e.IdDeterminacion });

            entity.ToTable("relProcedimientos_Pedidos");

            entity.HasOne(d => d.IdDeterminacionNavigation).WithMany(p => p.RelProcedimientosPedidos)
                .HasForeignKey(d => d.IdDeterminacion)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_relProcedimientos_Pedidos_Determinaciones");

            entity.HasOne(d => d.IdMuestraNavigation).WithMany(p => p.RelProcedimientosPedidos)
                .HasForeignKey(d => d.IdMuestra)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_relProcedimientos_Pedidos_Muestras");

            entity.HasOne(d => d.IdProcedimientoNavigation).WithMany(p => p.RelProcedimientosPedidos)
                .HasForeignKey(d => d.IdProcedimiento)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_relProcedimientos_Pedidos_Procedimientos");
        });

        modelBuilder.Entity<Servicio>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Servicio__3214EC07331D807F");

            entity.Property(e => e.Servicio1)
                .HasMaxLength(50)
                .HasColumnName("Servicio");
        });

        modelBuilder.Entity<Turno>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Turnos__3214EC07259D37C1");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Descripcion).HasMaxLength(250);

            entity.HasOne(d => d.IdColorNavigation).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.IdColor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Turnos_Colores");

            entity.HasOne(d => d.IdFichaNavigation).WithMany(p => p.Turnos)
                .HasForeignKey(d => d.IdFicha)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Fichas_Turnos");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User__3214EC07C5547948");

            entity.ToTable("User");

            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.CreateDate).HasDefaultValueSql("(getutcdate())");
            entity.Property(e => e.EmailAddress).HasMaxLength(150);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.LastName).HasMaxLength(50);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
