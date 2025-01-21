using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdminApi
{
    public partial class AdminRequest
    {
        public class Result
        {
            public int Code { get; set; }
            public string? Message { get; set; }
        }

        public class Base
        {
            public Result? Result { get; set; }
        }

        public class SendData : Base
        {
            public int Data { get; set; }
        }
    }
}
