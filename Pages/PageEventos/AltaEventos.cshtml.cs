using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;
using Obligatorio.Dominio.Enums;
using System.Security.Cryptography;

namespace Obligatorio.Pages.Eventos
{
    public class AltaModel : PageModel
    {
        public string Mensaje { get; set; }
        public int id { get; set; } = 0;
        public void OnGet()
        {
            Controladora unaControladora = new Controladora();
            id = unaControladora.ProximoIdEvento();
        }

        public IActionResult OnPostAgregar()
        {
            try
            {
                if (Request.Form["id"] == "")
                {
                    throw new Exception("Debe ingresar el ID del Evento");
                }
                if (!int.TryParse(Request.Form["id"], out _))
                {
                    throw new Exception("El ID del Evento debe ser un numero");
                }
                if (Request.Form["nombre"] == "")
                {
                    throw new Exception("Debe ingresar el Nombre del Evento");
                }
                if (Request.Form["fecha"] == "")
                {
                    throw new Exception("Debe ingresar la Fecha del Evento");
                }
                if (Request.Form["TipoEvento"] == "")
                {
                    throw new Exception("Debe ingresar el Tipo de Evento");
                }
                if (Request.Form["Ubicacion"] == "")
                {
                    throw new Exception("Debe ingresar la Ubicación del Evento");
                }
                if (Request.Form["HoraInicio"] == "")
                {
                    throw new Exception("Debe ingresar la Hora de Inicio del Evento");
                }
                if (Request.Form["HoraFin"] == "")
                {
                    throw new Exception("Debe ingresar la Hora de Fin del Evento");
                }
                if (Request.Form["CantAsistentes"] == "")
                {
                    throw new Exception("Debe ingresar la Cantidad de Asistentes del Evento");
                }

                int Id = int.Parse(Request.Form["id"]);
                string Nombre = Request.Form["nombre"];
                DateTime Fecha = DateTime.Parse(Request.Form["fecha"]);
                string TipoEvento = Request.Form["TipoEvento"];
                string Ubicacion = Request.Form["Ubicacion"];
                TimeSpan HoraInicio = TimeSpan.Parse(Request.Form["HoraInicio"]);
                TimeSpan HoraFin = TimeSpan.Parse(Request.Form["HoraFin"]);
                int CantAsistentes = int.Parse(Request.Form["CantAsistentes"]);




                Evento unEvento = new Evento(Id, Nombre, Fecha, TipoEvento, Ubicacion, HoraInicio, HoraFin, CantAsistentes);

                Controladora unaControladora = new Controladora();

                unaControladora.AltaEvento(unEvento);
                return Redirect("/PageEventos/ListarEventos");

            }
            catch (Exception Error)
            {
                Mensaje = Error.Message;
                return Page();
            }
        }
    }
}
