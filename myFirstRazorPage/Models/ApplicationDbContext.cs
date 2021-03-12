using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstRazorPage.Models
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options){}

        public DbSet<Pelicula> Peliculas { get; set; }

        public DbSet<myFirstRazorPage.Models.Pasajero> Persona { get; set; }
    }
}
