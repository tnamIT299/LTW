using DeThiLTW_2022.ModelAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DeThiLTW_2022.Controllers
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
                MaPhanLoai = p.MaPhanLoai,
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
                                        MaSanPham = p.MaSanPham,
                                        TenSanPham = p.TenSanPham,
                                        MaPhanLoai = p.MaPhanLoai,
                                        AnhDaiDien = p.AnhDaiDien
                                    }).ToList();
            return sanpham;
        }

    }
}
