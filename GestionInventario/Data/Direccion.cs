using System.Runtime.ConstrainedExecution;

namespace GestionInventario.Data
{
    public class Direccion
    {
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Ciudad { get; set; }
        public string CodigoPostal { get; set; }
        public string Pais { get; set; }

    }
}