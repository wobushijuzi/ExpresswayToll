using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_User
    {
        [Key]
        public  int id { get; set; }
        [Required(ErrorMessage ="用户名不能为空")]
        [DisplayName("用户名")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "密码不能为空")]
        [DisplayName("密码")]
        public byte[] Password { get; set; }
        [Required(ErrorMessage = "生日不能为空")]
        [DisplayName("生日")]
        public DateTime Birthday { get; set; }
        [Required(ErrorMessage = "性别不能为空")]
        [DisplayName("性别")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "联系方式不能为空")]
        [DataType(DataType.PhoneNumber)]
        [DisplayName("联系方式")]
        public string Phone { get; set; }
        [DisplayName("邮箱")]
        [DataType(DataType.EmailAddress)]
        public string Emain { get; set; }
        [DisplayName("QQ号")]
        public string QQ { get; set; }
        [Required]
        [DisplayName("创建时间")]
        public DateTime CreateTime { get; set; }
        [DisplayName("是否停用")]
        public int Disadle { get; set; }
        [DisplayName("是否删除")]
        public int IsDel { get; set; }

        public ICollection<t_UserToRole> role { get; set; }
        public ICollection<t_Duty> duty { get; set; }
        public ICollection<t_Charge> charge { get; set; }
    }
}
