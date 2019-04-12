using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public class Person
    {
        public string name { get; set; }
        public string[] also_known_as { get; set; }
    }
}
