using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Models
{
    public class Item
    {
        
        public int Id { get; set; }
        public decimal Price { get; set; }
        public int QuantityInStock { get; set; }

        
        public Prodact Prodact { get; set; }



    }
}
