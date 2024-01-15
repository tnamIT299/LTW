using Shopper.ModelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Shopper.Controllers
{
    public class ProductAPIController : ApiController
    {
       QLBanHangQuanAoEntities1  db = new QLBanHangQuanAoEntities1 ();
        public List<Product> Get()
        {
            var sanpham = db.SanPhams.Select(p => new Product
            {
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                MaPhanLoai = p.MaPhanLoai,
                AnhDaiDien = p.AnhDaiDien,
                MoTaNgan = p.MoTaNgan,
                DonGiaBanNhoNhat  = p.DonGiaBanNhoNhat
            }).ToList();
            return sanpham;
        }

        public List<Product> GetByCategory(string maloai)
        {
            var sanpham = db.SanPhams
                .Where(p => p.MaPhanLoai == maloai)
                .Select(p => new Product
            {
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                MaPhanLoai = p.MaPhanLoai,
                AnhDaiDien = p.AnhDaiDien,
                MoTaNgan = p.MoTaNgan,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat
            }).ToList();
            return sanpham;
        }

    }
}
