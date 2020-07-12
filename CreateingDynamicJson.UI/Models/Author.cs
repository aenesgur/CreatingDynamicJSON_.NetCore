using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CreatingDynamicJson.UI.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Citizen { get; set; }
        public List<Novel> Novels { get; set; }
    }
}
