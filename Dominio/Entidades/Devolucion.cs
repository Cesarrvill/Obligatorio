namespace Obligatorio.Dominio.Entidades
{
    public class Devolucion
    {

            private int aId;
            private DateTime aFecha;
        public int Id { get { return aId; } set { aId = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        // Constructor
        public Devolucion(int pId, DateTime pFecha)
        {
            aId = pId;
            aFecha = pFecha;
        }

    }
}
