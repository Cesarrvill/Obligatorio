namespace Obligatorio.Dominio.Entidades
{
    public class LineaContratacion
    {
  
            private int aId;
            private int aCantidad;
            private decimal aImporte;

        public int Id { get { return aId; } set { aId = value; } }
        public int Cantidad { get { return aCantidad; } set { aCantidad = value; } }
        public decimal Importe { get { return aImporte; } set { aImporte = value; } }

        // Constructor
        public LineaContratacion(int pId, int pCantidad, decimal pImporte)
        {
            aId = pId;
            aCantidad = pCantidad;
            aImporte = pImporte;
        }
    }
}
