using DAL;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace BLL
{
    public class ChargeBLL
    {
        ChargeDAL chargedal = new ChargeDAL();
        UserDAL userdal = new UserDAL();
        public bool Add(string CardId, string CarId, string CarType, String Inbound, DateTime InboundTime, double Charge, string Remark)
        {
            string person = HttpContext.Current.Request.Cookies["UserName"].Value;
            t_User user = userdal.List().Where(c => c.UserName == person).FirstOrDefault();
            t_Charge charge = new t_Charge()
            {
                CardId= CardId,
                CarId =CarId,
                CarType= CarType,
                Inbound= Inbound,
                InboundTime= InboundTime,
                Outbound= "枣庄收费站",
                OutboundTime= DateTime.Now,
                Charge= Charge,
                DutyPerson =user,
                Remark = Remark
            };

            return chargedal.Add(charge);
        }
        public bool Del(int id)
        {
            return chargedal.Del(id);
        }
        //public bool Edit(t_CarType cartype)
        //{
        //    return chargedal.Edit(cartype);
        //}
        public t_Charge Find(int id)
        {
            return chargedal.Find(id);
        }
        public IEnumerable<t_Charge> List()
        {
            return chargedal.List();
        }
    }
}
