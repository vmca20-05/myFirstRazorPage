using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstRazorPage.Models
{
    public class Pelicula
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Estreno { get; set; }
        public bool EnCartelera { get; set; }
    }
}
