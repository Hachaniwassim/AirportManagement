using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {

        //public Flight(string destination, string departure, DateTime myProperty, int flightID, DateTime effectiveArrival, int estimetedDuration)
        //{
        //    Destination = destination;
        //    Departure = departure;
        //    MyProperty = myProperty;
        //    this.flightID = flightID;
        //    EffectiveArrival = effectiveArrival;
        //    EstimetedDuration = estimetedDuration;
        //}
        public string Airline { get; set; }
        public virtual ICollection<Passenger> passengers { get; set; }
        
        public string Destination { get; set; }
        public string Departure { get; set; }
        public DateTime MyProperty { get; set; }
        public int flightID { get; set; }

        public int PlaneId { get; set; }
        [ForeignKey("PlaneId")]
        public virtual Plane Plane { get; set; }
        public DateTime EffectiveArrival { get; set;}
        public int EstimatedDuration { get; set; }
        public DateTime FlightDate { get; set; }
        public override string ToString()
        {
            return "FlightDate: " + FlightDate + " Destination: " + Destination + " EstimatedDuration: " + EstimatedDuration;
        }
    }
}
