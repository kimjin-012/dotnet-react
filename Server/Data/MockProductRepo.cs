using System.Collections.Generic;
using Server.Models;

namespace Server.Data
{
    public class MockProductRepo : IProductRepo
    {
        public IEnumerable<Product> GetAllProducts()
        {
            var product = new List<Product>
            {
                new Product{ProductId=0, Name="A", Price=10},
                new Product{ProductId=1, Name="B", Price=20},
                new Product{ProductId=2, Name="C", Price=30}
            };

            return product;
        }

        public Product GetProductById(int id)
        {
            return new Product{ProductId=0, Name="Z", Price=0};
        }
    }
}