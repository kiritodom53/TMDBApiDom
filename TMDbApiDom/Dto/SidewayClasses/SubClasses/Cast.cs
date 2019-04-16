using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Dto.SidewayClasses.SubClasses
{
    public class Cast
    {
        public int cast_id { get; set; }
        public string character { get; set; }
        public string credit_id { get; set; }
        public int gender { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public string profile_path { get; set; }
    }
}
