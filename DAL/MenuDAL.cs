using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Web;

namespace DAL
{
    public class MenuDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public List<t_Menu> List()
        {
            List<t_Menu> li = new List<t_Menu>();
            li = db.menu.ToList();
            return li;
        }
        public List<t_Menu> GetMenu()
        {
            List<t_Menu> li = new List<t_Menu>();
            string person = HttpContext.Current.Request.Cookies["UserName"].Value;
            t_User user = db.user.Where(c => c.UserName == person).FirstOrDefault();
            int roleid = db.utr.Where(c => c.user.id == user.id).ToList().FirstOrDefault().role.Id;
            if (roleid == 1)
            {
                return List();
            }
            else
            {
                var menu = db.rtm.Where(c => c.RoleId == roleid).ToList();
                foreach (var item in menu)
                {
                    li.Add(db.menu.Where(c => c.Id == item.MenuId).FirstOrDefault());
                }
                return li;
            }
        }
    }
}
