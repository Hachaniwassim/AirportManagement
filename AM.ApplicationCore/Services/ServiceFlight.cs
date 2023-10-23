using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
   public class ServiceFlight:IServiceFlight
    {
        public List<Flight> Flights { get; set; }=new List<Flight>();

        //public List<DateTime> GetFlightDates(string destination)
        //{
        //    List<DateTime> listFlight = new List<DateTime>();
        //    //for(int i = 0; i < Flights.Count; i++)
        //    //{
        //    //    if (Flights[i].Destination == destination)
        //    //        listFlight.Add(Flights[i].FlightDate);
        //    //}
        //    foreach(var flight in Flights)
        //    {
        //        if (flight.Destination == destination)
        //            listFlight.Add(flight.FlightDate);
        //    }
        //    return listFlight;
        //}
        public List<DateTime> GetFlightDates(string destination)
        {
            
            IEnumerable<DateTime> listFlight = from F in Flights where (F.Destination == destination) select F.FlightDate;
           // IEnumerable<DateTime> list=Flights.Where(f => f.Destination == destination).Select(f => f.FlightDate); ;
            return  listFlight.ToList();
        }
        public void ShowFlightDetails(Plane plane)
        {
            var Query = from f in Flights where (f.Plane == plane) select new { f.Destination, f.FlightDate };
            var Query2=Flights.Where(f =>f.Plane == plane).Select(f => new {f.Destination, f.FlightDate});
            foreach(var f in Query)
            {
                Console.WriteLine("Destination"+f.Destination
                    +"Flight Date"+f.FlightDate);
            }
        }
        public int ProgrammedFlightNumber(DateTime startDate)
        {
            var Query = from f in Flights where DateTime.Compare(f.FlightDate,startDate) > 0 && (f.FlightDate - startDate).TotalDays <= 7 select f;
            var Query2 = Flights.Where(f => DateTime.Compare(f.FlightDate, startDate) > 0 && (f.FlightDate - startDate).TotalDays < 7);
            return Query.Count();

        }
        public double DurationAverage(string destination)
        {
            var Query = (from f in Flights where f.Destination == destination select f.EstimatedDuration ).Average();

            var Query2=Flights.Where(f =>f.Destination==destination).Select(f => f.EstimatedDuration).Average();
            return Query;

        }
        public List<Flight> OrderedDurationFlights()
        {
            var Query = from f in Flights orderby f.EstimatedDuration descending select f;
            var Query2=Flights.OrderByDescending(f => f.EstimatedDuration);
            return Query.ToList();
        }
        public IEnumerable<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
            var query=from f in Flights group f by f.Destination;
            var query2=Flights.GroupBy(f => f.Destination);
            foreach (var grouping in query)
            {
                Console.WriteLine("Destination" + grouping.Key);
                foreach(var flight in grouping)
                {
                    Console.WriteLine("Decollage" + flight.FlightDate);
                }
            }
            return query;
        }
        public List<Traveller> SeniorTravellers(Flight flight)
        {
            var Query=from p in flight.passengers.OfType<Traveller>() orderby p.BirthDate select p;
            var Query2 = flight.passengers.OfType<Traveller>().OrderBy(p => p.BirthDate);

            return Query.Take(3).ToList();
        }
                    
        public void GetFlights(string filterType, string filterValue)
        {
            switch(filterType)
            {
                case "Destination":
                    foreach(var flight in Flights)
                    {
                        if(flight.Destination==filterValue)
                            Console.WriteLine(flight.ToString());
                    }
                    break;
                case "FlightDate":
                    foreach(var flight in Flights)
                    {
                        if (flight.FlightDate == DateTime.Parse(filterValue))
                            Console.WriteLine(flight.ToString());

                    }
                    break;
                case "EffectiveArrival":
                    foreach (var flight in Flights)
                    {
                        if (flight.EffectiveArrival == DateTime.Parse(filterValue))
                            Console.WriteLine(flight.ToString());

                    }
                    break;
                default:Console.WriteLine("vole non trouve");
                    break;
            }
        }
    }
}
