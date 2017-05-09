using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_CarType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("车辆类型")]
        public string CarType { get; set; }
    }
}
