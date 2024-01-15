using Eflyer.ModelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Eflyer.Controllers
{
    public class ProductAPIController : ApiController
    {
        QLBanHangQuanAoEntities1 db = new QLBanHangQuanAoEntities1 ();
        public List<Product> Get()
        {
            var sanpham = db.SanPhams.Select(p => new Product
            {
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                AnhDaiDien = p.AnhDaiDien,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat,
                MaPhanLoaiPhu = p.MaPhanLoaiPhu,
                MoTaNgan = p.MoTaNgan
            }).ToList();
            return sanpham;
        }


        public List<Product> GetByCategory(string maloai)
        {
            var sanpham = db.SanPhams
                .Where(p => p.MaPhanLoaiPhu == maloai )
                .Select(p => new Product
            {
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                AnhDaiDien = p.AnhDaiDien,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat,
                MaPhanLoaiPhu = p.MaPhanLoaiPhu,
                MoTaNgan = p.MoTaNgan
            }).ToList();
            return sanpham;
        }
    }
}
