using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using BLL;
using Golbal;
using PagedList;

namespace ExpresswayToll.Controllers
{
    public class UserController : Controller
    {
        
        UserBLL userbll = new UserBLL();
        // GET: User
        public ActionResult Index()
        {
            //List<string> companylist = QueryFromWebService.GetDropDownModel();
            //SelectList droplist = new SelectList(companylist, "MSCompany");
            //ViewBag.companylist = droplist.AsEnumerable();

            var li = userbll.list();
            
            return View(li);
        }
        [HttpPost]
        public ActionResult Index(string id)
        {
            int Id = Convert.ToInt32(id);
            var userDet = userbll.Find(Id);
            string msg = "";
            msg += "<div class='modal-body'>";
            msg += "<div class='col-md-4'></div>";
            msg += "<div class='col-md-8'>";
            msg += "<p><span>编号：</span><span>" + userDet.id + "</span></p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "<p>" + userDet.id + "</p>";
            msg += "</div ></div >";
            msg += "<div class='modal-footer'>";
            msg += "<button type='button' class='btn btn-default' data- dismiss='modal' >关闭</button>";
            msg += "<button type='button' class='btn btn-primary' onclick=\"location.href = '/User/Edit/" + userDet.id + "'\" >编辑</button>";
            msg += "<button type='submit' class='btn btn-primary' onclick=\"location.href = '/User/Del/" + userDet.id + "'\">删除</button>";
            msg += "</ div >";
            return Content(msg);
        }
        public ActionResult Det(string id="1")
        {

            int Id = Convert.ToInt32(id);
            var userDet = userbll.Find(Id);
            return PartialView(userDet);
        }
        public ActionResult AddUserRole()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Reg(string UserName,string Password,DateTime Birthday,string Gender, string Phone,string Emain,string QQ)
        {
            bool IsReg = userbll.AddUser(new t_User
            {
                UserName = UserName.Trim().ToLower(),
                Password = Encrypt.Encryption(Password.Trim()),
                Birthday = Birthday,
                Gender = Gender,
                Phone = Phone,
                Emain = Emain,
                QQ = QQ,
                Disadle = 0,
                IsDel=0,
                CreateTime = DateTime.Now
            }, 1);
            if (IsReg)
            {
                return RedirectToAction("Index","Home");
            }
            else
            {
                return Content("<script>alert('注册失败，请检查信息填写，稍后重试')</script>");
            }

            
        }
        public ActionResult Edit(int id)
        {
            var user = userbll.Find(id);
            return View(user);
        }
        [HttpPost]
        public ActionResult Edit(int id, string UserName, string Password, DateTime Birthday, string Gender, string Phone, string Emain, string QQ,int Disadle)
        {
            bool IsEdit = userbll.Edit(new t_User
            {
                id = id,
                UserName = UserName.Trim().ToLower(),
                Password = Encrypt.Encryption(Password.Trim()),
                Birthday = Birthday,
                Gender = Gender,
                Phone = Phone,
                Emain = Emain,
                QQ = QQ,
                Disadle = Disadle,
                IsDel = 0,
                
            });
            if (IsEdit)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View("Edit",new {id=id });
            }
        }
        [HttpPost]
        public ActionResult Del(int id)
        {
            bool IsDel= userbll.Del(id);
            //return Content("OK");
            return RedirectToAction("Index");
        }
        public ActionResult List()
        {
            return View();
        }
        private List<string> DropList()
        {
            return new  List<string>{ "男","女"};
        }
    }
}