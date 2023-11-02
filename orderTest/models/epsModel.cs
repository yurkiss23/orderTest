using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace orderTest.models
{
    internal class epsModel
    {
        public epsModel() { }
        public epsModel(string mark, string thikness, string amount, string pack) { Mark = mark; Thikness = int.Parse(thikness); Amount = double.Parse(amount); Pack =int.Parse(pack); }

        public string Mark { get; set; }
        public int Thikness { get; set; }
        public double Amount { get; set; }
        public int Pack { get; set; }

        public override string ToString() { return Mark + ", " + Thikness.ToString() + ", " + Amount.ToString() + ", " + Pack.ToString(); }
    }
}
