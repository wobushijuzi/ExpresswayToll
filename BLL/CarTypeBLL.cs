using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CarTypeBLL
    {
        CarTypeDAL cardtypeDAL = new CarTypeDAL();
        public bool Add(t_CarType cartype)
        {
            //t_CarType cartype = new t_CarType()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    CarType = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return cardtypeDAL.Add(cartype);
        }
        public bool Del(int id)
        {
            return cardtypeDAL.Del(id);
        }
        public bool Edit(t_CarType cartype)
        {
            return cardtypeDAL.Edit(cartype);
        }
        public t_CarType Find(int id)
        {
            return cardtypeDAL.Find(id);
        }
        public IEnumerable<t_CarType> List()
        {
            return cardtypeDAL.List();
        }
    }
}
