using DeThiLTW_2022.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DeThiLTW_2022.Controllers
{
    public class HomeController : Controller
    {
        QLBanHangQuanAoEntities db = new QLBanHangQuanAoEntities();

        public ActionResult Index()
        {
            HomeModel objHomeModel = new HomeModel ();
             objHomeModel.ListPhanLoai = db.PhanLoais.ToList();
             objHomeModel.ListSanPham = db.SanPhams.ToList();
            return View(objHomeModel);
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