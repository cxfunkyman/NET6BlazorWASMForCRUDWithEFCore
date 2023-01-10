using Microsoft.EntityFrameworkCore;
using NET6BlazorWASMForCRUDWithEFCore.Server.Models;

namespace NET6BlazorWASMForCRUDWithEFCore.Server.AppDbContext
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
    }
}
