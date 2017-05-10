using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class CarTypeController : Controller
    {
        CarTypeBLL cartypeBll = new CarTypeBLL();
        public ActionResult Index()
        {
            var list = cartypeBll.List();
            return View(list);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string CarType)
        { 
            var car = new t_CarType(){ 
                CarType = CarType
            };
            bool result = cartypeBll.Add(car);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("添加失败！！！");
            }
        }
        public ActionResult Det(int id=0)
        {
            var result = new t_CarType();
            if (id==0)
            {
                result = cartypeBll.List().FirstOrDefault();
            }
            else { 
            result = cartypeBll.Find(id);
            }
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool result = cartypeBll.Del(id);
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