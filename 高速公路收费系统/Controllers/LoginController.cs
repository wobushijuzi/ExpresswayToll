using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BLL;
using ExpresswayToll.Function;
using Model;

namespace ExpresswayToll.Controllers
{
    public class LoginController : Controller
    {
        UserBLL userinfo = new UserBLL();
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string UserName,string Password,string remember, string ValidateCode)
        {
            bool rememberState = remember == "on"?true:false;

            bool isLogin = userinfo.AddUser(new t_User
            {
                UserName = "admin1",
                Password = Encrypt.Encryption(Password),
                Birthday = DateTime.Now,
                Gender = "男",
                Phone = "15620930700",
                Emain = "NULL",
                QQ = "NULL",
                CreateTime = DateTime.Now
            }, 1);
            //bool rememberState = RememberState;
            //ISysUserService _sysuserservice = new SysUserService();
            //bool isLogin = userinfo.Login(UserName, Password);
            var aa = Session["ValidateCode"].ToString();
            if (ValidateCode != Session["ValidateCode"].ToString())
            {
                return Content("<script>alert('验证码输入有误')</script>");
            }
            if (!isLogin)
            {
                return Content("<script>alert('登录失败')</script>");
            }
            return RedirectToAction("Index", "Home", new { area = "Admin" });
            
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
    }
}