using Obligatorio.Dominio.Entidades;
using Obligatorio.Dominio.Enums;
using Obligatorio.Persistencia;

namespace Obligatorio.Dominio
{
    public class Controladora
    {
        private PControladora Persistencia;
        private static List<Cliente> aListaClientes = new List<Cliente>();

        public Controladora() {
            Persistencia = new PControladora();
        }
    
        #region Clientes

        public int ProximoIdCliente()
        {
            return Persistencia.ProximoClienteId();
        }
        public List<Cliente> ListarClientes()
        {
            aListaClientes = Persistencia.ListaClientes();
            return aListaClientes;
        }
        public Cliente BuscarCliente(int pId)
        {
            foreach (Cliente unCliente in aListaClientes)
            {
                if (unCliente.Id == pId)
                {
                    return unCliente;
                }
            }
            return null;
        }

        public bool AltaCliente(Cliente pCliente)
        {
            Cliente ComparoCliente = BuscarCliente(pCliente.Id);
            if (ComparoCliente == null)
            {
                if (Persistencia.AltaCliente(pCliente))
                {
                    aListaClientes.Add(pCliente);
                    return true;
                }
            }
            return false;
        }
        public bool BajaCliente(int pId)
        {
            Cliente ClienteAEliminar = BuscarCliente(pId);
            if (ClienteAEliminar != null)
            {
                if (Persistencia.BajaCliente(pId))
                {
                    aListaClientes.Remove(ClienteAEliminar);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarCliente(int pId, TipoCliente pTipo, string pNombre, string pDocumento, string pTelefono, string pEmail, string pDireccion, bool pActivo)
        {
            Cliente ClienteAModificar = BuscarCliente(pId);
            if (ClienteAModificar != null)
            {
                ClienteAModificar.Tipo = pTipo;
                ClienteAModificar.Nombre = pNombre;
                ClienteAModificar.Documento = pDocumento;
                ClienteAModificar.Telefono = pTelefono;
                ClienteAModificar.Email = pEmail;
                ClienteAModificar.Direccion = pDireccion;
                ClienteAModificar.Activo = pActivo;
                return true;
            }
            return false;
        }
        #endregion

        


    }
}
