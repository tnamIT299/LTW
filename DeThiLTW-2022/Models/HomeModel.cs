using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DeThiLTW_2022.Models
{
    public class HomeModel
    {
        public List<PhanLoai> ListPhanLoai { get; set; }

        public List<SanPham> ListSanPham { get; set; }
    }
}