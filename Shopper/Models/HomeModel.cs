﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Shopper.Models
{
    public class HomeModel
    {
       public  List<SanPham> ListSanPham { get; set; }
       public  List<PhanLoai> ListPhanLoai { get; set; }

    }
}