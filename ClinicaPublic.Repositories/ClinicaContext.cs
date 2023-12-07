using Microsoft.EntityFrameworkCore;


public class ClinicaContext : DbContext
{

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data source = Clinica.db");
    }

    public DbSet<Examen> Examen { get; set; }

}

