using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public abstract class ImageSize
    {
        public string size { get; }

        protected ImageSize(string size)
        {
            this.size = size;
        }
    }
}
