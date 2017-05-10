using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class NewsController : Controller
    {
        NewsBLL newsBLL = new NewsBLL();
        public ActionResult Index()
        {
            var list = newsBLL.List();
            return View(list);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(t_News news)
        {
            bool result = newsBLL.Add(news);
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
            var result = newsBLL.Find(id);
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool result = newsBLL.Del(id);
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