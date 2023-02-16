using System;
using System.Collections.Generic;
using DiChoSaiGon.Extension;
using DiChoSaiGon.ModelViews;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace WebShop.Controllers.Components
{
    public class NumberCartViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var cart = HttpContext.Session.Get<List<CartItem>>("GioHang");
             
            return View(cart);
        }
    }
}