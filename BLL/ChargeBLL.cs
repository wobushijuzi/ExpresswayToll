using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChargeBLL
    {
        ChargeDAL chargedal = new ChargeDAL();
        public bool Add(t_Charge charge)
        {
            //t_CarType cartype = new t_CarType()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    CarType = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return chargedal.Add(charge);
        }
        public bool Del(int id)
        {
            return chargedal.Del(id);
        }
        //public bool Edit(t_CarType cartype)
        //{
        //    return chargedal.Edit(cartype);
        //}
        public t_Charge Find(int id)
        {
            return chargedal.Find(id);
        }
        public IEnumerable<t_Charge> List()
        {
            return chargedal.List();
        }
    }
}
