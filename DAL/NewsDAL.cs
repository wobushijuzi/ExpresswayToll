using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NewsDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public bool Add(t_News news)
        {

            try
            {
                db.news.Add(news);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_News news)
        {
            try
            {
                var u = db.news.Find(news.id);
                u.Content = news.Content;
                u.PublishDate = news.PublishDate;
                u.PublishPerson = news.PublishPerson;
                u.ReceivePerson = news.ReceivePerson;
                u.IsRead = news.IsRead;
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
                var u = db.news.Find(id);
                db.news.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_News> List()
        {
            return db.news.ToList();
        }
        public List<t_News> PageList(int PageIndex, int PageSize)
        {
            List<t_News> li = new List<t_News>();
            return li;
        }
        public t_News Find(int id)
        {
            return db.news.Find(id);
        }
    }
}
