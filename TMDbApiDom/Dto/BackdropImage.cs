using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public class BackdropSize : ImageSize
    {
        public static BackdropSize W300 = new BackdropSize("w300");
        public static BackdropSize W780 = new BackdropSize("w780");
        public static BackdropSize W1280 = new BackdropSize("w1280");
        public static BackdropSize ORIGINAL = new BackdropSize("original");

        public BackdropSize(string size) : base(size)
        {
        }
    }

    public class BackdropImage : Image<BackdropSize>
    {
    }
}
