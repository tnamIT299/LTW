using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Cozastore.ModelAPI;

namespace Cozastore.Controllers
{
    public class ProductAPIController : ApiController
    {
        QLBanHangQuanAoEntities db = new QLBanHangQuanAoEntities();

        public List<Product> Get()
        {

            var sanpham = db.SanPhams.Select(p => new Product
            {
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                MaPhanLoaiPhu = p.MaPhanLoaiPhu,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat,
                AnhDaiDien = p.AnhDaiDien
            }).ToList();
            return sanpham;

        }


        public List<Product> GetProductByCategory(string maloai)
        {

            var sanpham = db.SanPhams.Where(p => p.MaPhanLoaiPhu == maloai)
                                     .Select(p => new Product
            {
                MaSanPham = p.MaSanPham,
                TenSanPham = p.TenSanPham,
                MaPhanLoaiPhu = p.MaPhanLoaiPhu,
                DonGiaBanNhoNhat = p.DonGiaBanNhoNhat,
                AnhDaiDien = p.AnhDaiDien
            }).ToList();
            return sanpham;

        }
    }
}
