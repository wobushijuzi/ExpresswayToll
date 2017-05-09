using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_Role
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("角色名")]
        public string RoleName { get; set; }
        [Required]
        [DisplayName("创建时间")]
        public DateTime CreateTime { get; set; }
       
    }
}
