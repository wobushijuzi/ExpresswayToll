using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_RoleToMenu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("角色Id")]
        public int RoleId { get; set; }
        [Required]
        [DisplayName("菜单Id")]
        public int MenuId { get; set; }
    }
}
