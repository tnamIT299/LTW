using Eflyer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Eflyer.Controllers
{
    public class HomeController : Controller
    {
        QLBanHangQuanAoEntities1 db = new QLBanHangQuanAoEntities1 ();
        public ActionResult Index()
        {
            HomeModel obj = new HomeModel();
            obj.ListSanPham = db.SanPhams.ToList();
            obj.ListPhanLoaiPhu = db.PhanLoaiPhus.ToList();

            return View(obj);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}