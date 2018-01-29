using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UrlsAndRoutes.Models
{
    public class Result
    {
        public string Controller { get; set; }
        public string Action { get; set; }
        public string Id { get; set; }
        public IDictionary<string, object> Data { get; private set; } = new Dictionary<string, object>();
    }
}
