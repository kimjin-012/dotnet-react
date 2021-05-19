using System.Collections.Generic;
using Server.Models;

namespace Server.Data
{
    public interface IProductRepo
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
    }
}