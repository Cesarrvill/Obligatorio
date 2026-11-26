using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Obligatorio.Dominio;
using Obligatorio.Dominio.Entidades;
using Obligatorio.Dominio.Enums;
using static Obligatorio.Dominio.Enums.TipoEquipamiento;

namespace Obligatorio.Pages.Equipamiento
{
        public class AltaModel : PageModel
        {
            public string Mensaje { get; set; }
            public int id { get; set; } = 0;
            public void OnGet()
            {
                Controladora unaControladora = new Controladora();
                id = unaControladora.ProximoIdEquipamiento();
            }

           //cambiame cliente por equipamiento con los siguientes atributos: Id, Nombre, Descripcion,Caracteristicas, Tipo, CantidadDisponible,Total



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
                        throw new Exception("Debe ingresar el Tipo del Equipamiento");
                    }
                    if (Request.Form["cantidad"] == "")
                    {
                        throw new Exception("Debe ingresar la Cantidad Disponible del Equipamiento");
                    }
                    if (Request.Form["precio"] == "")
                    {
                        throw new Exception("Debe ingresar el Precio de Alquiler del Equipamiento");
                    }


                    int Id = int.Parse(Request.Form["id"]);
                    TipoEquipamiento Tipo = (TipoEquipamiento)Enum.Parse(typeof(TipoEquipamiento), Request.Form["tipo"]);
                    string Nombre = Request.Form["nombre"];
                    string Descripcion = Request.Form["descripcion"];
                    string Caracteristicas = Request.Form["caracteristicas"];
                    int CantidadDisponible = int.Parse(Request.Form["cantidad"]);
                    decimal PrecioAlquiler = decimal.Parse(Request.Form["precio"]);
                    string Activo = Request.Form["activo"];



                    Equipamiento unEquipamiento = new Equipamiento(Id, Tipo, Nombre, Descripcion, Caracteristicas, CantidadDisponible, PrecioAlquiler, bool.Parse(Activo));

                    Controladora unaControladora = new Controladora();

                    unaControladora.AltaEquipamiento(unEquipamiento);
                    return Redirect("/PageEquipamientos/Listar");

                }
                catch (Exception Error)
                {
                    Mensaje = Error.Message;
                    return Page();
                }
            }
        }
 }


