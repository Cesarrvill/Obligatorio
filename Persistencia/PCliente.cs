using Obligatorio.Dominio.Entidades;
using Obligatorio.Dominio.Enums;
using System.Data;

namespace Obligatorio.Persistencia
{
    public class PCliente
    {


        private Conexion Conexion = new Conexion();

        public List<Cliente> ListaClientes()
        {
            string sql = "SELECT * FROM Cliente";

            DataSet datos = Conexion.Consultar(sql);

            List<Cliente> lista = new List<Cliente>();

            foreach (DataRow fila in datos.Tables[0].Rows)
            {
                Cliente unCliente = new Cliente(
                    int.Parse(fila[0].ToString()),
                    (TipoCliente)Enum.Parse(typeof(TipoCliente), fila[1].ToString()),
                    fila[2].ToString(),
                    fila[3].ToString(),
                    fila[4].ToString(),
                    fila[5].ToString(),
                    fila[6].ToString(),
                    Convert.ToBoolean(fila[7])
                    );
                lista.Add(unCliente);
            }
            return lista;
        }

    
        public bool Alta(Cliente unCliente)
        {
            string sql = "INSERT INTO cliente (id, tipo, nombre, documento, telefono, email, direccion, activo) "
                + "VALUES (" + unCliente.Id + ",'" + unCliente.Tipo + "','" + unCliente.Nombre + "','" + unCliente.Documento + "','"
                + unCliente.Telefono + "','" + unCliente.Email + "','" + unCliente.Direccion + "','" + unCliente.Activo.ToString().ToLower() + "')";

            return Conexion.Ejecutar(sql);
        }
        public bool Baja(int pId)
        {
            string sql = "DELETE FROM cliente WHERE id = " + pId.ToString();

            return Conexion.Ejecutar(sql);
        }
        public bool Modificar(Cliente unCliente)
        {
            string sql = "UPDATE cliente "
                + "SET tipo = '" + unCliente.Tipo + "',"
                + "nombre = '" + unCliente.Nombre + "',"
                + "documento = '" + unCliente.Documento + "',"
                + "telefono = '" + unCliente.Telefono + "',"
                + "email = '" + unCliente.Email + "',"
                + "direccion = '" + unCliente.Direccion + "',"
                + "activo = " + unCliente.Activo.ToString().ToLower() + " "
                + "WHERE id = " + unCliente.Id.ToString();

            return Conexion.Ejecutar(sql);
        }
        public int ProximoId()
        {
            string sql = "SELECT (ISNULL(MAX(id),0)+1) FROM cliente";
            DataSet datos = Conexion.Consultar(sql);
            DataRowCollection filas = datos.Tables[0].Rows;
            var campo = filas[0];
            int Id = int.Parse(campo[0].ToString());
            return Id;
        }
    }
}
