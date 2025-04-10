using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projeto_Jogos.Domains;
using Projeto_Jogos.Interfaces;

namespace Projeto_Jogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JogoController : ControllerBase
    {
        private readonly IJogoRepository _jogoRepository;
        public JogoController(IJogoRepository jogoRepository)
        {
            _jogoRepository = jogoRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_jogoRepository.ListarJogos());
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar os jogos");
            }
        }
        [HttpPost]
        public IActionResult Post(Jogo jogoNovo)
        {
            try
            {
                _jogoRepository.CadastrarJogo(jogoNovo);
                return StatusCode(201);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao cadastrar o jogo");
            }
        }
        [HttpPut("{idDojogo}")]
        public IActionResult Put(Guid idDojogo, Jogo jogoAtualizado)
        {
            try
            {
                _jogoRepository.AtualizarJogo(idDojogo, jogoAtualizado);
                return StatusCode(204);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao atualizar o jogo");
            }
        }
        [HttpDelete("{idDojogo}")]
        public IActionResult Delete(Guid idDojogo)
        {
            try
            {
                _jogoRepository.DeletarJogo(idDojogo);
                return StatusCode(204);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao deletar o jogo");
            }
        }
    }
}
