using System;
using System.Collections.Generic;
using System.Text;

namespace DATA.Errors
{
    public class GetResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Token { get; set; }
        public object Result { get; set; }
    }
}
