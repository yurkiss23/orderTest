using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderTest.models
{
    public class addModel
    {
        public addModel() { }
        public addModel(string[] add) { Name = add[0]; Amount = int.Parse(add[2]); Meter = add[1]; }

        public string Name {  get; set; }
        public int Amount {  get; set; }
        public string Meter {  get; set; }

        public override string ToString() => Name + ", " + Amount.ToString() + ", " + Meter;
    }
}
