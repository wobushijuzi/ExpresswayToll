using BLL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExpresswayToll.Controllers
{
    public class MenuController : Controller
    {
        MenuBLL menuBLL = new MenuBLL();
        UserBLL userbll = new UserBLL();
        public ActionResult Index()
        {
            //string person = System.Web.HttpContext.Current.Request.Cookies["UserName"].Value;
            //t_User user = userbll.list().Where(c => c.UserName == person).FirstOrDefault();

            var li = menuBLL.GetMenu();
            return PartialView(li);
        }
    }
}