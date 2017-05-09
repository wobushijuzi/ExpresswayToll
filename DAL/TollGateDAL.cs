using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class TollGateDAL

    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_TollGate tollgate)
        {

            try
            {
                db.tollgate.Add(tollgate);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_TollGate tollgate)
        {
            try
            {
                var u = db.tollgate.Find(tollgate.Id);
                u.TollGate = tollgate.TollGate;
                u.Loction = tollgate.Loction;
                u.Count = tollgate.Count;
                u.road = tollgate.road;
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
                var u = db.tollgate.Find(id);
                db.tollgate.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_TollGate> List()
        {
            return db.tollgate.ToList();
        }
        public List<t_TollGate> PageList(int PageIndex, int PageSize)
        {
            List<t_TollGate> li = new List<t_TollGate>();
            return li;
        }
        public t_TollGate Find(int id)
        {
            return db.tollgate.Find(id);
        }
    }
}
