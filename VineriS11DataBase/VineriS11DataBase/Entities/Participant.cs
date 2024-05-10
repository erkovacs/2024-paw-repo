using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineriS4WinFormsIntro.Entities
{
    internal class Participant
    {
        public int Id { get; set; }
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


        public Participant(string lastName, string firstName, DateTime birthDate)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }
    }
}
