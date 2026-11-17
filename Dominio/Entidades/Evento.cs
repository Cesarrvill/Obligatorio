namespace Obligatorio.Dominio.Entidades
{
    public class Evento
    {
        private int aId;
        private string aNombre;
        private DateTime aFecha;
        private string aTipoEvento; // Agregado el campo TipoEvento
        private string aUbicacion;
        private TimeSpan aHoraInicio;
        private TimeSpan aHoraFin;
        private int aCantAsistentes;

        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        public string TipoEvento { get { return aTipoEvento; } set { aTipoEvento = value; } } 
        public string Ubicacion { get { return aUbicacion; } set { aUbicacion = value; } }
        public TimeSpan HoraInicio { get { return aHoraInicio; } set { aHoraInicio = value; } }
        public TimeSpan HoraFin { get { return aHoraFin; } set { aHoraFin = value; } }
        public int CantAsistentes { get { return aCantAsistentes; } set { aCantAsistentes = value; } }

        // Constructor
        public Evento(int pId, string pNombre, DateTime pFecha, string pTipoEvento, string pUbicacion, TimeSpan pHoraInicio, TimeSpan pHoraFin, int pCantAsistentes)
        {
            aId = pId;
            aNombre = pNombre;
            aFecha = pFecha;
            aTipoEvento = pTipoEvento;
            aUbicacion = pUbicacion;
            aHoraInicio = pHoraInicio;
            aHoraFin = pHoraFin;
            aCantAsistentes = pCantAsistentes;
        }
    }
}
