using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TollGateBLL
    {
        TollGateDAL tollgateDAL = new TollGateDAL();
        public bool Add(t_TollGate tollgate)
        {
            //t_TollGate tollgate = new t_TollGate()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    tollgate = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return tollgateDAL.Add(tollgate);
        }
        public bool Del(int id)
        {
            return tollgateDAL.Del(id);
        }
        public bool Edit(t_TollGate tollgate)
        {
            return tollgateDAL.Edit(tollgate);
        }
        public t_TollGate Find(int id)
        {
            return tollgateDAL.Find(id);
        }
        public IEnumerable<t_TollGate> List()
        {
            return tollgateDAL.List();
        }
    }
}
