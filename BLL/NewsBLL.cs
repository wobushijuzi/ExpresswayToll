using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NewsBLL
    {
        NewsDAL newsDAL = new NewsDAL();
        public bool Add(t_News news)
        {
            //t_News news = new t_News()
            //{
            //    CardId = CardId,
            //    CarId = "鲁D0000001",
            //    news = "七座一下客车",
            //    Inbound = "收费口1",
            //    InboundTime = DateTime.Now,

            //};

            return newsDAL.Add(news);
        }
        public bool Del(int id)
        {
            return newsDAL.Del(id);
        }
        public bool Edit(t_News news)
        {
            return newsDAL.Edit(news);
        }
        public t_News Find(int id)
        {
            return newsDAL.Find(id);
        }
        public IEnumerable<t_News> List()
        {
            return newsDAL.List();
        }
    }
}
