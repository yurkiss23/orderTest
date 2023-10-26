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
        public string Mark { get; set; }
        public int Thikness { get; set; }
        public double Amount { get; set; }
        public int Pack { get; set; }
        public override string ToString() { return Mark + ", " + Thikness + ", " + Amount + ", " + Pack; }
    }
}
