using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectB6SOAC
{
    public class ResultData
    {
        public double Accuracy { get; set; }
        public string Name { get; set; }
        public int CorrecttlyPredicted { get; set; }
        public int IncorrecttlyPredicted { get; set; }
        public int TakenBranches { get; set; }
        public int NotTakenBranches { get; set; }
    }
}
