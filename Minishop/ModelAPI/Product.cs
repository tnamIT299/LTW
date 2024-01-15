using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Minishop.ModelAPI
{
    public class Product
    {
        public string MaSanPham { get; set; }

        public string TenSanPham { get; set; }

        public string MaPhanLoai { get; set; }
       
        public Nullable<long> DonGiaBanNhoNhat { get; set; }
     
        public string MoTaNgan { get; set; }

        public string AnhDaiDien { get; set; }
      
        public string MaPhanLoaiPhu { get; set; }
    }
}