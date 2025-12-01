using API.Movies.DLA.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Movies.DLA
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base(options)
        {
        
        }

        //seccion para crear el dbset de las entidades o modelos
        public DbSet<Category> Categories { get; set; }  

    }
}
