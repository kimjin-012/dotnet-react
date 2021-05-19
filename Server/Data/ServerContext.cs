using Microsoft.EntityFrameworkCore;
using Server.Models;

namespace Server.Data
{
    public class ServerContext : DbContext
    {
        public ServerContext(DbContextOptions options) : base(options) { }

        public DbSet<User> Users {get;set;}
        public DbSet<Product> Products {get;set;}
    }
}