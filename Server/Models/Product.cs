using System;
using System.ComponentModel.DataAnnotations;

namespace Server.Models
{
    public class Product
    {
        [Key]
        public int ProductId {get;set;}

        [Required(ErrorMessage="Name of the Product required")]
        public string Name {get;set;}

        [Required(ErrorMessage="Price required")]
        public int Price {get;set;}

        public DateTime CreatedAt {get;set;} = DateTime.Now;
        public DateTime UpdatedAt {get;set;} = DateTime.Now;
    }
}