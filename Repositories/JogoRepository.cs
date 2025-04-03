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
        public void AtualizarJogo(Guid idDojogo)
        {
            throw new NotImplementedException();
        }

        public void CadastrarJogo(Jogo jogoNovo)
        {
            try
            {
                //Gera um novo ID para o jogo
                jogoNovo.JogoId = Guid.NewGuid(); 

                _context.Jogo.Add(jogoNovo);
                _context.SaveChanges();

                if (jogoNovo != null)
                {
                    _context.Jogo.Add(jogoNovo);
                    _context.SaveChanges();
                }
                else
                {
                    throw new Exception("O Jogo não pode ser nulo");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void DeletarJogo(Guid idDojogo)
        {
            throw new NotImplementedException();
        }

        public List<Jogo> ListarJogos()
        {
            try
            {
                return _context.Jogo.ToList();

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
