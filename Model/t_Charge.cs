using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_Charge
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("卡编号")]
        public string CardId { get; set; }
        [Required]
        [DisplayName("车牌号")]
        public string CarId { get; set; }
        [Required]
        [DisplayName("车辆类型")]
        public string CarType { get; set; }
        [Required]
        [DisplayName("进站口")]
        public string Inbound { get; set; }
        [Required]
        [DisplayName("进站时间")]
        public DateTime InboundTime { get; set; }
        [Required]
        [DisplayName("出站口")]
        public string Outbound { get; set; }
        [Required]
        [DisplayName("出站时间")]
        public DateTime OutboundTime { get; set; }
        [Required]
        [DisplayName("金额")]
        public double Charge { get; set; }
        [Required]
        [DisplayName("收费人")]
        public virtual t_User DutyPerson { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }

    }
}
