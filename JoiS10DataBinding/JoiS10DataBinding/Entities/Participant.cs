using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiS4WinFormsIntro.Entities
{
    internal class Participant
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime BirthDate { get; set; }


        public Participant(string lastName, string firstName, DateTime birthDate)
        {
            LastName = lastName;
            FirstName = firstName;
            BirthDate = birthDate;
        }
    }
}


