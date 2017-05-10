using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoadBLL
    {
        RoadDAL roadDAL = new RoadDAL();
        public bool Add(t_Road road)
        {
            //t_Road road = new t_Road()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    road = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return roadDAL.Add(road);
        }
        public bool Del(int id)
        {
            return roadDAL.Del(id);
        }
        public bool Edit(t_Road road)
        {
            return roadDAL.Edit(road);
        }
        public t_Road Find(int id)
        {
            return roadDAL.Find(id);
        }
        public IEnumerable<t_Road> List()
        {
            return roadDAL.List();
        }
    }
}
