using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;
using Obligatorio.Dominio.Enums;

namespace Obligatorio.Pages.Clientes
{

    public class AltaModel : PageModel
    {
        public string Mensaje { get; set; }
        public int id { get; set; } = 0;
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            id = unaControladora.ProximoIdCliente();
        }

        public IActionResult OnPostAgregar()
        {
            try
            {
                if (Request.Form["id"] == "")
                {
                    throw new Exception("Debe ingresar el ID del Cliente");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID del Cliente debe ser un numero");
                }
                if (Request.Form["nombre"] == "")
                {
                    throw new Exception("Debe ingresar el Nombre del Cliente");
                }
                if (Request.Form["apellido"] == "")
                {
                    throw new Exception("Debe ingresar el Apellido del Cliente");
                }
                if (Request.Form["direccion"] == "")
                {
                    throw new Exception("Debe ingresar la Dirección del Cliente");
                }
                if (Request.Form["telefono"] == "")
                {
                    throw new Exception("Debe ingresar el Teléfono del Cliente");
                }


                int Id = int.Parse(Request.Form["id"]);
                TipoCliente Tipo = (TipoCliente)Enum.Parse(typeof(TipoCliente), Request.Form["tipo"]);
                string Nombre = Request.Form["nombre"];
                string Documento = Request.Form["documento"];
                string Telefono = Request.Form["telefono"];
                string Email = Request.Form["email"];
                string Direccion = Request.Form["direccion"];
                string Activo = Request.Form["activo"];



                Cliente unCliente = new Cliente(Id, Tipo, Nombre, Documento, Telefono, Email, Direccion, bool.Parse(Activo));

                Controladora unaControladora = new Controladora();

                unaControladora.AltaCliente(unCliente);
                return Redirect("/PageCliente/Listar");

            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                return Page();
            }
        }
    }
}
