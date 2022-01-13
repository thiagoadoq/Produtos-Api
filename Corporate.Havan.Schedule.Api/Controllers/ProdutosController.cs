using Corporate.Havan.Schedule.Application.Contracts.Applications;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;

namespace Corporate.Havan.Schedule.Api.Controllers
{
    [Route("api/produtos")]
    public class ProdutosController : Controller
    {
        private readonly IProdutoApplication _produto;
        private readonly IProdutoFamiliaApplication _produtoFamilia;

        public ProdutosController(IProdutoApplication Produto, IProdutoFamiliaApplication produtoFamilia)
        {
            _produto = Produto;
            _produtoFamilia = produtoFamilia;
        }

        /// <summary>
        /// Consultar um produto pelo id da familia.
        /// </summary>
        /// <param name="idFamilia"></param>
        /// <returns>Um objeto de produtos</returns>
        [HttpGet("familia-id")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public  IActionResult GetProdutosAsync([FromQuery] int idFamilia)
        {
            try
            {
                if (idFamilia != 0)
                {
                    var result =  _produto.GetById(idFamilia);  
                    return Ok(result);
                }
                return BadRequest("Id informado esta invalido");
                   
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        /// <summary>
        /// Consultar uma lista de familias de produtos.
        /// </summary>
        /// <returns>Uma lista de familia de produto</returns>
        [HttpGet("produto-familia")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetAllFamilhaProdAsync()
        {
            try
            {
                var result = await _produtoFamilia.GetAllFamiliaProd();
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
