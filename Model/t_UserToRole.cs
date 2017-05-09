using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_UserToRole
    {
        [Key]
        public int id { get; set; }
        [Required]
        //[DisplayName("用户ID")]
        //public int UserId { get; set; }
        //[Required]
        //[DisplayName("角色ID")]
        //public int RoleId { get; set; }
        public virtual t_Role role { get; set; }
        public virtual t_User user { get; set; }
    }
}
