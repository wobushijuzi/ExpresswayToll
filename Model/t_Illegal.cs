using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_Illegal
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("车牌号")]
        public string CarId { get; set; }
        [Required]
        [DisplayName("违章内容")]
        public string Illegal { get; set; }
        [Required]
        [DisplayName("违章时间")]
        public DateTime IllegalTime { get; set; }
        [Required]
        [DisplayName("违章地点")]
        public string IllegalPosition { get; set; }
        [Required]
        [DisplayName("备注")]
        public string Remark { get; set; }
    }
}
