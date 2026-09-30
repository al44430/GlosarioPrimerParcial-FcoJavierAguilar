using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using GlosarioPrimerParcial_FcoJavierAguilar.Models;


namespace GlosarioPrimerParcial_FcoJavierAguilar.Pages
{
    public class CssModel : PageModel
    {
        public static List<Termino> GlosarioCss { get; set; } = new List<Termino>();
        public void OnGet()
        {
            if (GlosarioCss.Count == 0)
            {
                GlosarioCss.Add(new Termino { Palabra = "padding", Definicion = "Genera espacio interno entre el contenido de un elemento y su borde." });
                GlosarioCss.Add(new Termino { Palabra = "display: flex", Definicion = "Habilita el modelo de caja flexible para alinear y distribuir elementos eficientemente." });
                GlosarioCss.Add(new Termino { Palabra = "border-radius", Definicion = "Redondea las esquinas del borde exterior de un elemento." });
            }
        }

        public IActionResult OnPost(string nuevaPalabra, string nuevaDefinicion)
        {
            if (!string.IsNullOrEmpty(nuevaPalabra) && !string.IsNullOrEmpty(nuevaDefinicion))
            {
                GlosarioCss.Add(new Termino
                {
                    Palabra = nuevaPalabra,
                    Definicion = nuevaDefinicion
                });
            }
            return RedirectToPage("/Css");
        }

    }

}