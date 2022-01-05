using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectB6SOAC
{
    public class Trace
    {
        public List<string> TipBranch { get; set; }
        public List<int> PC { get; set; }
        public List<int> AdrDest { get; set; }
        public int Length { get; set; }
        public string Name { get; set; }

        public Trace()
        {
            TipBranch = new List<string>();
            PC = new List<int>();
            AdrDest = new List<int>();    
            Length = 0;
        }
    }
}
