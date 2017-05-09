using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_Duty
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [DisplayName("值班日期")]
        public string DutyDate { get; set; }
        [Required]
        [DisplayName("值班时间")]
        public string DutyTime { get; set; }
        [Required]
        [DisplayName("值班岗位")]
        public string DutyPositoin { get; set; }
        [Required]
        [DisplayName("值班人")]
        public virtual t_User DutyPerson { get; set; }
    }
}
