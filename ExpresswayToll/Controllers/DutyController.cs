using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class DutyController : Controller
    {
        DutyBLL dutyBll = new DutyBLL();
        public ActionResult Index()
        {
            var list = dutyBll.List();
            return View(list);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(t_Duty duty)
        {
            bool result = dutyBll.Add(duty);
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
            var result = dutyBll.Find(id);
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool result = dutyBll.Del(id);
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