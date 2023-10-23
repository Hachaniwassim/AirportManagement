using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing,
        Airbus
    }
    public class Plane 
    {
        public Plane()
        {
        }

        //public Plane(ICollection<Flight> flights, int capacity, DateTime manyfactureDate, string planed, string planType)
        //{
        //    this.flights = flights;
        //    this.Capacity = capacity;
        //    ManufactureDate = manyfactureDate;
        //    Planed = planed;
        //    PlaneType = planType;
        //}
        public int PlaneId { get; set; }
        public virtual ICollection<Flight> flights { get; set; }
        [Range(0,int.MaxValue)]
        public int Capacity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public string Planed { get; set; }
        public PlaneType PlaneType { get; set; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
    
}
