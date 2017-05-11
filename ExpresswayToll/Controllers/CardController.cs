using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;


namespace ExpresswayToll.Controllers
{
    public class CardController : Controller
    {
        CardBLL cardBll = new CardBLL();
        public ActionResult Index()
        {
            var list = cardBll.List();
            return View(list);
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Add(string CardId)
        {
            bool result = cardBll.Add(CardId);
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
            var result = new t_Card();
            if (id == 0)
            {
                result = cardBll.List().FirstOrDefault();
            }
            else
            {
                result = cardBll.Find(id);
            }
            return PartialView(result);
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool result = cardBll.Del(id);
            if (result)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return Content("删除失败");
            }
        }
        public ActionResult InBound()
        {
            Session["Result"] = "";
            return View();
        }
        [HttpPost]
        public ActionResult InBound(string Id,string CarId,string CarType)
        {
            bool result = cardBll.Edit(Id,CarId,CarType);
            if (result)
            {
                Session["Result"] = "";
            }
            else
            {

                Session["Result"] = "添加失败";
            }
            return View();
        }


    }
}