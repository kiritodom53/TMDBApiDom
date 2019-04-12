using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public class MediaType
    {
        public string type { get; set; }
        public static MediaType ALL = new MediaType("all");
        public static MediaType MOVIE = new MediaType("movie");
        public static MediaType TV = new MediaType("tv");
        public static MediaType PERSON = new MediaType("person");

        public MediaType(string type)
        {
            this.type = type;
        } 
    }
}
