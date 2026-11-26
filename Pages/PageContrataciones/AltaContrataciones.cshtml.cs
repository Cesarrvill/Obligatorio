
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;

namespace Obligatorio.Pages.Contrataciones
{
    public class AltaModel : PageModel
    {
        public string Mensaje { get; set; }
        public int id { get; set; } = 0;

        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            id = unaControladora.ProximoIdContratacion();
        }

        public IActionResult OnPostAgregar()
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

                Contratacion unaContratacion = new Contratacion(Id, Fecha, FechaInicio, FechaFin, ImporteTotal, SaldoPendiente);

                Controladora unaControladora = new Controladora();

                unaControladora.ListarContrataciones();
                unaControladora.AltaContratacion(unaContratacion);

                return Redirect("/PageContrataciones/ListarContrataciones");
            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                return Page();
            }
        }
    }
}
