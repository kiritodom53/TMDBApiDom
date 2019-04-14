using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Reviews
{
    public class ReviewsGetDetailsEndpoint : Endpoint
    {
        public ReviewsGetDetailsEndpoint(int review_id) : base("review", review_id.ToString()) { }
    }
}
