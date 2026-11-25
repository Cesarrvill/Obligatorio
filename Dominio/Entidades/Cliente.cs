using Obligatorio.Dominio.Enums;
using System.Security.Cryptography;

namespace Obligatorio.Dominio.Entidades
{
    public class Cliente
    {
        private int aId;
        private TipoCliente aTipo;
        private string aNombre;
        private string aEmail;
        private string aDocumento;
        private string aTelefono;
        private string aDireccion;
        private bool aActivo;


        public int Id { get { return aId; } set { aId = value; } }
        public TipoCliente Tipo { get { return aTipo; } set { aTipo = value; } }
        public string Nombre { get { return aNombre; } set { aNombre = value; } }
        public string Documento { get { return aDocumento; } set { aDocumento = value; } }
        public string Telefono { get { return aTelefono; } set { aTelefono = value; } }
        public string Email { get { return aEmail; } set { aEmail = value; } }
        public string Direccion { get { return aDireccion; } set { aDireccion = value; } }
        public bool Activo { get { return aActivo; } set { aActivo = value; } }

        // Constructor
        public Cliente(int pId, TipoCliente pTipo, string pNombre, string pDocumento, string pTelefono, string pEmail, string pDireccion, bool pActivo)
        {
            aId = pId;
            aTipo = pTipo;
            aNombre = pNombre;
            aDocumento = pDocumento;
            aTelefono = pTelefono;
            aEmail = pEmail;
            aDireccion = pDireccion;
            aActivo = pActivo;
        }

        public Cliente() {
        aId = 0;
        aTipo = TipoCliente.SeleccionarUnTipo;
        aNombre = "";
        aDocumento = "";
        aTelefono = "";
        aEmail = "";
        aDireccion = "";
        aActivo = false;
        }

    }
}
