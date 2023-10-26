using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderTest.models
{
    internal class addModel
    {
        public string Name {  get; set; }
        public int Amount {  get; set; }
        public string Meter {  get; set; }
        public override string ToString() { return Name + ", " + Amount + ", " + Meter; }
    }
}
