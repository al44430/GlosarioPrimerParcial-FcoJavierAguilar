using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using GlosarioPrimerParcial_FcoJavierAguilar.Models;


namespace GlosarioPrimerParcial_FcoJavierAguilar.Pages
{
    public class HtmlModel : PageModel
    {
        public static List<Termino> GlosarioHtml { get; set;  } = new List<Termino>();
        public void OnGet()
        {
            if (GlosarioHtml.Count == 0)
            {
                GlosarioHtml.Add(new Termino { Palabra = "<html>", Definicion = "Etiqueta raiz que envuelve todo el contenido de una p" });
                GlosarioHtml.Add(new Termino { Palabra = "<form>", Definicion = "Define un formulario interactivo para la recopilación" });
                GlosarioHtml.Add(new Termino { Palabra = "<div>",  Definicion = "Contenedor genérico utilizado para agrupar elementos y" });
            }
        }

        public IActionResult OnPost(string nuevaPalabra, string nuevaDefinicion)
        {
            if (!string.IsNullOrEmpty(nuevaPalabra) && !string.IsNullOrEmpty(nuevaDefinicion))
            {
                GlosarioHtml.Add(new Termino
                {
                    Palabra = nuevaPalabra,
                    Definicion = nuevaDefinicion
                });
            }
            return RedirectToPage("/Html");
        }

    }

}