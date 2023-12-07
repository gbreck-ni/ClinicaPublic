using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class ClinicaContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //DatabaseFacade facade = new DatabaseFacade(this);
        //facade.EnsureCreated();

        optionsBuilder.UseSqlite("Data source = Clinica.db");
    }
    //
    // Modulo 1: Laboratorio
    //
    //public DbSet<Categoria> Categorias { get; set; }
    //public DbSet<Perfil> Perfil { get; set; }
    public DbSet<Examen> Examen { get; set; }
    //public DbSet<Paciente> Paciente { get; set; }
    //public DbSet<Orden> Orden { get; set; }
    //public DbSet<Detalle> Detalle { get; set; }
    ////
    //// Modulo 2: Consultas médicas
    ////
    //public DbSet<Medico> Medico { get; set; }
    //public DbSet<Servicio> Servicio { get; set; }
    //public DbSet<ServicioMedico> ServicioMedico { get; set; }
    //public DbSet<OrdenConsulta> OrdenConsulta { get; set; }
    //public DbSet<OrdenConsultaDetalle> OrdenConsultaDetalle { get; set; }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    //Write Fluent API configurations here

    //    //Property Configurations
    //    modelBuilder.Entity<Detalle>()
    //            .Property(s => s.OrdenId)
    //            .HasColumnName("orden");
    //}
}

