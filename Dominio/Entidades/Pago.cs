namespace Obligatorio.Dominio.Entidades
{
    public class Pago
    {

            private int aId;
            private DateTime aFecha;
            private decimal aImporte;
        public int Id { get { return aId; } set { aId = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        public decimal Importe { get { return aImporte; } set { aImporte = value; } }
        // Constructor
        public Pago(int pId, DateTime pFecha, decimal pImporte)
        {
            aId = pId;
            aFecha = pFecha;
            aImporte = pImporte;
        }

    }
}
