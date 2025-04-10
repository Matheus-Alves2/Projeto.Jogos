using Microsoft.AspNetCore.Mvc;
using Projeto_Jogos.Interfaces;
using ProjetoDeJogos.Domains;

namespace Projeto_Jogos.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : Controller
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.ListarUsuarios());
            }
            catch (Exception)
            {
                return BadRequest("Erro ao listar os usuarios");
            }
        }
        [HttpPost]
        public IActionResult Post(Usuarios usuarioNovo)
        {
            try
            {
                _usuarioRepository.CastarUsuario(usuarioNovo);
                return StatusCode(201);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao cadastrar o usuario");
            }
        }
        [HttpPut("{idDoUsuario}")]
        public IActionResult Put(int idDoUsuario, Usuarios usuarioAtualizado)
        {
            try
            {
                _usuarioRepository.AtualizarUsuario(usuarioAtualizado);
                return StatusCode(204);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao atualizar o usuario");
            }
        }
        [HttpDelete("{idDoUsuario}")]
        public IActionResult Delete(int idDoUsuario)
        {
            try
            {
                _usuarioRepository.DeletarUsuario(idDoUsuario);
                return StatusCode(204);
            }
            catch (Exception)
            {
                return BadRequest("Erro ao deletar o usuario");
            }
        }

    }
}
