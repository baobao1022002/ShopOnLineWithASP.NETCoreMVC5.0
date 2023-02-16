using DiChoSaiGon.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace DiChoSaiGon.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchController : Controller
    {
        private readonly MarketsContext _context;

        public SearchController(MarketsContext context)
        {
            _context = context;
        }

        //GET: Search/FindProduct
        [HttpPost]
        public IActionResult FindProduct(string keyword)
        {
            List<Product> ls = new List<Product>();
            if(string.IsNullOrEmpty(keyword)|| keyword.Length<1)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            ls=_context.Products
                                .AsNoTracking()
                                .Include(a=>a.Cat)
                                .Where(x=>x.ProductName.Contains(keyword))
                                .OrderByDescending(x=>x.ProductName)
                                .Take(10)
                                .ToList();

            if(ls==null)
            {
                return PartialView("ListProductsSearchPartial", null);
            }
            else 
            {
                return PartialView("ListProductsSearchPartial", ls);
            }
        }

        //GET: Search/FindCustomer
        [HttpPost]
        public IActionResult FindCustomer(string keyword)
        {
            List<Customer> ls = new List<Customer>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListCustomersSearchPartial", null);
            }
            ls = _context.Customers
                                .AsNoTracking()                              
                                .Where(x => x.FullName.Contains(keyword))
                                .OrderByDescending(x => x.FullName)
                                .Take(10)
                                .ToList();

            if (ls == null)
            {
                return PartialView("ListCustomersSearchPartial", null);
            }
            else
            {
                return PartialView("ListCustomersSearchPartial", ls);
            }
        }

        //GET: Search/FindNew
        [HttpPost]
        public IActionResult FindNew(string keyword)
        {
            List<News> ls = new List<News>();
            if (string.IsNullOrEmpty(keyword) || keyword.Length < 1)
            {
                return PartialView("ListNewsSearchPartial", null);
            }
            ls = _context.News
                                .AsNoTracking()                          
                                .Where(x => x.Title.Contains(keyword))
                                .OrderByDescending(x => x.Title)
                                .Take(10)
                                .ToList();

            if (ls == null)
            {
                return PartialView("ListNewsSearchPartial", null);
            }
            else
            {
                return PartialView("ListNewsSearchPartial", ls);
            }
        }
    }
}
