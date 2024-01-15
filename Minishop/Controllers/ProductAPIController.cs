using Minishop.ModelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Minishop.Controllers
{
    public class ProductAPIController : ApiController
    {
        QLBanGiayEntities1 db = new QLBanGiayEntities1 (); 
        public List<Product> Get()
        {
            var sanpham = db.SanPhams.Select(p => new Product
            {
                MaSanPham = p.MaSanPham,
                TenSanPham= p.TenSanPham,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat,
                AnhDaiDien = p.AnhDaiDien,
                MoTaNgan = p.MoTaNgan,
                MaPhanLoaiPhu = p.MaPhanLoaiPhu

            }).ToList();
            return sanpham;
        }

        public List<Product> GetByCategory(string maloai)
        {
            var sanpham = db.SanPhams
                .Where(p => p.MaPhanLoaiPhu == maloai)
                .Select(p => new Product
            {
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat,
                AnhDaiDien = p.AnhDaiDien,
                MoTaNgan = p.MoTaNgan,
                MaPhanLoaiPhu = p.MaPhanLoaiPhu
            }).ToList();
            return sanpham;
        }
    }
}
