namespace Administrador_de_asistencias_CEPVA
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using Administrador_de_asistencias_CEPVA.Models; // Asegúrate de importar el modelo de Usuario
    using TuProyecto.Models;

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; } // Esta es la tabla que agregarás
    }
}
