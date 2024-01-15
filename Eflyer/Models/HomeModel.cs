using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eflyer.Models
{
    public class HomeModel
    {
        public List<SanPham> ListSanPham { get; set; }
        public List<PhanLoaiPhu> ListPhanLoaiPhu { get; set; }
    }
}