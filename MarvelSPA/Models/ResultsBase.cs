using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelSPA.Models
{
    public class ResultsBase
    {
        public int id { get; set; }
        public string modified { get; set; }
        public string description { get; set; }
        public string resourceURI { get; set; }
    }
}