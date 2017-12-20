using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRailwayTrip_Portable.Model
{
    public class Train
    {
        public string number { get; set; }
        public List<object> days { get; set; }
        public string name { get; set; }
        public List<object> classes { get; set; }
    }
}
