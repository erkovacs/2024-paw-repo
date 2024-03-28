using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiS4WinFormsIntro.Entities
{
    public class Participant
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
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


