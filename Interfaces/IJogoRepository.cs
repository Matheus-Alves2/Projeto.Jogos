using Projeto_Jogos.Domains;

namespace Projeto_Jogos.Interfaces
{
    public interface IJogoRepository
    {
        //1. Cadastrar
        void CadastrarJogo(Jogo jogoNovo);
        //2. Atualizar
        void AtualizarJogo(Guid idDojogo, Jogo jogoAtualizado);
        //3. Deletar
        void DeletarJogo(Guid idDojogo);
        //4. Listar
        List<Jogo> ListarJogos();

    }
}
