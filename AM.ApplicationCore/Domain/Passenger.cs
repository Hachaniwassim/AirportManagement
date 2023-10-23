using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        //public Passenger(DateTime birthDate, int passportNumber, string emailAdress, string firstName, string lastName, int telNumber)
        //{
        //    BirthDate = birthDate;
        //    PassportNumber = passportNumber;
        //    EmailAdress = emailAdress;
        //    FirstName = firstName;
        //    LastName = lastName;
        //    TelNumber = telNumber;
        //}
        public bool CheckProfile(string firstname,string lastname)
        {
            return FirstName == firstname && LastName == lastname;
        }
        public bool CheckProfile(string firstname, string lastname,string email)
        {
            return FirstName == firstname && LastName == lastname && EmailAddress == email;
        }
        public virtual void PassengerType()
        {
            Console.WriteLine("Im a Passenger");
        }
        public int Id { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        


        [StringLength(7)]
        public string PassportNumber { get; set; }

        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set;}

        [MaxLength(25,ErrorMessage ="max 25 carrecter")]
        [MinLength(3,ErrorMessage=" min 3")]
        public string FirstName { get; set; }
        
        


        public string LastName { get; set; }
        public int TelNumber { get; set; }
        [StringLength(8)]
        public virtual ICollection<Flight> flights { get; set; }

    }
}
