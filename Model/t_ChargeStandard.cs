using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_ChargeStandard
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("车辆类型")]
        public string CarType { get; set; }
        [Required]
        [DisplayName("重量范围起点(吨)")]
        public double WeightMin { get; set; }
        [Required]
        [DisplayName("重量范围终点(吨)")]
        public double WeightMax { get; set; }
        [Required]
        [DisplayName("收费比例/Km")]
        public double Ratio { get; set; }
        [Required]
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}
