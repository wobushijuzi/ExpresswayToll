using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class DistanceController : Controller
    {
        DistanceBLL diatanceBll = new DistanceBLL();
        public ActionResult Index()
        {
            var list = diatanceBll.List();
            return View(list);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string Start,string End,double Distance,string Remark)
        {
            t_Distance distance = new t_Distance() {
                Start=Start,
                End=End,
                Distance=Distance,
                Remark=Remark
            };
            bool result = diatanceBll.Add(distance);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("添加失败！！！");
            }
        }
        public ActionResult Det(int id = 0)
        {
            var result = new t_Distance();
            if (id == 0)
            {
                result = diatanceBll.List().FirstOrDefault();
            }
            else
            {
                result = diatanceBll.Find(id);
            }
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool result = diatanceBll.Del(id);
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