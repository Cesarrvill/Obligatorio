
using Obligatorio.Dominio.Entidades;
using System.Data;

namespace Obligatorio.Persistencia
{
    public class PContratacion
    {


        private Conexion Conexion = new Conexion();

        public List<Contratacion> ListaContrataciones()
        {
            string sql = "SELECT * FROM Contratacion";

            DataSet datos = Conexion.Consultar(sql);

            List<Contratacion> lista = new List<Contratacion>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Contratacion unaContratacion = new Contratacion(
                    int.Parse(fila[0].ToString()),
                    DateTime.Parse(fila[1].ToString()),
                    DateTime.Parse(fila[2].ToString()),
                    DateTime.Parse(fila[3].ToString()),
                    decimal.Parse(fila[4].ToString()),
                    decimal.Parse(fila[5].ToString())
                    );

                lista.Add(unaContratacion);
            }
            return lista;
        }


        public bool Alta(Contratacion unaContratacion)
        {
            string sql = "INSERT INTO contratacion (id, fecha, fecha_inicio, fecha_fin, importe_total, saldo_pendiente) "
                + "VALUES (" + unaContratacion.Id + ",'" + unaContratacion.Fecha.ToString("yyyy-MM-dd") + "','"
                + unaContratacion.FechaInicio.ToString("yyyy-MM-dd") + "','" + unaContratacion.FechaFin.ToString("yyyy-MM-dd") + "',"
                + unaContratacion.ImporteTotal.ToString(System.Globalization.CultureInfo.InvariantCulture) + ","
                + unaContratacion.SaldoPendiente.ToString(System.Globalization.CultureInfo.InvariantCulture) + ")";

            return Conexion.Ejecutar(sql);
        }

        public bool Baja(int pId)
        {
            string sql = "DELETE FROM contratacion WHERE id = " + pId.ToString();

            return Conexion.Ejecutar(sql);
        }

        public bool Modificar(Contratacion unaContratacion)
        {
            string sql = "UPDATE contratacion "
                + "SET fecha = '" + unaContratacion.Fecha.ToString("yyyy-MM-dd") + "',"
                + "fecha_inicio = '" + unaContratacion.FechaInicio.ToString("yyyy-MM-dd") + "',"
                + "fecha_fin = '" + unaContratacion.FechaFin.ToString("yyyy-MM-dd") + "',"
                + "importe_total = " + unaContratacion.ImporteTotal.ToString(System.Globalization.CultureInfo.InvariantCulture) + ","
                + "saldo_pendiente = " + unaContratacion.SaldoPendiente.ToString(System.Globalization.CultureInfo.InvariantCulture) + " "
                + "WHERE id = " + unaContratacion.Id.ToString();

            return Conexion.Ejecutar(sql);
        }

        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM contratacion";
            DataSet datos = Conexion.Consultar(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
