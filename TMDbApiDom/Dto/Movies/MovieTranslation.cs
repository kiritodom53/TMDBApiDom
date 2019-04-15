using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Movies
{
    public class MovieTranslation<T>
    {
        public int id { get; set; }
        public T[] translations { get; set; }
    }
}
