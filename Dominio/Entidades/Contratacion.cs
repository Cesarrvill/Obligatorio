namespace Obligatorio.Dominio.Entidades
{
    public class Contratacion
    {
        private int aId;
        private DateTime aFecha;
        private DateTime aFechaInicio;
        private DateTime aFechaFin;
        private decimal aImporteTotal;
        private decimal aSaldoPendiente;

        public int Id { get { return aId; } set { aId = value; } }
        public DateTime Fecha { get { return aFecha; } set { aFecha = value; } }
        public DateTime FechaInicio { get { return aFechaInicio; } set { aFechaInicio = value; } }
        public DateTime FechaFin { get { return aFechaFin; } set { aFechaFin = value; } }
        public decimal ImporteTotal { get { return aImporteTotal; } set { aImporteTotal = value; } }
        public decimal SaldoPendiente { get { return aSaldoPendiente; } set { aSaldoPendiente = value; } }
        
        // Constructor
        public Contratacion(int pId, DateTime pFecha, DateTime pFechaInicio, DateTime pFechaFin, decimal pImporteTotal, decimal pSaldoPendiente)
        {
            aId = pId;
            aFecha = pFecha;
            aFechaInicio = pFechaInicio;
            aFechaFin = pFechaFin;
            aImporteTotal = pImporteTotal;
            aSaldoPendiente = pSaldoPendiente;
        }

    }
}
