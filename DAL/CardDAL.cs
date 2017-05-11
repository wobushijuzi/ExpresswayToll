using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CardDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();        
        public bool Add(t_Card card)
        {
            
            try
            {
                db.card.Add(card);
                db.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        public bool Edit(string Id, string CarId, string CarType)
        {
            try
            {
                var u = db.card.Where(c=>c.CardId==Id).ToList().FirstOrDefault();                
                u.CarId = CarId;
                u.CarType = CarType;
                u.Inbound = "山亭收费站";
                u.InboundTime = DateTime.Now;
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
                var u = db.card.Find(id);
                db.card.Remove(u);
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_Card> List()
        {
            return db.card.ToList();
        }
        public List<t_Card> PageList(int PageIndex, int PageSize)
        {
            List<t_Card> li = new List<t_Card>();
            return li;
        }
        public t_Card Find(int id)
        {
            return db.card.Find(id);
        }
    }
}
