namespace Obligatorio.Dominio.Entidades
{
    public class SolicitudAlquiler
    {
        private int aId;
        private DateTime aFecha;
        private string aEstado;

        public int Id { get { return aId; } set { aId = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }

        // Constructor
        public SolicitudAlquiler(int pId, DateTime pFecha, string pEstado)
        {
            aId = pId;
            aFecha = pFecha;
            aEstado = pEstado;
        }
    }
}

  