using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class ChargeStandardController : Controller
    {
        ChargeStandardBLL chargestandardBll = new ChargeStandardBLL();
        CarTypeBLL cartype = new CarTypeBLL();
        public ActionResult Index()
        {
            var list = chargestandardBll.List();
            return View(list);
        }
        public ActionResult Add()
        {
            var li = cartype.List();
            var CarType = new List<string>();
            foreach (var item in li)
            {
                CarType.Add(item.CarType);
            }
            SelectList List = new SelectList(CarType, "CarType");
            ViewBag.CarType = List.AsEnumerable();
            return View();
        }
        [HttpPost]
        public ActionResult Add(t_ChargeStandard chargestandard)
        {
            bool result = chargestandardBll.Add(chargestandard);
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
            var result = new t_ChargeStandard();
            if (id == 0)
            {
                result = chargestandardBll.List().FirstOrDefault();
            }
            else
            {
                result = chargestandardBll.Find(id);
            }
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool result = chargestandardBll.Del(id);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("删除失败");
            }
        }
        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Edit(t_ChargeStandard ChargeStandard)
        {
            bool result = chargestandardBll.Edit(ChargeStandard);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else { 
                return Content("修改失败！！！");
            }
        }

    }
}