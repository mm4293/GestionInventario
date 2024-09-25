namespace GestionInventario.Data
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string TipoDocIdent { get; set; } // Tipo de documento de identificación
        public string NumDocIdent { get; set; } // Número de documento de identificación
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public Direccion Direccion { get; set; }
        public string Telefono { get; set; }
        public bool Estado { get; set; }
        
    }
}


