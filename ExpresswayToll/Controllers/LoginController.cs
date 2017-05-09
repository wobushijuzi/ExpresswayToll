using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using Model;
using Golbal;
using System.Text;

namespace ExpresswayToll.Controllers
{
    public class LoginController : Controller
    {
        UserBLL userinfo = new UserBLL();
        // GET: Login
        public ActionResult Index()
        {
            List<string> Gender = DropList();
            SelectList Genderlist = new SelectList(Gender, "GenderList");
            ViewBag.GenderList = Genderlist.AsEnumerable();
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserName, string Password, string remember, string ValidateCode)
        {
            bool rememberState = remember != null ? true : false;
            HttpCookie nameCookie = new HttpCookie("UserName", HttpUtility.UrlEncode(UserName.Trim().ToLower(), Encoding.GetEncoding("utf-8")));
            //设置Cookie不过期
            nameCookie.Expires = DateTime.MaxValue;
            Response.Cookies.Add(nameCookie);
            if (rememberState)//记住用户名和密码
            {

                HttpCookie passwordCookie = new HttpCookie("Password", Password.Trim());
                Response.Cookies.Add(passwordCookie);
                passwordCookie.Expires = DateTime.MaxValue;
            }
            else
            {
                //让cookie失效
                Response.Cookies["UserName"].Expires = DateTime.Now.AddDays(-1);
                Response.Cookies["Password"].Expires = DateTime.Now.AddDays(-1);
            }
            //bool sLogin = userinfo.AddUser(new t_User
            //{
            //    UserName = "admin1",
            //    Password = Encrypt.Encryption(Password),
            //    Birthday = DateTime.Now,
            //    Gender = "男",
            //    Phone = "15620930700",
            //    Emain = "NULL",
            //    QQ = "NULL",
            //    CreateTime = DateTime.Now
            //}, 1);
            //bool rememberState = RememberState;
            //ISysUserService _sysuserservice = new SysUserService();
            bool isLogin = userinfo.Login(UserName.Trim().ToLower(), Encrypt.Encryption(Password.Trim().ToLower()));
            var aa = Session["ValidateCode"].ToString();
            if (ValidateCode != Session["ValidateCode"].ToString())
            {
                return Content("<script>alert('验证码输入有误')</script>");
            }
            if (!isLogin)
            {
                return Content("<script>alert('登录失败')</script>");
            }
            return RedirectToAction("Index", "Home");

        }
        public virtual ActionResult VerifyImage()
        {
            var validateCodeType = new ValidateCode();
            string code = "6666";
            byte[] bytes = validateCodeType.CreateImage(out code);
            //this.CookieContext.VerifyCodeGuid = VerifyCodeHelper.SaveVerifyCode(code);
            Session["ValidateCode"] = code;
            return File(bytes, @"image/jpeg");
        }
        private List<string> DropList()
        {
            return new List<string> { "男", "女" };
        }
    }
}