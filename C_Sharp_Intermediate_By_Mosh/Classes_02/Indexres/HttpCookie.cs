using System;
using System.Collections.Generic;

namespace C_Sharp_Intermediate_By_Mosh.Classes_02.Indexres
{
    public class HttpCookie
    {
        public DateTime ExpireDate { get; set; }
        private readonly Dictionary<string, string> _dictionary = new Dictionary<string, string>();


        public string this[string key]
        {
            get
            { return _dictionary[key]; }
            set { _dictionary[key] = value; }
        }
    }
}
