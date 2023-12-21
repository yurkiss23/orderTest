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
        public orderModel(int c, headModel hd, int stor, List<epsModel> eps, List<addModel> add) { Clients = c; Hd = hd; Storages = stor; Eps = eps; Add = add; }

        public int Clients { get; set; }
        public headModel Hd { get; set; }
        public int Storages { get; set; }
        public List<epsModel> Eps { get; set; }
        public List<addModel> Add { get; set; }

        public override string ToString() => Clients.ToString() + ", " + Hd.ToString() + ", " + Storages.ToString() + ", " + Eps.ToString() + ", " + Add.ToString();
    }
}
