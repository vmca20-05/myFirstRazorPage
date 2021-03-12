using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using myFirstRazorPage.Models;

namespace myFirstRazorPage.Pages.Peliculas
{
    public class DetailsModel : PageModel
    {
        private readonly myFirstRazorPage.Models.ApplicationDbContext _context;

        public DetailsModel(myFirstRazorPage.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public Pelicula Pelicula { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Pelicula = await _context.Peliculas.FirstOrDefaultAsync(m => m.Id == id);

            if (Pelicula == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
