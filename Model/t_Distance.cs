using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_Distance
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("节点开始")]
        public string Start { get; set; }
        [Required]
        [DisplayName("节点结束")]
        public string End { get; set; }
        [Required]
        [DisplayName("距离")]
        public double Distance { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
       
    }
}
