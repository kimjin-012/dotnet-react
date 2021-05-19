using System.Collections.Generic;
using System.Linq;
using Server.Models;

namespace Server.Data
{
    public class SqlProductRepo : IProductRepo
    {
        private ServerContext db;
        public SqlProductRepo(ServerContext context)
        {
            db = context;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return db.Products.ToList();
        }

        public Product GetProductById(int id)
        {
            return db.Products.FirstOrDefault(p => p.ProductId == id);
        }
    }
}