using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DutyDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_Duty duty)
        {

            try
            {
                db.duty.Add(duty);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_Duty duty)
        {
            try
            {
                var u = db.duty.Find(duty.Id);
                u.DutyPerson = duty.DutyPerson;
                u.DutyPositoin = duty.DutyPositoin;
                u.DutyDate = duty.DutyDate;
                u.DutyTime = duty.DutyTime;
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
                var u = db.duty.Find(id);
                db.duty.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_Duty> List()
        {
            return db.duty.ToList();
        }
        public List<t_Duty> PageList(int PageIndex, int PageSize)
        {
            List<t_Duty> li = new List<t_Duty>();
            return li;
        }
        public t_Duty Find(int id)
        {
            return db.duty.Find(id);
        }
    }

}
