namespace Obligatorio.Dominio.Entidades
{
    public class DetalleDevolucion
    {
            private int aId;
        private string aEstado;
        private decimal aCargoAdicional;
        private string aObservacion;

        public int Id { get { return aId; } set { aId = value; } }
        public string Estado { get { return aEstado; } set { aEstado = value; } }
        public decimal CargoAdicional { get { return aCargoAdicional; } set { aCargoAdicional = value; } }
        public string Observacion { get { return aObservacion; } set { aObservacion = value; } }
        // Constructor
        public DetalleDevolucion(int pId, string pEstado, decimal pCargoAdicional, string pObservacion)
        {
            aId = pId;
            aEstado = pEstado;
            aCargoAdicional = pCargoAdicional;
            aObservacion = pObservacion;
        }

    }
}
