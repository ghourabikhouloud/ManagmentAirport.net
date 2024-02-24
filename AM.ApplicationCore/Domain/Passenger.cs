using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        /*  public int PassengerId { get; set; }*/
        [StringLength(7),Key]
        public string PassportNumber { get; set; }
        [MinLength(3),MaxLength(25,ErrorMessage ="Invalid Name length")]
        public string FirstName { get; set; }

        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [DisplayName("Date of Birth")]
        public DateTime BirthDate { get; set; }
        [MinLength(8)]
        public int? TelNumber { get; set; }
        [EmailAddress]
        public string? EmailAddress { get; set; }

        public  IList<Flight> Flights { get; set; }

        public override string ToString()
        {
            return "FirstName: " + FirstName + " LastName: " + LastName + " date of Birth: " + BirthDate;
        }
        //Le polymorphisme par signature

        //1-

        public bool CheckProfile(string firstName, string lastName)
        {
            return FirstName == firstName && LastName == lastName;
        }

        //2-

        public bool CheckProfile(string firstName, string lastName, string email)
        {
            return FirstName == firstName && LastName == lastName && EmailAddress == email;
        }

        // 3- 
        public bool login(string firstName, string lastName, string email = null)
        {
            if (email != null)
                return FirstName == firstName && LastName == lastName && EmailAddress == email;

                return CheckProfile(firstName, lastName);   
        }
        // Polymorphisme par héritge
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a Passenger");
        }
    }
}
