using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderTest.models
{
    internal class headModel
    {
        public DateTime Date { get; set; }
        public string Client { get; set; }
        public string Mark { get; set; }
        public string Vehicle { get; set; }
        public bool Trailer { get; set; }
        public string Driver { get; set; }
        public string Adress { get; set; }
        public string Comment { get; set; }
        public override string ToString()
        {
            return Date + ", " + Client + ", " + Mark + ", " + Vehicle + ", " + Trailer + ", " + Driver + ", " + Adress + ", " + Comment;
        }
    }
}
