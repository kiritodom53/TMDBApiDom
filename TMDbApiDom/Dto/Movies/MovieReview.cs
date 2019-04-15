using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.Movies
{
    public class MovieReview
    {
        public string id { get; set; }
        public string author { get; set; }
        public string content { get; set; }
        public string url { get; set; }
    }
}
