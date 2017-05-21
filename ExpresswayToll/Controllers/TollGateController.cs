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
        RoadBLL roadbll = new RoadBLL();
        public ActionResult Index()
        {
            var list = tollgateBll.List();
            return View(list);
        }
        public ActionResult Add()
        {
            List<string> loc = new List<string>() {
                "市中区","滕州市","山亭区","台儿庄区"
            };
            SelectList list = new SelectList(loc, "List");
            ViewBag.List = list.AsEnumerable();
            List<string> count = new List<string>() {
                "2","4","6","8"
            };
            SelectList countlist = new SelectList(count, "CountList");
            ViewBag.CountList = countlist.AsEnumerable();
            var li = roadbll.List();
            var RoadName = new List<string>();
            foreach (var item in li)
            {
                RoadName.Add(item.RoadName);
            }
            SelectList List = new SelectList(RoadName, "roadlist");
            ViewBag.RoadList = List.AsEnumerable();
            return View();
        }
        [HttpPost]
        public ActionResult Add(string TollGate,string Loction,int Count,string RoadName)
        {
            t_TollGate tollgate = new t_TollGate()
            {
                TollGate=TollGate,
                Loction=Loction,
                Count=Count,
                road=roadbll.List().Where(c=>c.RoadName==RoadName).ToList().FirstOrDefault()
            };
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
        public ActionResult Det(int id = 0)
        {
            var result = new t_TollGate();
            if (id==0)
            {
                result = tollgateBll.List().FirstOrDefault();
            }
            else
            {
                result = tollgateBll.Find(id);
            }
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