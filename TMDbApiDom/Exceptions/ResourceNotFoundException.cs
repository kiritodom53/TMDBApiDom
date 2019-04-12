using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Exceptions
{
    public class ResourceNotFoundException : Exception
    {
        public ResourceNotFoundException(string msg) : base(msg)
        {

        }
    }
}
