using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using System.Security.Cryptography;

namespace BLL
{
    public class UserBLL
    {
        UserDAL userinfo = new UserDAL();
        public bool Login(string UserName, byte[] Password)
        {
           
            int result = userinfo.Login(UserName, Password);
            if (result == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #region 修改
        public bool Edit(t_User user)
        {
            return userinfo.Edit(user);
        }
        #endregion
        #region 删除
        public bool Del(int id)
        {
            return userinfo.Del(id);
        }
        #endregion
        #region AddUser
        public bool AddUser(t_User user,int roleId)
        {
           // user.Password = secret(user.Password);
            return userinfo.AddUser(user, roleId);
        }
        #endregion
        #region 查询全部 
        public List<t_User> list()
        {
            return userinfo.List();
        }
        #endregion
        #region 查询某个
        public t_User Find(int id)
        {
            return userinfo.Find(id);
        }
        #endregion
    }
}
