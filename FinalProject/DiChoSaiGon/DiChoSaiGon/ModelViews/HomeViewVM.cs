using System;
using System.Linq;
using System.Threading.Tasks;
using DiChoSaiGon.Models;
using System.Collections.Generic;

namespace DiChoSaiGon.ModelViews
{
    public class HomeViewVM
    {
        public List<News> news { get; set; }
        public List<ProductHomeVM> Products { get; set; }
    }
}
