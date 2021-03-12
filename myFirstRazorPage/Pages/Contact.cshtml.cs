using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace myFirstRazorPage.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        [TempData]
        public string Nombre { get; set; }

        public void OnGet(int id)
        {
            Message = "El contacto de tu pagina es id :" + id.ToString();
        }
    }
 }
