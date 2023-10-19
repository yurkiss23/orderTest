using orderTest.models;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderTest.viewmodels
{
    internal class epsViewModel
    {
        //public epsModel? EPS { get; set; }
        public List<epsModel> EPSList { get; }
        public epsViewModel()
        {
            EPSList = new List<epsModel>()
            {
                new epsModel{Mark = "eps 30", Thikness = 2, Amount = 12.2, Pack = 45}
            };
        }
    }
}
