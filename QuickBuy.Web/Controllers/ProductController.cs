using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Contracts;
using QuickBuy.Dominio.Entities;
using System;

namespace QuickBuy.Web.Controllers
{
    //Definindo a rota
    [Route("api/[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductRepository _productRepository;

        public ProductController(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                //O Ok retorna um objeto que é o OkResult que devolve os produtos cadastrados na base e também com o StatusCode
                //apontando para 200 que significa que a chamada foi bem sucedida:
                //Posso devolver junto com o Ok o resultado da chamada ao ProductRepository para obter todos os produtos:
                return Ok(_productRepository.GetAll());

                //posso fazer um if utilizando um bad request caso não dê certo;

                /*if(condicao == false)
                {

                    return BadRequest("");
                }*/
            }
            catch(Exception ex)
            {
                //Se der um erro ele vai cair aq em exception e vai devolver a quem invocou o produto um BadRequest
                //ToString() = para receber tudo o que aconteceu sem truncar a mensagem
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody]Product product) //FromBody = do corpo da requisição transforme essa informação
            //que venho por json num objeto que é conhecido pelo sistema. O product vem da requisição.
        {
            try
            {
                _productRepository.Add(product);

                //O Created é chamada se tudo acima der certo. Ele chama a API, chamando o produto e nós vamos devolver o produto
                //que foi criado:
                return Created("api/product", product);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}
