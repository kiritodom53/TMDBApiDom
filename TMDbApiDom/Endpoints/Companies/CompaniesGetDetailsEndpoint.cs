using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Companies
{
    public class CompaniesGetDetailsEndpoint : Endpoint
    {
        public CompaniesGetDetailsEndpoint(int company_id) : base("company", company_id.ToString()) { }
    }
}
