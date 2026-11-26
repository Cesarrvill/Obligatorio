using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;

namespace Obligatorio.Pages.Clientes
{
    public class ListarModel : PageModel
    {
        public List<Cliente> Clientes { get; set; }
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            Clientes = unaControladora.ListarClientes();
        }
    }
}
