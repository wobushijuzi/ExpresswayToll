using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class IllegalBLL
    {
        IllegalDAL illegalDAL = new IllegalDAL();
        public bool Add(t_Illegal illegal)
        {
            //t_Illegal illegal = new t_Illegal()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    illegal = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return illegalDAL.Add(illegal);
        }
        public bool Del(int id)
        {
            return illegalDAL.Del(id);
        }
        public bool Edit(t_Illegal illegal)
        {
            return illegalDAL.Edit(illegal);
        }
        public t_Illegal Find(int id)
        {
            return illegalDAL.Find(id);
        }
        public IEnumerable<t_Illegal> List()
        {
            return illegalDAL.List();
        }
    }
}
