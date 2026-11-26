using Obligatorio.Dominio.Entidades;
using Obligatorio.Dominio.Enums;
using Obligatorio.Persistencia;

namespace Obligatorio.Dominio
{
    public class Controladora
    {
        private PControladora Persistencia;
        private static List<Cliente> aListaClientes = new List<Cliente>();
        private static List<Evento> aListaEventos = new List<Evento>();
        private static List<Equipamiento> aListaEquipamientos = new List<Equipamiento>();
        private static List<Contratacion> aListaContrataciones = new List<Contratacion>();

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



        #region Evento

        public int ProximoIdEvento()
        {
            return Persistencia.ProximoEventoId();
        }
        public List<Evento> ListarEventos()
        {
            aListaEventos = Persistencia.ListaEventos();
            return aListaEventos;
        }
        public Evento BuscarEvento(int pId)
        {
            foreach (Evento unEvento in aListaEventos)
            {
                if (unEvento.Id == pId)
                {
                    return unEvento;
                }
            }
            return null;
        }

        public bool AltaEvento(Evento pEvento)
        {
            Evento ComparoEvento = BuscarEvento(pEvento.Id);
            if (ComparoEvento == null)
            {
                if (Persistencia.AltaEvento(pEvento))
                {
                    aListaEventos.Add(pEvento);
                    return true;
                }
            }
            return false;
        }
        public bool BajaEvento(int pId)
        {
            Evento EventoAEliminar = BuscarEvento(pId);
            if (EventoAEliminar != null)
            {
                if (Persistencia.BajaEvento(pId))
                {
                    aListaEventos.Remove(EventoAEliminar);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarEvento(int pId, string pNombre, DateTime pFecha, string pTipoEvento, string pUbicacion, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pCantAsistentes)
        {
            Evento EventoAModificar = BuscarEvento(pId);
            if (EventoAModificar != null)
            {
                EventoAModificar.TipoEvento = pTipoEvento;
                EventoAModificar.Nombre = pNombre;
                EventoAModificar.Fecha = pFecha;
                EventoAModificar.Ubicacion = pUbicacion;
                EventoAModificar.HoraInicio = pHoraInicio;
                EventoAModificar.HoraFin = pHoraFin;
                EventoAModificar.CantAsistentes = pCantAsistentes;
                return true;
            }
            return false;
        }
        #endregion

        #region Equipamiento

        public int ProximoIdEquipamiento()
        {
            return Persistencia.ProximoEquipamientoId();
        }

        public List<Equipamiento> ListarEquipamientos()
        {
            aListaEquipamientos = Persistencia.ListaEquipamientos();
            return aListaEquipamientos;
        }

        public Equipamiento BuscarEquipamiento(int pId)
        {
            foreach (Equipamiento unEquipamiento in aListaEquipamientos)
            {
                if (unEquipamiento.Id == pId)
                {
                    return unEquipamiento;
                }
            }
            return null;
        }

        public bool AltaEquipamiento(Equipamiento pEquipamiento)
        {
            Equipamiento ComparoEquipamiento = BuscarEquipamiento(pEquipamiento.Id);
            if (ComparoEquipamiento == null)
            {
                if (Persistencia.AltaEquipamiento(pEquipamiento))
                {
                    aListaEquipamientos.Add(pEquipamiento);
                    return true;
                }
            }
            return false;
        }

        public bool BajaEquipamiento(int pId)
        {
            Equipamiento EquipamientoAEliminar = BuscarEquipamiento(pId);
            if (EquipamientoAEliminar != null)
            {
                if (Persistencia.BajaEquipamiento(pId))
                {
                    aListaEquipamientos.Remove(EquipamientoAEliminar);
                    return true;
                }
            }
            return false;
        }

        public bool ModificarEquipamiento(int pId, string pNombre, string pDescripcion, string pCaracteristicas, TipoEquipamiento.TipoEquipamento pTipo, int pCantidadDisponible, decimal pPrecioAlquiler)
        {
            Equipamiento EquipamientoAModificar = BuscarEquipamiento(pId);
            if (EquipamientoAModificar != null)
            {
                EquipamientoAModificar.Nombre = pNombre;
                EquipamientoAModificar.Descripcion = pDescripcion;
                EquipamientoAModificar.Caracteristicas = pCaracteristicas;
                EquipamientoAModificar.Tipo = pTipo;
                EquipamientoAModificar.CantidadDisponible = pCantidadDisponible;
                EquipamientoAModificar.PrecioAlquiler = pPrecioAlquiler;
                return Persistencia.ModificarEquipamiento(EquipamientoAModificar);
            }
            return false;
        }

        #endregion



        #region Contratacion

        public int ProximoIdContratacion()
        {
            return Persistencia.ProximoContratacionId();
        }
        public List<Contratacion> ListarContrataciones()
        {
            aListaContrataciones = Persistencia.ListaContrataciones();
            return aListaContrataciones;
        }
        public Contratacion BuscarContratacion(int pId)
        {
            foreach (Contratacion unaContratacion in aListaContrataciones)
            {
                if (unaContratacion.Id == pId)
                {
                    return unaContratacion;
                }
            }
            return null;
        }

        public bool AltaContratacion(Contratacion pContratacion)
        {
            Contratacion ComparoContratacion = BuscarContratacion(pContratacion.Id);
            if (ComparoContratacion == null)
            {
                if (Persistencia.AltaContratacion(pContratacion))
                {
                    aListaContrataciones.Add(pContratacion);
                    return true;
                }
            }
            return false;
        }
        public bool BajaContratacion(int pId)
        {
            Contratacion ContratacionAEliminar = BuscarContratacion(pId);
            if (ContratacionAEliminar != null)
            {
                if (Persistencia.BajaContratacion(pId))
                {
                    aListaContrataciones.Remove(ContratacionAEliminar);
                    return true;
                }
            }
            return false;
        }
        public bool ModificarContratacion(int pId, DateTime pFecha, DateTime pFechaInicio, DateTime pFechaFin, decimal pImporteTotal, decimal pSaldoPendiente)
        {
            Contratacion ContratacionAModificar = BuscarContratacion(pId);
            if (ContratacionAModificar != null)
            {
                ContratacionAModificar.Fecha = pFecha;
                ContratacionAModificar.FechaInicio = pFechaInicio;
                ContratacionAModificar.FechaFin = pFechaFin;
                ContratacionAModificar.ImporteTotal = pImporteTotal;
                ContratacionAModificar.SaldoPendiente = pSaldoPendiente;

                if (Persistencia.ModificarContratacion(ContratacionAModificar))
                {
                    return true;
                }
            }
            return false;
        }
        #endregion


    }
}

