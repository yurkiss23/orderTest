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
            Date = DateTime.Parse(head[0]); Number = int.Parse(head[1]); Client = head[2]; Mark = head[3]; Vehicle = head[4];// Trailer = bool.Parse(head[5]);
            Driver = head[5]; Address = head[6]; Comment = head[7];
            //Driver = head[6]; Address = head[7]; Comment = head[8];
        }

        public DateTime Date { get; set; }
        public int Number { get; set; }
        public string Client { get; set; }
        public string Mark { get; set; }
        public string Vehicle { get; set; }
        //public bool Trailer { get; set; }
        public string Driver { get; set; }
        public string Address { get; set; }
        public string Comment { get; set; }

        public override string ToString()
        {
            return Date.ToString() + ", " + Number.ToString() 
                + ", " + Client + ", " + Mark + ", " + Vehicle// + ", " + Trailer.ToString() 
                + ", " + Driver + ", " + Address + ", " + Comment;
        }
    }
}
