using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Account
{
    public class AccountGetMovieWatchlistEndpoint : Endpoint
    {
        public AccountGetMovieWatchlistEndpoint(int account_id) : base("account", account_id.ToString(), "watchlist", "movies") { }
    }
}
