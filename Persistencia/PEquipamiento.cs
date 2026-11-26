using System.Data;
using Obligatorio.Dominio.Entidades;
using Obligatorio.Dominio.Enums;

namespace Obligatorio.Persistencia
{
    public class PEquipamiento
    {
        private Conexion Conexion = new Conexion();

        public List<Equipamiento> ListaEquipamientos()
        {
            string sql = "SELECT * FROM Equipamiento";

            DataSet datos = Conexion.Consultar(sql);

            List<Equipamiento> lista = new List<Equipamiento>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Equipamiento unEquipamiento = new Equipamiento(
                    int.Parse(fila[0].ToString()),
                    fila[1].ToString(),
                    fila[2].ToString(),
                    fila[3].ToString(),
                    (TipoEquipamiento.TipoEquipamento)Enum.Parse(typeof(TipoEquipamiento.TipoEquipamento), fila[4].ToString()),
                    int.Parse(fila[5].ToString()),
                    decimal.Parse(fila[6].ToString())
                );
                lista.Add(unEquipamiento);
            }
            return lista;
        }

        public bool Alta(Equipamiento unEquipamiento)
        {
            string sql = "INSERT INTO Equipamiento (id, nombre, descripcion, caracteristicas, tipo, cantidad_disponible, precio_alquiler) "
                + "VALUES (" + unEquipamiento.Id + ",'" + unEquipamiento.Nombre + "','" + unEquipamiento.Descripcion + "','"
                + unEquipamiento.Caracteristicas + "','" + unEquipamiento.Tipo + "'," + unEquipamiento.CantidadDisponible + ","
                + unEquipamiento.PrecioAlquiler + ")";

            return Conexion.Ejecutar(sql);
        }

        public bool Baja(int pId)
        {
            string sql = "DELETE FROM equipamiento WHERE id = " + pId.ToString();

            return Conexion.Ejecutar(sql);
        }

        public bool Modificar(Equipamiento unEquipamiento)
        {
            string sql = "UPDATE equipamiento "
                + "SET nombre = '" + unEquipamiento.Nombre + "',"
                + "descripcion = '" + unEquipamiento.Descripcion + "',"
                + "caracteristicas = '" + unEquipamiento.Caracteristicas + "',"
                + "tipo = '" + unEquipamiento.Tipo + "',"
                + "cantidad_disponible = " + unEquipamiento.CantidadDisponible + ","
                + "precio_alquiler = " + unEquipamiento.PrecioAlquiler + ","
                + "WHERE id = " + unEquipamiento.Id.ToString();

            return Conexion.Ejecutar(sql);
        }

        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM equipamiento";
            DataSet datos = Conexion.Consultar(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}