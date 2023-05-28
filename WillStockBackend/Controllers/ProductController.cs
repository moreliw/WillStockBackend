using Microsoft.AspNetCore.Mvc;
using WillStockBackend.Data;
using WillStockBackend.Models;

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
        public  IActionResult Index()
        {
            var products = _context.Produto.ToList();
            return Ok(products);
        }

        [HttpPost]
        public IActionResult Create(ProductModel product)
        {
            _context.Produto.Add(product);
            _context.SaveChanges();

            return Ok();
        }
    }
}
