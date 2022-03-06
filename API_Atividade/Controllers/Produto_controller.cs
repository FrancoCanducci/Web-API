using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_Atividade.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Produto_controller : ControllerBase
    {
        private static List<Produto> Produtos = new List<Produto>
            {
              new Produto {
                  id = 1,
                  Nome = "Uva",
                  Descricao = "Uvas frescas",
                  Peso = 0.2f
              },
              new Produto {
                  id = 20020,
                  Nome = "Banana",
                  Descricao = "Banana-Prata",
                  Peso = 0.4f
              }

            };

        [HttpGet]
        public async Task<ActionResult<List<Produto>>> Get()
        {

            return Ok(Produtos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Produto>> Get(int id)
        {
            var fruta = Produtos.Find(h => h.id == id );
            if(Produtos == null)
                BadRequest("Produto não encontrado");
            return Ok(Produtos);
        }

        [HttpPost]

        public async Task<ActionResult<List<Produto>>> AddProduto(Produto fruta)
        {
            Produtos.Add(fruta);
            return Ok(Produtos);
        }

    }
}
