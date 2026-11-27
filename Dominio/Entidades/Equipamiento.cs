using Obligatorio.Dominio.Enums;

namespace Obligatorio.Dominio.Entidades
{
    public class Equipamiento
    {
            private int aId;
            private string aNombre;
            private string aDescripcion;
            private string aCaracteristicas;
            private TipoEquipamiento.TipoEquipamento aTipo;
            private int aCantidadDisponible;
            private decimal aPrecioAlquiler;
        public int Id { get { return aId; } set { aId = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Descripcion { get { return aDescripcion; } set { aDescripcion = value; } }
        public string Caracteristicas { get { return aCaracteristicas; } set { aCaracteristicas = value; } }
        public TipoEquipamiento.TipoEquipamento Tipo { get { return aTipo; } set { aTipo = value; } }
        public int CantidadDisponible { get { return aCantidadDisponible; } set { aCantidadDisponible = value; } }
        public decimal PrecioAlquiler { get { return aPrecioAlquiler; } set { aPrecioAlquiler = value; } }


        // Constructor
        public Equipamiento(int pId, string pNombre, string pDescripcion, string pCaracteristicas, TipoEquipamiento.TipoEquipamento pTipo, int pCantidadDisponible, decimal pPrecioAlquiler)
        {
            aId = pId;
            aNombre = pNombre;
            aDescripcion = pDescripcion;
            aCaracteristicas = pCaracteristicas;
            aTipo = pTipo;
            aCantidadDisponible = pCantidadDisponible;
            aPrecioAlquiler = pPrecioAlquiler;
        }

    }
}
