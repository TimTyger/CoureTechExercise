using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2.Common
{
    public class ErrorResp
    {
        public string Message { get; set; } = "unknown error";
        public string ResponseCode { get; set; } = "500";

    }
}
