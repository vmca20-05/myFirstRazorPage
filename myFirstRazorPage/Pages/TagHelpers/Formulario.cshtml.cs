using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using myFirstRazorPage.Models;

namespace myFirstRazorPage.Pages.TagHelpers
{
    public class FormularioModel : PageModel
    {
        private readonly myFirstRazorPage.Models.ApplicationDbContext _context;

        public FormularioModel(myFirstRazorPage.Models.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }


        [BindProperty]
        public Pasajero Pasajero { get; set; }

        public List<SelectListItem> PreguntasSeguidad
        {
            get
            {
                string escogido = Pasajero?.Pregunta;
                var preguntas = obtenerPreguntasDeSeguridad();
                var opciones = new List<SelectListItem>();

                foreach (var pregunta in preguntas)
                {

                    opciones.Add(new SelectListItem()
                    {
                        Text = pregunta,
                        Value = pregunta,
                        Selected = pregunta == escogido
                    });

                }
                return opciones;
            }

        }

        private List<string> obtenerPreguntasDeSeguridad()
        {
            return new List<string>()
           {
               "Cual es la nacionalidad de su perro?",
               "Pepsi o Coca cola",
               "Nombre de una persona que usted no conoce?"
           };
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Persona.Add(Pasajero);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}