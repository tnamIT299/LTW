using Alazea.ModelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Alazea.Controllers
{
    public class ProductAPIController : ApiController
    {
        QLBanChauCanhEntities db = new QLBanChauCanhEntities();
        public List<Product> Get()
        {
            var sanpham = db.SanPhams.Select(p => new Product
            {
                MaPhanLoai = p.MaPhanLoai,
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat,
                AnhDaiDien = p.AnhDaiDien
            }).ToList();
            return sanpham;
        }

        public List<Product> GetProductByCategory(string maloai)
        {
            var sanpham = db.SanPhams
                .Where(p => p.MaPhanLoai == maloai)
                .Select(p => new Product
            {
                MaPhanLoai = p.MaPhanLoai,
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat,
                AnhDaiDien = p.AnhDaiDien
            }).ToList();
            return sanpham;
        }
    }
}
