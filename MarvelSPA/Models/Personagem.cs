using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarvelSPA.Models
{
    public class Personagem : ResultsBase
    {
        public string name { get; set; }
        public Thumbnail thumbnail { get; set; }
    }
}