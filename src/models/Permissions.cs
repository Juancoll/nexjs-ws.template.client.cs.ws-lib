using System;
using System.Collections.Generic;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace tradin.api.wsclient 
{
    public class Permissions 
    {
        public string all { get; set; }
        public List<DataModelRef<string>> players { get; set; }
    }
}