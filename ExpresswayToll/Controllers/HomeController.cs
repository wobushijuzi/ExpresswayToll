using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class HomeController : Controller
    {
        TollGateBLL tollgatebll = new TollGateBLL();
        public ActionResult Index()
        {
            ////string s = HttpUtility.UrlDecode(Request.Cookies["TollGate"].Value, Encoding.GetEncoding("utf-8"));
            //if (Request.Cookies["TollGate"].Value == null)
            //{
            //    return RedirectToAction("GetTollGate");
            //}
            try
            {
                string tollaget = Request.Cookies["TollGate"].Value;
            }
            catch (Exception e)
            {

                return RedirectToAction("GetTollGate");
            }

            return View();
        }
        public  ActionResult GetTollGate()
        {
            var li = tollgatebll.List();
            var tollgate = new List<string>();
            foreach (var item in li)
            {
                tollgate.Add(item.TollGate);
            }
            SelectList list = new SelectList(tollgate, "List");
            ViewBag.TollGate = list.AsEnumerable();
            return View();
        }
        [HttpPost]
        public ActionResult GetTollGate(string TollGate)
        {
            HttpCookie tollgateCookie = new HttpCookie("TollGate", HttpUtility.UrlEncode(TollGate.Trim().ToLower(), Encoding.GetEncoding("utf-8")));
            //设置Cookie不过期
            tollgateCookie.Expires = DateTime.MaxValue;
            Response.Cookies.Add(tollgateCookie);
            string a = Request.Cookies["Tollgate"].Value;
            return RedirectToAction("Index");
        }
    }
}