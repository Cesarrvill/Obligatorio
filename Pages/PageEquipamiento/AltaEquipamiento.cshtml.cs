using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Enums;

namespace Obligatorio.Pages.Equipamiento
{
    public class AltaEquipamientoModel : PageModel
    {
        public string Mensaje { get; set; }
        public int id { get; set; } = 0;

        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            id = unaControladora.ProximoIdEquipamiento();
        }

        public IActionResult OnPostAgregar()
        {
            try
            {
                if (Request.Form["id"] == "")
                {
                    throw new Exception("Debe ingresar el ID del Equipamiento");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID del Equipamiento debe ser un numero");
                }
                if (Request.Form["nombre"] == "")
                {
                    throw new Exception("Debe ingresar el Nombre del Equipamiento");
                }
                if (Request.Form["descripcion"] == "")
                {
                    throw new Exception("Debe ingresar la Descripción del Equipamiento");
                }
                if (Request.Form["caracteristicas"] == "")
                {
                    throw new Exception("Debe ingresar las Características del Equipamiento");
                }
                if (Request.Form["tipo"] == "")
                {
                    throw new Exception("Debe ingresar el Tipo de Equipamiento");
                }
                if (Request.Form["cantidadDisponible"] == "")
                {
                    throw new Exception("Debe ingresar la Cantidad Disponible del Equipamiento");
                }
                if (Request.Form["precioAlquiler"] == "")
                {
                    throw new Exception("Debe ingresar el Precio de Alquiler del Equipamiento");
                }

                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                string Descripcion = Request.Form["descripcion"];
                string Caracteristicas = Request.Form["caracteristicas"];
                TipoEquipamiento.TipoEquipamento Tipo = (TipoEquipamiento.TipoEquipamento)Enum.Parse(typeof(TipoEquipamiento.TipoEquipamento), Request.Form["tipo"]);
                int CantidadDisponible = int.Parse(Request.Form["cantidadDisponible"]);
                decimal PrecioAlquiler = decimal.Parse(Request.Form["precioAlquiler"]);

                Dominio.Entidades.Equipamiento unEquipamiento = new Dominio.Entidades.Equipamiento(
                    Id, Nombre, Descripcion, Caracteristicas, Tipo, CantidadDisponible, PrecioAlquiler
                );

                Controladora unaControladora = new Controladora();
                unaControladora.AltaEquipamiento(unEquipamiento);
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