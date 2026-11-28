namespace Obligatorio.Dominio.Entidades
{
    public class Contratacion
    {
        private int aId;
        private DateTime aFecha;
        private DateTime aFechaInicio;
        private DateTime aFechaFin;
        private List<LineaContratacion> aLineasContratacion;
        private Cliente aCliente;
        private Evento aEvento;
      

        public int Id { get { return aId; } set { aId = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        public DateTime FechaInicio { get { return aFechaInicio; } set { aFechaInicio = value; } }
        public DateTime FechaFin { get { return aFechaFin; } set { aFechaFin = value; } }
        public List<LineaContratacion> LineasContratacion { get { return aLineasContratacion; } set { aLineasContratacion = value; } }
        public Cliente Cliente { get { return aCliente; } set { aCliente = value; } }
        public Evento Evento { get { return aEvento; } set { aEvento = value; } }


        // Constructor
        public Contratacion(int pId, DateTime pFecha, DateTime pFechaInicio, DateTime pFechaFin, Cliente pCliente, Evento pEvento, List<LineaContratacion> pLineasContratacion)
        {
            aId = pId;
            aFecha = pFecha;
            aFechaInicio = pFechaInicio;
            aFechaFin = pFechaFin;
            aLineasContratacion = pLineasContratacion;
            aCliente = pCliente;
            aEvento = pEvento;
           
        }

    }
}
