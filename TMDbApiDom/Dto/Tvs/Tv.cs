using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMDbApiDom.Dto.SidewayClasses.SubClasses;

namespace TMDbApiDom.Dto.Tvs
{
    public class Tv
    {
        public string backdrop_path { get; set; }
        public CreatedBy[] created_by { get; set; }
        public int[] episode_run_time { get; set; }
        public string first_air_date { get; set; }
        public Genre[] genres { get; set; }
        public string homepage { get; set; }
        public int id { get; set; }
        public bool in_production { get; set; }
        public string[] languages { get; set; }
        public string last_air_date { get; set; }
        //object last_episode_to_air
        public string name { get; set; }
        //null next_episode_to_air
        public Networks[] networks { get; set; }
        public int number_of_episodes { get; set; }
        public int number_of_seasons { get; set; }
        public string[] origin_country { get; set; }
        public string original_language { get; set; }
        public string original_name { get; set; }
        public string overview { get; set; }
        public double popularity { get; set; }
        public string poster_path { get; set; }
        public ProductionCompanies[] production_companie { get; set; }
        public Seasons[] seasons;
        public string status { get; set; }
        public string type { get; set; }
        public double vote_average { get; set; }
        public int vote_count { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("ID: {0} - Title: {1}\n", id, name);
            return sb.ToString();
        }
    }
}
