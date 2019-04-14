using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Account
{
    public class AccountGetCreatedListsEndpoint : Endpoint
    {
        public AccountGetCreatedListsEndpoint(int account_id) : base("account", account_id.ToString(), "lists") { }
    }
}
