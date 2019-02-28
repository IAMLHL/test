using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestProgram.Models
{
    public class tbt
    {
        public string aaa { get; set; }

        [Display(Name = "价格")]
        public int bbb { get; set; }
        public int ccc { get; set; }
        public int ddd { get; set; }

    }
}