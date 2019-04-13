using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto.SidewayClasses.SubClasses { 
    public class ImagesWrapper
    {
        public BackdropImage[] backdrops { get; set; }
        public PosterImage[] posters { get; set; }
        public int id { get; set; }
    }

}
