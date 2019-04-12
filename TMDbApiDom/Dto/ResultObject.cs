using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public class ResultObject<T>
    {
        public int page { get; set; }
        public T[] results { get; set; }
        public int total_results { get; set; }
        public int total_pages { get; set; }
    }
}
