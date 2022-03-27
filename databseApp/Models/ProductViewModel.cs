using System;
using System.ComponentModel.DataAnnotations;


namespace databseApp.Models
{
    public class ProductViewModel
    {
        [Key]
        public string ProductId { get; set; };
        public string Size { get; set; }
        public float Price { get; set; }
        public string Name { get; set; }

    }
}
