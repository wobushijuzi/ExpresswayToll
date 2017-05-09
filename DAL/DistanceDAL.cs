using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DistanceDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_Distance distance)
        {

            try
            {
                db.distance.Add(distance);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_Distance distance)
        {
            try
            {
                var u = db.distance.Find(distance.id);
                u.Start = distance.Start;
                u.End = distance.End;
                u.Distance = distance.Distance;
                u.Remark = distance.Remark;
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
                var u = db.distance.Find(id);
                db.distance.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_Distance> List()
        {
            return db.distance.ToList();
        }
        public List<t_Distance> PageList(int PageIndex, int PageSize)
        {
            List<t_Distance> li = new List<t_Distance>();
            return li;
        }
        public t_Distance Find(int id)
        {
            return db.distance.Find(id);
        }
    }
}
