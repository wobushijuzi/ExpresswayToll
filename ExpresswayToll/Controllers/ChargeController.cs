using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Golbal;
using System.Text;

namespace ExpresswayToll.Controllers
{
    public class ChargeController : Controller
    {
        ChargeBLL chargeBll = new ChargeBLL();
        CardBLL cardBLL = new CardBLL();
        public ActionResult Index()
        {
            var list = chargeBll.List();
            return View(list);
        }
        public ActionResult Add(string cardId,double weight)
        {
            string outbound = HttpUtility.UrlDecode(Request.Cookies["TollGate"].Value, Encoding.GetEncoding("utf-8"));
            var inbound = cardBLL.List().Where(c => c.CardId == cardId).ToList().FirstOrDefault();            
            double pay = new Charge().GetPay(inbound.CarType, weight, inbound.Inbound, outbound);
            if (inbound.CarType=="货车"&&weight>=90)
            {
                pay = pay * 6;
            }
            ViewBag.pay = pay;
            return View(inbound);
        }
        [HttpPost]
        public ActionResult Add(string CardId, string CarId,string CarType,String InBound,DateTime InBoundTime,double Charge,string Remark)
        {
            bool result = chargeBll.Add(CardId,CarId, CarType, InBound, InBoundTime, Charge, Remark);
            if (result)
            {
                return RedirectToAction("OutBound");
            }
            else
            {
                return Content("添加失败！！！");
            }
        }
        public ActionResult Det(int id = 0)
        {
            var result = new t_Charge();
            if (id == 0)
            {
                result = chargeBll.List().FirstOrDefault();
            }
            else
            {
                result = chargeBll.Find(id);
            }
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
        public ActionResult OutBound()
        {
            return View();
        }
        [HttpPost]
        public ActionResult OutBound(string cardId)
        {
            return RedirectToAction("Add",new { cardId=cardId,weight=20});
        }
    }
}