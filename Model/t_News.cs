using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class t_News
    {
        [Key]
        public int id { get; set; }
        [Required]
        [DisplayName("标题")]
        public string Title { get; set; }
        [Required]
        [DisplayName("内容")]
        public string Content { get; set; }
        [Required]
        [DisplayName("发布人")]
        public string PublishPerson { get; set; }
        [Required]
        [DisplayName("发布时间")]
        public DateTime PublishDate { get; set; }
        [Required]
        [DisplayName("接收人")]
        public string ReceivePerson { get; set; }
        [Required]
        [DisplayName("是否已读")]
        public int IsRead { get; set; }
    }
}
