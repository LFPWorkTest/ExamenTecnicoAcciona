using Microsoft.EntityFrameworkCore;
using ExamenTecnico.Models;

namespace ExamenTecnico.Data
{
    public class ExamenTecnicoDBContext : DbContext
    {
        public ExamenTecnicoDBContext (DbContextOptions<ExamenTecnicoDBContext> options)
            : base(options)
        {   
        }

        public DbSet<UsuarioModel> UsuariosLista { get; set; }
    }
}
