using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Models
{
    public class Prodact
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
        public int ItemId { get; set; }

        public Item Item { get; set; }
        public ICollection<CategoryToProdact> CategoryToProdacts { get; set; }

    }
}
