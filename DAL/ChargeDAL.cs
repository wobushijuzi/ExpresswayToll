using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChargeDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_Charge charge)
        {

            try
            {
                db.charge.Add(charge);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        //public bool Edit(t_Charge charge)
        //{
        //    try
        //    {
        //        var u = db.charge.Find(charge.Id);
        //        u.CardId = charge.charge;
        //        u.charge = charge.charge;
        //        db.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }
        //}
        public bool Del(int id)
        {
            try
            {
                var u = db.charge.Find(id);
                db.charge.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_Charge> List()
        {
            return db.charge.ToList();
        }
        public List<t_Charge> PageList(int PageIndex, int PageSize)
        {
            List<t_Charge> li = new List<t_Charge>();
            return li;
        }
        public t_Charge Find(int id)
        {
            return db.charge.Find(id);
        }
    }
}
