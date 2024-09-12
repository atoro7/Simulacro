using Taxis.Enums;

namespace Taxis.Models
{
    public class Pasajero
    {
        public string NombreCompleto { get; private set; }
        public string Direccion { get; private set; }
        public EstatusMembresia EstatusMembresia { get; private set; }

        public Pasajero(string nombreCompleto, string direccion, EstatusMembresia estatusMembresia)
        {
            NombreCompleto = nombreCompleto;
            Direccion = direccion;
            EstatusMembresia = estatusMembresia;
        }
    }
}
