using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CarTypeDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_CarType cartype)
        {

            try
            {
                db.cartype.Add(cartype);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_CarType cartype)
        {
            try
            {
                var u = db.cartype.Find(cartype.Id);
                u.CarType = cartype.CarType;
                u.CarType = cartype.CarType;
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
                var u = db.cartype.Find(id);
                db.cartype.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_CarType> List()
        {
            return db.cartype.ToList();
        }
        public List<t_CarType> PageList(int PageIndex, int PageSize)
        {
            List<t_CarType> li = new List<t_CarType>();
            return li;
        }
        public t_CarType Find(int id)
        {
            return db.cartype.Find(id);
        }
    }
}
