namespace Obligatorio.Dominio.Entidades
{
    public class TipoEquipamiento
    {

            private int aId;
            private string aNombre;
            private string aDescripcion;
            private string aCaracteristicas;
            private bool aIndividualizado;
            private int aCantidadDisponible;
            private decimal aPrecioAlquiler;
        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Descripcion { get { return aDescripcion; } set { aDescripcion = value; } }
        public string Caracteristicas { get { return aCaracteristicas; } set { aCaracteristicas = value; } }
        public bool Individualizado { get { return aIndividualizado; } set { aIndividualizado = value; } }
        public int CantidadDisponible { get { return aCantidadDisponible; } set { aCantidadDisponible = value; } }
        public decimal PrecioAlquiler { get { return aPrecioAlquiler; } set { aPrecioAlquiler = value; } }

        // Constructor
        public TipoEquipamiento(int pId, string pNombre, string pDescripcion, string pCaracteristicas, bool pIndividualizado, int pCantidadDisponible, decimal pPrecioAlquiler)
        {
            aId = pId;
            aNombre = pNombre;
            aDescripcion = pDescripcion;
            aCaracteristicas = pCaracteristicas;
            aIndividualizado = pIndividualizado;
            aCantidadDisponible = pCantidadDisponible;
            aPrecioAlquiler = pPrecioAlquiler;
        }

    }
}
