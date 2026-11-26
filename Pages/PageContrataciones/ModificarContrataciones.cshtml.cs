
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;

namespace Obligatorio.Pages.Contrataciones
{
    public class ModificarModel : PageModel
    {
        public Contratacion contratacion { get; set; }
        public string Mensaje { get; set; } = "";

        public void OnGet(int id)
        {
            Controladora unaControladora = new Controladora();
            unaControladora.ListarContrataciones();
            contratacion = unaControladora.BuscarContratacion(id);
        }

        public IActionResult OnPostModificar()
        {
            try
            {
                if (Request.Form["id"] == "")
                {
                    throw new Exception("Debe ingresar el ID de la Contratación");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID de la Contratación debe ser un numero");
                }
                if (Request.Form["fecha"] == "")
                {
                    throw new Exception("Debe ingresar la Fecha de la Contratación");
                }
                if (Request.Form["fechaInicio"] == "")
                {
                    throw new Exception("Debe ingresar la Fecha de Inicio");
                }
                if (Request.Form["fechaFin"] == "")
                {
                    throw new Exception("Debe ingresar la Fecha de Fin");
                }
                if (Request.Form["importeTotal"] == "")
                {
                    throw new Exception("Debe ingresar el Importe Total");
                }
                if (Request.Form["saldoPendiente"] == "")
                {
                    throw new Exception("Debe ingresar el Saldo Pendiente");
                }

                int Id = int.Parse(Request.Form["id"]);
                DateTime Fecha = DateTime.Parse(Request.Form["fecha"]);
                DateTime FechaInicio = DateTime.Parse(Request.Form["fechaInicio"]);
                DateTime FechaFin = DateTime.Parse(Request.Form["fechaFin"]);
                decimal ImporteTotal = decimal.Parse(Request.Form["importeTotal"]);
                decimal SaldoPendiente = decimal.Parse(Request.Form["saldoPendiente"]);

                Controladora unaControladora = new Controladora();

                unaControladora.ListarContrataciones();
                unaControladora.ModificarContratacion(Id, Fecha, FechaInicio, FechaFin, ImporteTotal, SaldoPendiente);

                return Redirect("/PageContrataciones/ListarContrataciones");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;

                int Id = int.Parse(Request.Form["id"]);
                Controladora unaControladora = new Controladora();
                unaControladora.ListarContrataciones();
                contratacion = unaControladora.BuscarContratacion(Id);

                return Page();
            }
        }
    }
}
