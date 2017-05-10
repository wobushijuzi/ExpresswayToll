using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DutyBLL
    {
        DutyDAL dutyDAL = new DutyDAL();
        public bool Add(t_Duty duty)
        {
            //t_Duty duty = new t_Duty()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    duty = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return dutyDAL.Add(duty);
        }
        public bool Del(int id)
        {
            return dutyDAL.Del(id);
        }
        public bool Edit(t_Duty duty)
        {
            return dutyDAL.Edit(duty);
        }
        public t_Duty Find(int id)
        {
            return dutyDAL.Find(id);
        }
        public IEnumerable<t_Duty> List()
        {
            return dutyDAL.List();
        }
    }
}
