using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.Movies.SubClasses;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Movies
{
    public class MovieKeywords
    {
        public int id { get; set; }
        public Keywords[] keywords { get; set; }
    }
}
