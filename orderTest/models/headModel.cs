using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orderTest.models
{
    public class headModel
    {
        public headModel() { }
        public headModel(string[] head)
        {
            Date = DateTime.Parse(head[0]); Number = int.Parse(head[1]); Client = head[2]; MarkV = head[3]; Vehicle = head[4]; Driver = head[5]; Address = head[6]; Comment = head[7];
        }

        public DateTime Date { get; set; }
        public int Number { get; set; }
        public string Client { get; set; }
        public string MarkV { get; set; }
        public string Vehicle { get; set; }
        public string Driver { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

        public override string ToString()
        {
            return Date.ToString() + ", " + Number.ToString() + ", " + Client + ", " + MarkV + ", " + Vehicle + ", " + Driver + ", " + Address + ", " + Comment;
        }
    }
}
