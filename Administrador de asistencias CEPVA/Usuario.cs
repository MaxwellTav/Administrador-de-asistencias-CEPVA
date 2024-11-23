using System;

namespace TuProyecto.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string? Sexo { get; set; }
        public DateTime? FechaNacimiento { get; set; }
        public int? Edad { get; set; }
        public string? Nacionalidad { get; set; }
        public string? Direccion { get; set; }
        public string? Telefono { get; set; }
        public string CorreoElectronico { get; set; } = null!;
        public string Contrasena { get; set; } = null!;
        public byte[]? FotoPerfil { get; set; } // Para la imagen del perfil
    }
}
