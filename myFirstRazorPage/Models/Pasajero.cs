using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace myFirstRazorPage.Models
{
    public class Pasajero
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Este campo {0} es requerido")]
        [StringLength(20)]
        public String Nombre { get; set; }
        [Range(0, 120)]
        public int? Edad { get; set; }
        public Pais Pais { get; set; }
        public string Pregunta { get; set; }
        public string Descripcion { get; set; }
    }

    public enum Pais
    {

        [Display(Name = "--Escoger--")]
        Desconocido = 0,
        [Display(Name = "Republica Dominicana")]
        RepDominicana = 1,
        [Display(Name = "Mexico")]
        Mexico = 2,
        [Display(Name = "Costa Rica")]
        CostaRica = 3
    }

}
