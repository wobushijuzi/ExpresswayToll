using BLL;
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
        public ActionResult Index()
        {
            var li = menuBLL.list();
            return PartialView(li);
        }
    }
}