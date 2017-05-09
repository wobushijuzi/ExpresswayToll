using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_Menu
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("菜单名称")]
        public string MenuName { get; set; }
        [Required]
        [DisplayName("控制器")]
        public string Controller { get; set; }
        [Required]
        [DisplayName("行为")]
        public string Action { get; set; }
        [DisplayName("coin")]
        public string Coin { get; set; }
        [Required]
        [DisplayName("父节点")]
        public int Pid { get; set; }
    }
}
