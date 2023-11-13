using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace orderTest.models
{
    public class epsModel
    {
        public epsModel() { }
        public epsModel(string[] eps) { Mark = eps[0]; Thikness = int.Parse(eps[1]); Amount = double.Parse(eps[2]); Pack = int.Parse(eps[3]); }

        public string Mark { get; set; }
        public int Thikness { get; set; }
        public double Amount { get; set; }
        public int Pack { get; set; }

        public override string ToString() => Mark + ", " + Thikness.ToString() + ", " + Amount.ToString() + ", " + Pack.ToString();
    }
}
