using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Endpoints
{
    public class Endpoint
    {
        private string[] parts;

        public Endpoint(params string[] parts)
        {
            this.parts = parts;
        }

        public string GetUrl()
        {
            return String.Join("/", this.parts);
        }
    }
}
