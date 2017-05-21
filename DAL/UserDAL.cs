using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAL
{
    public class UserDAL
    {
        ExpresswayTollContext db = new ExpresswayTollContext();
        public int Login(string username, byte[] password)
        {
            int i = 0;
            i = db.user.Where(c => c.UserName == username && c.Password == password).ToList().Count();
            //db.cartype.Add(new t_CarType {
            //    CarType="7坐以下客车"
            //});
            //db.SaveChanges();
            return i;
        }
        public bool AddUser(t_User user,int roleId)
        {

            // db.user.Add(user);
            var role = db.role.Find(roleId);
            db.utr.Add(new t_UserToRole
            {
                user=user,
                role=role
            });
            
            try
            {
                db.SaveChanges();
                //if (AddRole(user.UserName,roleId))
                //{
                    return true;
                //}
                //else
                //{
                //    return false;
                //}
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool Edit(t_User user,int RoleId)
        {
            try
            {
                var u = db.user.Find(user.id);
                u.UserName = user.UserName;
                u.Password = user.Password;
                u.Birthday = user.Birthday;
                u.Gender = user.Gender;
                u.Phone = user.Phone;
                u.Emain = user.Emain;
                u.QQ = user.QQ;
                u.Disadle = user.Disadle;
                u.IsDel = user.IsDel;
                var r = db.utr.Where(c=>c.user.id==user.id).FirstOrDefault();
                r.role = db.role.Find(RoleId);
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
                // db.user.Remove(db.user.Find(id));
                var u=db.user.Find(id);
                u.IsDel = 1;
                db.SaveChanges();
                return true;

            }
            catch (Exception)
            {
                return false;
            }
        }
        public List<t_User> List()
        {
            return db.user.Where(c=>c.IsDel==0).ToList();
        }
        public List<t_User> PageList(int PageIndex,int PageSize)
        {
            List<t_User> li = new List<t_User>();

            return li;
        }
        public t_User Find(int id)
        {
            return db.user.Find(id);
        }
    }
}
