namespace Administrador_de_asistencias_CEPVA.Models
{
    public class User
    {
        public int Id { get; set; } // Identificador único
        public string UserName { get; set; } // Nombre de usuario
        public string PasswordHash { get; set; } // Contraseña en hash para mayor seguridad
        public string Email { get; set; } // Dirección de correo electrónico
        public string Role { get; set; } // Rol (Admin, User, etc.)
        public DateTime CreatedAt { get; set; } // Fecha de creación del usuario
    }
}
