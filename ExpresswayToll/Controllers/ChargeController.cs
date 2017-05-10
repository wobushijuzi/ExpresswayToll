using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class ChargeController : Controller
    {
        ChargeBLL chargeBll = new ChargeBLL();
        public ActionResult Index()
        {
            var list = chargeBll.List();
            return View(list);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(t_Charge charge)
        {
            bool result = chargeBll.Add(charge);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("添加失败！！！");
            }
        }
        public ActionResult Det(int id = 1)
        {
            var result = chargeBll.Find(id);
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool result = chargeBll.Del(id);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("删除失败");
            }
        }
    }
}