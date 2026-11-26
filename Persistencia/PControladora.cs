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

        #region " Equipamientos "
        public List<Equipamiento> ListaEquipamientos()
        {
            return new PEquipamiento().ListaEquipamientos();
        }
        public bool AltaEquipamiento(Equipamiento mEquipamiento)
        {
            return new PEquipamiento().Alta(mEquipamiento);
        }
        public bool BajaEquipamiento(int pId)
        {
            return new PEquipamiento().Baja(pId);
        }
        public bool ModificarEquipamiento(Equipamiento mEquipamiento)
        {
            return new PEquipamiento().Modificar(mEquipamiento);
        }
        public int ProximoEquipamientoId()
        {
            return new PEquipamiento().ProximoId();
        }
        #endregion





        #region  Contrataciones 
        public List<Contratacion> ListaContrataciones()
        {
            return new PContratacion().ListaContrataciones();
        }
        public bool AltaContratacion(Contratacion mContratacion)
        {
            return new PContratacion().Alta(mContratacion);
        }
        public bool BajaContratacion(int pId)
        {
            return new PContratacion().Baja(pId);
        }
        public bool ModificarContratacion(Contratacion mContratacion)
        {
            return new PContratacion().Modificar(mContratacion);
        }
        public int ProximoContratacionId()
        {
            return new PContratacion().ProximoId();
        }
        #endregion





    }
}

