using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DATA
{
    public class TokenDTO
    {
        [Key]
        public string Token { get; set; }
    }
}
