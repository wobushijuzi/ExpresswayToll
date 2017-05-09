using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class IllegalDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_Illegal illegal)
        {

            try
            {
                db.illegal.Add(illegal);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_Illegal illegal)
        {
            try
            {
                var u = db.illegal.Find(illegal.Id);
                u.CarId = illegal.CarId;
                u.Illegal = illegal.Illegal;
                u.IllegalPosition = illegal.IllegalPosition;
                u.IllegalTime = illegal.IllegalTime;
                u.Remark = illegal.Remark;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Del(int id)
        {
            try
            {
                var u = db.illegal.Find(id);
                db.illegal.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_Illegal> List()
        {
            return db.illegal.ToList();
        }
        public List<t_Illegal> PageList(int PageIndex, int PageSize)
        {
            List<t_Illegal> li = new List<t_Illegal>();
            return li;
        }
        public t_Illegal Find(int id)
        {
            return db.illegal.Find(id);
        }
    }

}
