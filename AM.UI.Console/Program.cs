// See https://aka.ms/new-console-template for more information
using AM.ApplicationCore;
using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Services;

Passenger P1 = new Passenger
{
    FirstName = "jawher",
    LastName = "jaziri",
    EmailAddress = "jaouher.jazrii@esprit.tn"
};
P1.UpperFullName();
Console.WriteLine("name"+P1.FirstName+" "+P1.LastName);

Staff S1 = new Staff { FirstName = "ahmed", LastName = "staff", EmailAddress = "" };
Traveller T1 = new Traveller { FirstName = "mohamed", LastName = "T", EmailAddress = "Mohamed@gamil" };
//P1.PassengerType();
//S1.PassengerType();
//T1.PassengerType();
//Console.WriteLine(P1.CheckProfile("jawher", "jaziri"));
//Console.WriteLine(P1.CheckProfile("jawher", "jaziri", "jawher@gamil.com"));

//Console.WriteLine("Hello, World!");
//Plane plane = new Plane();

//plane.PlanType = "Airbus";
//plane.capacity = 200;
//plane.ManyfactureDate = new DateTime(2018, 11, 10);
//Plane plane3 = new Plane();








//Console.WriteLine(plane.ToString());

Plane BoingPlane = new Plane { PlaneType = PlaneType.Boing, Capacity = 150, ManufactureDate = new DateTime(2015, 02, 03) };

ServiceFlight Sf=new ServiceFlight();
Sf.Flights = TestData.listFlights;
Sf.ShowFlightDetails(BoingPlane);
//Console.WriteLine("Display Flight date to madrid");
//foreach (var item in Sf.GetFlightDates("Madrid"))
//{
//    Console.WriteLine(item);
//}
//Sf.GetFlights("Destination", "Paris");
