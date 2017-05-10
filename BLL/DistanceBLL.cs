using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DistanceBLL
    {
        DistanceDAL distanceDAL = new DistanceDAL();
        public bool Add(t_Distance distance)
        {
            //t_Distance distance = new t_Distance()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    distance = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return distanceDAL.Add(distance);
        }
        public bool Del(int id)
        {
            return distanceDAL.Del(id);
        }
        public bool Edit(t_Distance distance)
        {
            return distanceDAL.Edit(distance);
        }
        public t_Distance Find(int id)
        {
            return distanceDAL.Find(id);
        }
        public IEnumerable<t_Distance> List()
        {
            return distanceDAL.List();
        }
    }
}
