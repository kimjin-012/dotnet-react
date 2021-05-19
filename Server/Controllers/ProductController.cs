using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Server.Models;
using Server.Data;

namespace Server.Controllers
{
    // route : "api/product"
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepo _repository;

        public ProductController(IProductRepo repository)
        {
            _repository = repository;
        }

        // private readonly MockProductRepo _repository = new MockProductRepo();
        //Get api/product
        [HttpGet]
        public ActionResult <IEnumerable<Product>> GetAllProducts()
        {
            var productItems = _repository.GetAllProducts();

            return Ok(productItems);
        }

        //Get api/product/{id}
        [HttpGet("{id}")]
        public ActionResult <Product> GetProductById(int id)
        {
            var productItem = _repository.GetProductById(id);

            return Ok(productItem);
        }
    }
}