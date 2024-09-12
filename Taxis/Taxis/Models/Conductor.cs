namespace Taxis.Models
{
    public class Conductor
    {
        public string NombreCompleto { get; private set; }
        public int NumLicencia { get; private set; }
        public bool EstadoDisponibilidad { get; private set; }

        public Conductor(string nombreCompleto, int numLicencia, bool estadoDisponibilidad)
        {
            NombreCompleto = nombreCompleto;
            NumLicencia = numLicencia;
            EstadoDisponibilidad = true;
        }

        public void CambiarDisponibilidad()
        {
            EstadoDisponibilidad = false;
        }
    }
}
