using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PrivateBuilding_LTS.Models
{
    public class New
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name ="發佈日期")]
        [DataType(DataType.DateTime)]
        public int Date { get; set; }

        [Required]
        [Display(Name = "類型")]
        public string Type { get; set; }

        [Required]
        [Display(Name = "公告主旨")]
        public int Title { get; set; }

        [Required]
        [Display(Name = "公告內容")]
        public string Content { get; set; }
    }
}
