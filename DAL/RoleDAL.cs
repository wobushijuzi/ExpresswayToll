using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class RoleDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public int Add(t_Role role)
        {
            try
            {
                db.role.Add(role);
                db.SaveChanges();
                return 1;
            }
            catch (Exception)
            {
                return 0;
            }
        }
    }

}
