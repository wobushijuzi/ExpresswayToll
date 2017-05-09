using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class MenuDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public List<t_Menu> List()
        {
            List<t_Menu> li = new List<t_Menu>();
            li = db.menu.ToList();
            return li ;
        }
    }
}
