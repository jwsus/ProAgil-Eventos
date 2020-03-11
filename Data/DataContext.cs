using Microsoft.EntityFrameworkCore;
using ProaAgil.API.Model;

namespace ProaAgil.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext>options) : base (options){}

        public DbSet<Event> Events { get; set; }
    }
}