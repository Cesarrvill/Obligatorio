
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;

namespace Obligatorio.Pages.Contrataciones
{
    public class ListarModel : PageModel
    {
        public List<Contratacion> Contrataciones { get; set; }

        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Contrataciones = unaControladora.ListarContrataciones();
        }
    }
}
