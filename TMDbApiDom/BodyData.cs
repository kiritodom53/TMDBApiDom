using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TMDbApiDom
{
    public class BodyData : Dictionary<string, string>
    {
        public StringContent GetStringContent()
        {
            return new StringContent(JsonConvert.SerializeObject(this, Formatting.Indented), Encoding.UTF8, "application/json");
        }
    }
}
