using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;

namespace Obligatorio.Pages.PageEventos
{

    public class EliminarModel : PageModel
    {
        public Evento evento { get; set; }
        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            evento = unaControladora.BuscarEvento(id);
        }
        public IActionResult OnPostEliminar()
        {
            int Id = int.Parse(Request.Form["id"]);

            Controladora unaControladora = new Controladora();
            unaControladora.BajaEvento(Id);
            return Redirect("./ListarEventos");
        }
    }
}
