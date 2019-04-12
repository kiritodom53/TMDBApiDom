using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Exceptions
{
    public class ApiException : Exception
    {
        private int api_code;
        private HttpStatusCode status_code;

        public ApiException(HttpStatusCode status_code, int api_code, string msg) : base(msg)
        {
            this.api_code = api_code;
            this.status_code = status_code;
        }

        public override string ToString()
        {
            return "[" + (int)status_code + "][" + api_code + "]: " + this.Message;
        }
    }
}
