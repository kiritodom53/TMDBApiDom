using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public class ErrorObject
    {
        public int status_code { get; set; }
        public string status_message { get; set; }
    }
}
