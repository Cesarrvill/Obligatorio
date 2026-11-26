using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;

namespace Obligatorio.Pages.Equipamiento
{
    public class EliminarEquipamientoModel : PageModel
    {
        public Dominio.Entidades.Equipamiento? equipamiento { get; set; }
        public string Mensaje { get; set; } = string.Empty;

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            unaControladora.ListarEquipamientos();
            equipamiento = unaControladora.BuscarEquipamiento(id);
        }

        public IActionResult OnPostEliminar()
        {
            try
            {
                int Id = int.Parse(Request.Form["id"]!);

                Controladora unaControladora = new Controladora();
                unaControladora.ListarEquipamientos();
                bool eliminado = unaControladora.BajaEquipamiento(Id);

                if (!eliminado)
                {
                    throw new Exception("No se pudo eliminar el Equipamiento.");
                }

                return Redirect("/PageEquipamiento/ListarEquipamiento");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                return Page();
            }
        }
    }
}