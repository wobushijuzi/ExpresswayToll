using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_Road
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("公路名称")]
        public string RoadName { get; set; }
        [Required]
        [DisplayName("公路编号")]
        public string RoadNo { get; set; }
        [DisplayName("公路建成时间")]
        public DateTime BuildTime { get; set; }
        [DisplayName("公路承建公司")]
        public string BuildCompany { get; set; }
        [DisplayName("备注")]
        public string Remark { get; set; }
        public ICollection<t_TollGate> tollgate { get; set; }

    }
}
