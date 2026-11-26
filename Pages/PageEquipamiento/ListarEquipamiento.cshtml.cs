using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;

namespace Obligatorio.Pages.Equipamiento
{
    public class ListarEquipamientoModel : PageModel
    {
        public List<Dominio.Entidades.Equipamiento> Equipamientos { get; set; }

        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Equipamientos = unaControladora.ListarEquipamientos();
        }
    }
}