using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom.Dto
{
    public class TimeWindow
    {
        public string time { get; set; }
        public static TimeWindow DAY = new TimeWindow("day");
        public static TimeWindow WEEK = new TimeWindow("week");

        public TimeWindow(string time)
        {
            this.time = time;
        }
    }
}
