using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom
{
    namespace Dto
    {
        public class Movie
        {
            public bool adult { get; set; }
            public string backdrop_path { get; set; }
            //public int belongs_to_collection { get; set; } // null or object
            public int budget { get; set; }
            public Genre[] genres { get; set; }
            public string homepage { get; set; }
            public int id { get; set; }
            public string imbd_id { get; set; }
            public string original_language { get; set; }
            public string original_title { get; set; }
            public string overview { get; set; }
            public double popularity { get; set; }
            public string poster_path { get; set; }
            //production_companies // vytvořit třídu
            //production_countries
            public string release_date { get; set; }
            public int revenue { get; set; }
            public int runtime { get; set; }
            public int MyProperty { get; set; }
            //spoken_languages
            public string status { get; set; }
            public string tagline { get; set; }
            public string title { get; set; }
            public bool video { get; set; }
            public double vote_average { get; set; }
            public int vote_count { get; set; }


            public VideosWrapper videos { get; set; }
            public ImagesWrapper images { get; set; }

            public override string ToString()
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendFormat("Title: {0}\n", title);
                string gns = "  Genres: ";

                foreach (var item in genres)
                {
                    gns += item.name + ", ";
                }

                gns = gns.Remove(gns.Length - 2);
                sb.AppendFormat("{0}\n", gns);
                return sb.ToString();
            }
        }
    }
}
