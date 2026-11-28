namespace Obligatorio.Dominio.Entidades
{
    public class LineaContratacion
    {
  
            private int aId;
            private int aCantidad;
            private Equipamiento aEquipamiento;
            private decimal aImporteTotal;
            private decimal aSaldoPendiente;


        public int Id { get { return aId; } set { aId = value; } }
        public int Cantidad { get { return aCantidad; } set { aCantidad = value; } }
        public Equipamiento Equipamiento { get { return aEquipamiento; } set { aEquipamiento = value; } }
        public decimal ImporteTotal { get { return aImporteTotal; } set { aImporteTotal = value; } }
        public decimal SaldoPendiente { get { return aSaldoPendiente; } set { aSaldoPendiente = value; } }



        // Constructor
        public LineaContratacion(int pId, int pCantidad, Equipamiento pEquipamiento, decimal pImporteTotal, decimal pSaldoPendiente)
        {
            aId = pId;
            aCantidad = pCantidad;
            aEquipamiento = pEquipamiento;
            aImporteTotal = pImporteTotal;
            aSaldoPendiente = pSaldoPendiente;
        }
    }
}
