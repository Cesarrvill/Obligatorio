using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;

namespace Obligatorio.Pages.Eventos
{
    public class ListarModel : PageModel
    {
        public List<Evento> Eventos { get; set; }
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Eventos = unaControladora.ListarEventos();
        }
    }
}
