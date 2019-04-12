using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public abstract class Image<T> where T : ImageSize
    {
        public double aspect_ratio { get; set; }
        public string file_path { get; set; }
        public int height { get; set; }
        public string iso_639_1 { get; set; } // null or string
        public double vote_average { get; set; }
        public int vote_count { get; set; }
        public int width { get; set; }

        /// <summary>
        /// URL img adress
        /// </summary>
        /// <param name="imgSize">img size</param>
        /// <returns>url by size</returns>
        public string GetImgUrl(T imgSize)
        {
            return "https://image.tmdb.org/t/p/" + imgSize.size + this.file_path;
        }
    }
}
