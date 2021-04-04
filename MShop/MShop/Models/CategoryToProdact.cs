using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Models
{
    public class CategoryToProdact
    {
        public int CategoryId { get; set; }
        public int ProdactId { get; set; }


        //Navigation Property
        public Category Category { get; set; }
        public Prodact Prodact { get; set; }
    }
}
