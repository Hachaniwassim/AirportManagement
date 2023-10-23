using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AM.ApplicationCore.Domain
{
    public class Staff :Passenger
    {
        //public Staff(DateTime employmentDate, string function, float salary)
        //{
        //    EmploymentDate = employmentDate;
        //    Function = function;
        //    Salary = salary;
        //}

        public DateTime EmployementDate { get; set; }
        public string Function { get; set; }

        [DataType(DataType.Currency)]
        public float Salary { get; set; }
       
        public override void PassengerType()
        {
            Console.WriteLine("Im a staff");
        }
    }
}
