using Microsoft.EntityFrameworkCore;

namespace initiation.Data;
public class ApplicationDbContext : DbContext{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options )
        :base(options)
    {
    }
    public DbSet<Patient> Patients { get; set; }


}