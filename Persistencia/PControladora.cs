using Obligatorio.Dominio.Entidades;

namespace Obligatorio.Persistencia
{
    public class PControladora
    {
        #region " Clientes "
        public List<Cliente> ListaClientes()
        {
            return new PCliente().ListaClientes();
        }
        public bool AltaCliente(Cliente mCliente)
        {
            return new PCliente().Alta(mCliente);
        }
        public bool BajaCliente(int pId)
        {
            return new PCliente().Baja(pId);
        }
        public bool ModificarCliente(Cliente mCliente)
        {
            return new PCliente().Modificar(mCliente);
        }
        public int ProximoClienteId()
        {
            return new PCliente().ProximoId();
        }
        #endregion



        #region " Eventos "
        public List<Evento> ListaEventos()
        {
            return new PEvento().ListaEventos();
        }
        public bool AltaEvento(Evento mEvento)
        {
            return new PEvento().Alta(mEvento);
        }
        public bool BajaEvento(int pId)
        {
            return new PEvento().Baja(pId);
        }
        public bool ModificarEvento(Evento mEvento)
        {
            return new PEvento().Modificar(mEvento);
        }
        public int ProximoEventoId()
        {
            return new PCliente().ProximoId();
        }
        #endregion
    }
}
