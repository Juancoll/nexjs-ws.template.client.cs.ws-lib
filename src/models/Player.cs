using System;
using System.Collections.Generic;
using Newtonsoft;
using Newtonsoft.Json.Linq;

namespace tradin.api.wsclient 
{
    public class Player: Model 
    {
        public string name { get; set; }
        public string label { get; set; }
        public string serial { get; set; }
        public ModelRef owner { get; set; }
    }
}