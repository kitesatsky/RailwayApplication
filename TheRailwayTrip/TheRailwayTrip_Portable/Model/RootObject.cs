using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheRailwayTrip_Portable.Model
{
    public class RootObject
    {
        public BoardingPoint boarding_point { get; set; }
        public bool chart_prepared { get; set; }
        public ToStation to_station { get; set; }
        public string doj { get; set; }
        public Train train { get; set; }
        public int total_passengers { get; set; }
        public ReservationUpto reservation_upto { get; set; }
        public string pnr { get; set; }
        public FromStation from_station { get; set; }
        public List<Passenger> passengers { get; set; }
        public int debit { get; set; }
        public int response_code { get; set; }
        public JourneyClass journey_class { get; set; }
    }
}
