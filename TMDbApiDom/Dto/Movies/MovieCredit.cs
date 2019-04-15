using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.Movies.SubClasses;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Movies
{
    public class MovieCredit
    {
        public int id { get; set; }
        public Cast[] cast { get; set; }
        public Crew[] crew { get; set; }
    }
}
