using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineriS6Validation.Entities
{
    public class Participant
    {
        public string LastName { get; set; }
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set {
                if (value.Equals(string.Empty))
                    throw new Exception("bad name");
                _firstName = value;
            }
        }
        public DateTime BirthDate { get; set; }

        public Participant()
        {
            BirthDate = DateTime.Now;
        }
        
        public Participant(string lastName, string firstName, DateTime birthDate) : this()
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }
    }
}
