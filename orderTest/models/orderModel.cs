using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderTest.models
{
    public class orderModel
    {
        public orderModel() { }
        public orderModel(headModel hd, int stor, List<epsModel> eps, List<addModel> add) { Hd = hd; Storage = stor; Eps = eps; Add = add; }

        public headModel Hd { get; set; }
        public int Storage { get; set; }
        public List<epsModel> Eps { get; set; }
        public List<addModel> Add { get; set; }

        public override string ToString() => Hd.ToString() + "," + Storage.ToString() + ", " + Eps.ToString() + ", " + Add.ToString();
    }
}
