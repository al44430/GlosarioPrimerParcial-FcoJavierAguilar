using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using GlosarioPrimerParcial_FcoJavierAguilar.Models;


namespace GlosarioPrimerParcial_FcoJavierAguilar.Pages
{
    public class CsharpModel : PageModel
    {
        public static List<Termino> GlosarioCsharp { get; set; } = new List<Termino>();
        public void OnGet()
        {
            if (GlosarioCsharp.Count == 0)
            {
                GlosarioCsharp.Add(new Termino { Palabra = "class",  Definicion = "Se utiliza para definir una clase, que es la plantilla o molde base para crear objetos." });
                GlosarioCsharp.Add(new Termino { Palabra = "if",     Definicion = "Permite evaluar una condición para decidir si un bloque de código debe ejecutarse o no." });
                GlosarioCsharp.Add(new Termino { Palabra = "return", Definicion = "Termina la ejecución de un método y devuelve un valor o resultado a quien lo llamó." });
            }
        }

        public IActionResult OnPost(string nuevaPalabra, string nuevaDefinicion)
        {
            if (!string.IsNullOrEmpty(nuevaPalabra) && !string.IsNullOrEmpty(nuevaDefinicion))
            {
                GlosarioCsharp.Add(new Termino
                {
                    Palabra = nuevaPalabra,
                    Definicion = nuevaDefinicion
                });
            }
            return RedirectToPage("/Csharp");
        }

    }

}