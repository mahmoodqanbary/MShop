using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MShop.Models
{
    public class DetailsViewModel
    {
        public Prodact Prodact { get; set; }
        public List<Category> Categories { get; set; }
    }
}
