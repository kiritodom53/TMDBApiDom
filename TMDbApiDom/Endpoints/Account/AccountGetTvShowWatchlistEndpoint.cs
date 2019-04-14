using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Account
{
    public class AccountGetTvShowWatchlistEndpoint : Endpoint
    {
        public AccountGetTvShowWatchlistEndpoint(int account_id) : base("account", account_id.ToString(), "watchlist", "tv") { }
    }
}
