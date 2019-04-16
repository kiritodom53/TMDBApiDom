using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.SidewayClasses.SubClasses
{ 
    public class Changes<T>
    {
        public string key { get; set; }
        public T[] items { get; set; }
    }
}
