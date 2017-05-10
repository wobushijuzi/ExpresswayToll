using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class TollGateController : Controller
    {
        TollGateBLL tollgateBll = new TollGateBLL();
        public ActionResult Index()
        {
            var list = tollgateBll.List();
            return View(list);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(t_TollGate tollgate)
        {
            bool result = tollgateBll.Add(tollgate);
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
            var result = tollgateBll.Find(id);
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool result = tollgateBll.Del(id);
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