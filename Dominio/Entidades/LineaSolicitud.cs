namespace Obligatorio.Dominio.Entidades
{
    public class LineaSolicitud
    {
        private int aId;
        private int aCantidad;

        public int Id { get { return aId; } set { aId = value; } }
        public int Cantidad { get { return aCantidad; } set { aCantidad = value; } }

        // Constructor
        public LineaSolicitud(int pId, int pCantidad)
        {
            aId = pId;
            aCantidad = pCantidad;
        }
    }
}
