using System;
using System.Collections.Generic;

namespace GestionInventario.Data
{
    public static class DataGenerator
    {
        private static readonly Random Random = new Random();

        public static string GenerateRandomName() // Generador de nombres
        {
            var name = new[] { "Juan", "María", "Pedro", "Ana", "Luis", "Laura", "Carlos", "Isabel", "Javier", "Cristina" };
            return name[Random.Next(name.Length)];
        }

        public static string GenerateRandomLastName() // Generador de apellidos
        {
            var LastName = new[] { "Pérez", "Gómez", "López", "Martínez", "Fernández", "García", "Rodríguez", "González", "Hernández", "Morales" };
            return LastName[Random.Next(LastName.Length)];
        }

        public static string GenerateRandomTipoDocIdent() // Generador de tipos de documento de identidad
        {
            var TipoDocIdent = new[] { "CC", "TI", "Pasaporte", "Licencia de conducir", "Carnet de identidad", "DNI", "Tarjeta de residencia", "Certificado de nacimiento" };
            return TipoDocIdent[Random.Next(TipoDocIdent.Length)];
        }

        public static string GenerateRandomNumDocIdent() // Generador de números de documento de identidad
        {
            return $"{Random.Next(1000000, 9999999)}";
        }

        public static string GenerateRandomEmail(string name) // Generador de correos electrónicos
        {
            var domains = new[] { "example.com", "test.com", "demo.com" };
            return $"{name.ToLower().Replace(" ", ".")}@{domains[Random.Next(domains.Length)]}";
        }

        public static Direccion GenerateRandomAddress() // Generador de direcciones
        {
            return new Direccion
            {
                Calle = $"Calle {Random.Next(1, 100)}",
                Numero = $"{Random.Next(1, 50)}",
                Ciudad = "Ciudad Desconocida",
                CodigoPostal = $"{Random.Next(1000, 9999)}",
                Pais = "España"
            };
        }

        public static string GenerateRandomPhone() // Generador de números de teléfono
        {
            return $"+34 600 000 {Random.Next(100, 999)}";
        }

        public static bool GenerateRandomEstado() // Generador de estado 0 = Inactivo, 1 = Activo
        {
            return Random.Next(0, 1) == 0;
        }

        public static string GenerateRandomPassword() // Generador de contraseñas
        {
            var Password = new[] { "123456", "password", "admin", "root", "qwerty", "12345678", "123456789", "1234567890", "password123", "admin123" };
            return Password[Random.Next(Password.Length)];
        }
    }
}