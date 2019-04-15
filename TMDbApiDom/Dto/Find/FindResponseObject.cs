using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.Find
{
    public class FindResponseObject<T>
    {
        public T[] movie_results { get; set; }
        public T[] person_results { get; set; }
        public T[] tv_results { get; set; }
    }
}
