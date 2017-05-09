using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChargeStandardDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_ChargeStandard chargestandard)
        {

            try
            {
                db.chargestandard.Add(chargestandard);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_ChargeStandard chargestandard)
        {
            try
            {
                var u = db.chargestandard.Find(chargestandard.Id);
                u.CarType = chargestandard.CarType;
                u.WeightMin = chargestandard.WeightMin;
                u.WeightMax = chargestandard.WeightMax;
                u.Ratio = chargestandard.Ratio;
                u.Remark = chargestandard.Remark;
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
                var u = db.chargestandard.Find(id);
                db.chargestandard.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_ChargeStandard> List()
        {
            return db.chargestandard.ToList();
        }
        public List<t_ChargeStandard> PageList(int PageIndex, int PageSize)
        {
            List<t_ChargeStandard> li = new List<t_ChargeStandard>();
            return li;
        }
        public t_ChargeStandard Find(int id)
        {
            return db.chargestandard.Find(id);
        }
    }
}
