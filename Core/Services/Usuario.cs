using Core.Entities;
using DefaultNamespace;

namespace WebApplication1.Core.Services
{
    public class UsuarioService : IUsuarioService
    {
        private readonly AppDbContext _context;

        public UsuarioService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<Usuario> CreateUsuario(Usuario usuario)
        {
            _context.Usuarios.Add(usuario);
            await _context.SaveChangesAsync();
            return usuario;
        }

        public async Task<Usuario> GetUsuarioByEmail(string correo)
        {
            return await _context.Usuarios.SingleOrDefaultAsync(u => u.Correo == correo);
        }
    
    }
