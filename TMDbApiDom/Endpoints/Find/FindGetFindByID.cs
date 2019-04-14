using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom.Endpoints.Find
{
    public class FindGetFindByID : Endpoint
    {
        public FindGetFindByID(int external_id) : base("find", external_id.ToString()) { }
    }
}
