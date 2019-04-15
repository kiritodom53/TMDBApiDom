using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.Movies.SubClasses
{ 
    public class Changes
    {
        public string key { get; set; }
        public Items[] items { get; set; }
    }
}
