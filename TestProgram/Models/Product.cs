using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProgram.Models
{
    public class Product
    {
        [StringLength(5, ErrorMessage = "{0}的长度不能大于{1}个字符")]
        [Display(Name = "姓名")]
        public string Name { get; set; }

        [Display(Name = "价格")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "请输入价格")]
        [Range(100, 20000, ErrorMessage = "输入的价格只能在100元到2万元之间")]
        [RegularExpression(@"^[1-9]\d*$", ErrorMessage = "转入的价格必须为整数")]
        public string Price { get; set; }

        public string Number { get; set; }

        public string ddl_sss { get; set; }

    }
}