using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class MenuBLL
    {
        MenuDAL menuDAL = new MenuDAL();
        public List<t_Menu> list()
        {
            return menuDAL.List();
        }

        public List<t_Menu> GetMenu()
        {
            return menuDAL.GetMenu();
        }
    }
}
