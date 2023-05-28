using Microsoft.AspNetCore.Mvc;
using WillStockBackend.Data;

namespace WillStockBackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var products = _context.Produto.ToList();
            HttpContext.Response.Headers.Add("Access-Control-Allow-Origin", "http://localhost:4200");
            return Ok(products);
        }
    }
}
