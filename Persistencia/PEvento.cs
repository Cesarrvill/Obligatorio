using Obligatorio.Dominio.Entidades;
using Obligatorio.Dominio.Enums;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Obligatorio.Persistencia
{
    public class PEvento
    {


        private Conexion Conexion = new Conexion();

        public List<Evento> ListaEventos()
        {
            string sql = "SELECT * FROM Evento";

            DataSet datos = Conexion.Consultar(sql);

            List<Evento> lista = new List<Evento>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Evento unEvento = new Evento(
                    int.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    DateTime.Parse(fila[2].ToString()),
                    fila[3].ToString(),
                    fila[4].ToString(),
                    TimeSpan.Parse(fila[5].ToString()),
                    TimeSpan.Parse(fila[6].ToString()),
                    int.Parse(fila[7].ToString())
                );
                lista.Add(unEvento);
            }
            return lista;
        }
               


        public bool Alta(Evento unEvento)
        {
            string sql = "INSERT INTO evento (nombre, fecha, tipoevento, ubicacion, horainicio, horafin, cantasistentes) "
                + "VALUES ('" + unEvento.Nombre + "','" + unEvento.Fecha.ToString("yyyy-MM-dd") + "','" + unEvento.TipoEvento + "','"
                + unEvento.Ubicacion + "','" + unEvento.HoraInicio + "','" + unEvento.HoraFin + "'," + unEvento.CantAsistentes + ") ";

            return Conexion.Ejecutar(sql);
        }
        public bool Baja(int pId)
        {
            string sql = "DELETE FROM evento WHERE id = " + pId.ToString();

            return Conexion.Ejecutar(sql);
        }
        public bool Modificar(Evento unEvento)
        {
            string sql = "UPDATE evento "
                + "SET nombre = '" + unEvento.Nombre + "',"
                + "fecha = '" + unEvento.Fecha + "',"
                + "tipo_evento = '" + unEvento.TipoEvento + "',"
                + "ubicacion = '" + unEvento.Ubicacion + "',"
                + "hora_inicio = '" + unEvento.HoraInicio + "',"
                + "hora_fin = '" + unEvento.HoraFin + "',"
                + "cant_asistentes = " + unEvento.CantAsistentes.ToString() + " "
                + "WHERE id = " + unEvento.Id.ToString();

            return Conexion.Ejecutar(sql);
        }
        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM evento";
            DataSet datos = Conexion.Consultar(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
