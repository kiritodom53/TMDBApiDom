﻿using System;
using System.Collections.Generic;
using System.Text;
using TMDbApiDom.Dto.Movies.SubClasses;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Movies
{
    public class MovieChanges<T>
    {
        public T[] changes { get; set; }
    }
}
