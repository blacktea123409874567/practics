using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace практика
{
    public class Movy
    {
        public List<string> Junore { get; set; } = new List<string>();
        public string Name { get; set; }

        public string Opisanie { get; set; }

        public override string ToString()
        {
            return $"{Name} - {Opisanie}";
        }
    }
}
