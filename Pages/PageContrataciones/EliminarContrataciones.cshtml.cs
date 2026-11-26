
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;

namespace Obligatorio.Pages.Contrataciones
{
    public class EliminarModel : PageModel
    {
        public Contratacion contratacion { get; set; }

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            unaControladora.ListarContrataciones();
            contratacion = unaControladora.BuscarContratacion(id);
        }

        public IActionResult OnPostEliminar()
        {
            int Id = int.Parse(Request.Form["id"]);

            Controladora unaControladora = new Controladora();
            unaControladora.ListarContrataciones();
            unaControladora.BajaContratacion(Id);

            return Redirect("./ListarContrataciones");
        }
    }
}
