using System;
using System.Collections.Generic;
using DiChoSaiGon.Models;

namespace DiChoSaiGon.ModelViews
{
    public class XemDonHang
    {
        public Order DonHang { get; set; }
        public List<OrderDetail> ChiTietDonHang { get; set; }
    }
}
