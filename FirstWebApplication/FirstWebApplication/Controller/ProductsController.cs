using FirstWebApplication.Models;
using FirstWebApplication.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Controller
{
    [Route("/bvitatidata")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductService productService)
        {
            this.ProductService = productService;
        }
        public JsonFileProductService ProductService { get; }
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductService.GetProducts();
        }
        //[HttpPost]
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(string ProductId, int Rating)
        {
            ProductService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}
