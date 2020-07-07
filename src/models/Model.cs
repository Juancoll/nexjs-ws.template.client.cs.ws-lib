using System;
using System.Collections.Generic;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace tradin.api.wsclient 
{
    public class Model 
    {
        public string _type { get; set; }
        public string _id { get; set; }
        public bool enabled { get; set; }
        public long createdAt { get; set; }
        public long updatedAt { get; set; }
        public List<ModelComponent> components { get; set; }
    }
}