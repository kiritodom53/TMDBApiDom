using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbApiDom.Dto.Movies;
using TMDbApiDom.Dto.Trending;

namespace TMDbApiDom.Dto.SidewayClasses.WrapperClasses
{
    public class ResultObject<T>
    {
        public int id { get; set; }
        public int page { get; set; }
        public T[] results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }

        /*public static implicit operator ResultObject<T>(ResultObject<SimilarMovie> v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator ResultObject<T>(ResultObject<TrendingMovie> v)
        {
            throw new NotImplementedException();
        }*/
    }
}
