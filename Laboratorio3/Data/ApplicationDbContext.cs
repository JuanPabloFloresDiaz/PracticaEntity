using Microsoft.EntityFrameworkCore;
using Laboratorio3.Models;

namespace Laboratorio3.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Vehiculo> Vehiculos { get; set; }
    }
}
