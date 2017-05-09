using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;

namespace ExpresswayToll.Controllers
{
    public class UserController : Controller
    {
        UserBLL userbll = new UserBLL();
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(t_User user)
        {
           // bool result =

            return View();
        }
    }
}