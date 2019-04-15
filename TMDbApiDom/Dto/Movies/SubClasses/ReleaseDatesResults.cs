using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.Movies.SubClasses
{
    public class ReleaseDatesResults
    {
        public string iso_3166_1 { get; set; }
        public ReleaseDatesSubs[] release_dates { get; set; }
    }
}
