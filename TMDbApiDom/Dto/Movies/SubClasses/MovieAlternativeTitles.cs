using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Movies.SubClasses
{
    public class MovieAlternativeTitles
    {
        public int id { get; set; }
        public AlternativeTitleResult[] titles { get; set; }
    }
}
