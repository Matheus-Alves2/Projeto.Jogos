using Projeto_Jogos.Context;
using Projeto_Jogos.Domains;
using Projeto_Jogos.Interfaces;

namespace Projeto_Jogos.Repositories
{
    
    public class JogoRepository : IJogoRepository
    {
        //Herdar da Interface
        //Implementar os métodos da interface
        //Criar a Variavel que puxa informações do Context
        private readonly ProjetoJogoContext _context;

        public JogoRepository(ProjetoJogoContext context)
        {
            _context = context;
        } 
        //Herdar da Interface IJogoRepository
        //Implementar os métodos da interface
        //1. Cadastrar
        //2. Atualizar
        //3. Deletar
        //4. Listar
       

        public void AtualizarJogo(Guid idDojogo, Jogo jogoAtualizado)
        {
            try
            {
                Jogo jogoExistente = _context.Jogo.Find(idDojogo)!;
                if (jogoExistente != null)
                {
                    jogoExistente.NomeDoJogo = jogoExistente.NomeDoJogo;
                }
                    _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void CadastrarJogo(Jogo jogoNovo)
        {
            try
            {
                //Gera um novo ID para o jogo
                jogoNovo.JogoId = Guid.NewGuid(); 

                _context.Jogo.Add(jogoNovo);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarJogo(Guid idDojogo)
        {
            try
            {
                Jogo jogoExistente = _context.Jogo.Find(idDojogo)!;
                //Verifica se o jogo existe
                //Se o jogo existir, remove

                if (jogoExistente != null)
                {
                    _context.Jogo.Remove(jogoExistente);
                }
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Jogo> ListarJogos()
        {
          List<Jogo> jogos = _context.Jogo.ToList();
            return jogos;
        }
    }
}
