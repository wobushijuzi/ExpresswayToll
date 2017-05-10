using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChargeStandardBLL
    {
        ChargeStandardDAL chargestandarddal = new ChargeStandardDAL();
        public bool Add(t_ChargeStandard chargestandard)
        {
            //t_ChargeStandard chargestandard = new t_ChargeStandard()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    chargestandard = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return chargestandarddal.Add(chargestandard);
        }
        public bool Del(int id)
        {
            return chargestandarddal.Del(id);
        }
        public bool Edit(t_ChargeStandard chargestandard)
        {
            return chargestandarddal.Edit(chargestandard);
        }
        public t_ChargeStandard Find(int id)
        {
            return chargestandarddal.Find(id);
        }
        public IEnumerable<t_ChargeStandard> List()
        {
            return chargestandarddal.List();
        }
    }
}
