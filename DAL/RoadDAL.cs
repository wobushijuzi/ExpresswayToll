using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoadDAL

    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_Road road)
        {

            try
            {
                db.road.Add(road);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_Road road)
        {
            try
            {
                var u = db.road.Find(road.id);
                u.RoadNo = road.RoadNo;
                u.RoadName = road.RoadName;
                u.BuildTime = road.BuildTime;
                u.BuildCompany = road.BuildCompany;
                u.Remark = road.Remark;
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
                var u = db.road.Find(id);
                db.road.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_Road> List()
        {
            return db.road.ToList();
        }
        public List<t_Road> PageList(int PageIndex, int PageSize)
        {
            List<t_Road> li = new List<t_Road>();
            return li;
        }
        public t_Road Find(int id)
        {
            return db.road.Find(id);
        }
    }
}
