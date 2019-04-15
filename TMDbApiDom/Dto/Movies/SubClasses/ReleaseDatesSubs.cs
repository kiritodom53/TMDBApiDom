using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.Movies.SubClasses
{
    public class ReleaseDatesSubs
    {
        public string certification { get; set; }
        public string iso_639_1 { get; set; }
        public string release_date { get; set; }
        public int type { get; set; }
        public string note { get; set; }
    }
}
