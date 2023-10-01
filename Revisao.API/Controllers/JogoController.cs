using Microsoft.AspNetCore.Mvc;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;

namespace Revisao.API.Controllers
{
   
        [ApiController]
        [Route("[controller]")]
        public class JogoController : ControllerBase
        {
            private readonly IJogoService _jogoService;

            public JogoController(IJogoService jogoService)
            {
                _jogoService = jogoService;
            }

            [HttpPost(Name = "Adicionar")]
            public IActionResult Post(NovoJogoViewModel novojogoViewModel)
            {
                _jogoService.Adicionar(novojogoViewModel);

                return Ok("Jogo Registrado com sucesso!");
            }


            [HttpGet(Name = "ObterTodos")]
            public IActionResult Get()
            {
                return Ok(_jogoService.ObterTodos());
            }
        }
    
}
