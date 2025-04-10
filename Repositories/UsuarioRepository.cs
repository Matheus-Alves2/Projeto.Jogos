using Projeto_Jogos.Context;
using Projeto_Jogos.Interfaces;
using ProjetoDeJogos.Domains;

namespace Projeto_Jogos.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ProjetoJogoContext _context;

        public UsuarioRepository(ProjetoJogoContext context)
        {
            _context = context;
        }
        public void AtualizarUsuario(Usuarios usuario)
        {
            try
            {
                Usuarios usuarioExistente = _context.Usuario.Find(usuario)!;
                if (usuarioExistente != null)
                {
                    usuarioExistente = _context.Usuario.Find(usuario)!;
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CastarUsuario(Usuarios usuario)
        {
            try
            {
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarUsuario(int id)
        {
            try
            {
                Usuarios usaurioExistente = _context.Usuario.Find(id)!;
                if (usaurioExistente != null)
                {
                    _context.Usuario.Remove(usaurioExistente);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Usuarios> ListarUsuarios()
        {
           List<Usuarios> usuarios = _context.Usuario.ToList();
            return usuarios;
        }
    }
}
