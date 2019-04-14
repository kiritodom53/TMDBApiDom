using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Account
{
    public class AccountGetRatedTvShows : Endpoint
    {
        public AccountGetRatedTvShows(int account_id) : base("account", account_id.ToString(), "rated", "tv") { }
    }
}
