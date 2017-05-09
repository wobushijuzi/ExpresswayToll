using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_TollGate
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("收费站名称")]
        public string TollGate { get; set; }
        [Required]
        [DisplayName("收费站位置")]
        public string Loction { get; set; }
        [Required]
        [DisplayName("进出口数量")]
        public int Count { get; set; }
        public virtual t_Road road { get; set; }
    }
}
