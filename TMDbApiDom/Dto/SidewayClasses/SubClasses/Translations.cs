using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.Movies.SubClasses;

namespace TMDbApiDom.Dto.SidewayClasses.SubClasses
{
    public class Translations<T>
    {
        public int id { get; set; }
        public T[] translations { get; set; }
    }
}
