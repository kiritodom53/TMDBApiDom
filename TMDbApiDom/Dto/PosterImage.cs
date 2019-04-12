using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public class PosterSize : ImageSize
    {
        public static PosterSize W92 = new PosterSize("w92");
        public static PosterSize W154 = new PosterSize("w154");
        public static PosterSize W185 = new PosterSize("w185");
        public static PosterSize W342 = new PosterSize("w342");
        public static PosterSize W500 = new PosterSize("w500");
        public static PosterSize W700 = new PosterSize("w700");
        public static PosterSize ORIGINAL = new PosterSize("original");

        public PosterSize(string size) : base(size)
        {
        }
    }

    public class PosterImage : Image<PosterSize>
    {
    }
}
