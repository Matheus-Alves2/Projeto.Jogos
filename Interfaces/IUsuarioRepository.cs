using ProjetoDeJogos.Domains;

namespace Projeto_Jogos.Interfaces
{
    public interface IUsuarioRepository
    {
        //1. Cadastrar
        void CastarUsuario(Usuarios usuario);
        //2. Atualizar
        void AtualizarUsuario(Usuarios usuario);
        //3. Deletar
        void DeletarUsuario(int id);
        //4. Listar
        List<Usuarios> ListarUsuarios();
    }
}
