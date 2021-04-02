using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Models
{
    public class Prodact
    {
        public Prodact()
        {
            Categories = new List<Category>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Category> Categories { get; set; }

    }
}
