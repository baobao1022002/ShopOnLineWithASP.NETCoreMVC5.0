using System;
using System.Linq;
using System.Threading.Tasks;
using DiChoSaiGon.Models;
using System.Collections.Generic;

namespace DiChoSaiGon.ModelViews
{
    public class ProductHomeVM
    {
        public Category category { get; set; }
        public List<Product> lsProducts { get; set; }

    }
}
