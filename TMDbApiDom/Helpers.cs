using System;
using System.Collections.Generic;
using System.Text;

namespace TMDbApiDom
{
    public static class Helpers
    {
        public static string EncodeDictionary(Dictionary<string, string> dataDict)
        {
            StringBuilder sb = new StringBuilder();

            foreach (KeyValuePair<string, string> entry in dataDict)
            {
                sb.Append(entry.Key).Append("=").Append(entry.Value).Append("&");
            }

            sb.Remove(sb.Length - 1, 1);

            return sb.ToString();
        }
    }
}
