using System;
using System.Collections.Generic;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace tradin.api.wsclient 
{
    public class ModelComponent 
    {
        public string _type { get; set; }
        public JToken data { get; set; }
    }
}