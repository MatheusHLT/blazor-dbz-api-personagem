using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorDbzPersonagem.Models
{
    public class Dbz
    {
    public int? id { get; set; }
    public string? name { get; set; }
    public OriginPlanet? originPlanet { get; set; }
    public List<Transformation>? transformations { get; set; }
    }

    public class OriginPlanet
    {
        public string? name { get; set; }
    }

    public class Transformation
    {
        public string? name { get; set; }
        public string? ki { get; set; }
    }
}