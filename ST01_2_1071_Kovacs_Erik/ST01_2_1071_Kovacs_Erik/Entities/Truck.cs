using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST01_2_1071_Kovacs_Erik.Entities
{
    [Serializable]
    public class Truck : IComparable<Truck>
    {
        public int Id { get; set; }
        public string LicencePlateNumber { get; set; }
        public DateTime RegistrationDate { get; set; }

        public Truck() 
        {
            RegistrationDate = DateTime.Now;
        }

        public Truck(int id, string licencePlateNumber, DateTime registrationDate) : this()
        {
            Id = id;
            LicencePlateNumber = licencePlateNumber;
            RegistrationDate = registrationDate;
        }

        public int CompareTo(Truck other)
        {
            return LicencePlateNumber.CompareTo(other.LicencePlateNumber);
        }
    }
}
