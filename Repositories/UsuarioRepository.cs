using Projeto_Jogos.Context;
using Projeto_Jogos.Interfaces;
using ProjetoDeJogos.Domains;

namespace Projeto_Jogos.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ProjetoJogoContext _context;

        public JogoRepository(ProjetoJogoContext context)
        {
            _context = context;
        }
        public void AtualizarUsuario(Usuarios usuario)
        {
            throw new NotImplementedException();
        }

        public void CastarUsuario(Usuarios usuario)
        {
           
        }

        public void DeletarUsuario(int id)
        {
            throw new NotImplementedException();
        }

        public List<Usuarios> ListarUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
