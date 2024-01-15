using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Amado.Models;

namespace Amado.Controllers
{
    public class HomeController : Controller
    {
        QLBanChauCanhEntities db = new QLBanChauCanhEntities();
        public ActionResult Index()
        {
            HomeModel objModel = new HomeModel();
            objModel.ListSanPham = db.SanPhams.ToList();
            objModel.ListPhanLoaiPhu = db.PhanLoaiPhus.ToList();
            return View(objModel);
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