using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class CardBLL
    {
        CardDAL cardDAL = new CardDAL();
        public bool Add(string CardId)
        {
            t_Card card = new t_Card()
            {
                CardId = CardId,
                CarId="鲁D0000001",
                CarType="七座一下客车",
                Inbound="收费口1",
                InboundTime=DateTime.Now,

            };
           
            return cardDAL.Add(card);
        }
        public bool Del(int id)
        {
            return cardDAL.Del(id);
        }
        public bool Edit(string Id, string CarId, string CarType)
        {
            //t_Card card = new t_Card()
            //{

            //};
            return cardDAL.Edit(Id, CarId, CarType);
        }
        public t_Card Find(int id)
        {
            return cardDAL.Find(id);
        }
        public IEnumerable<t_Card> List()
        {
            return cardDAL.List();
        }
    }
}
