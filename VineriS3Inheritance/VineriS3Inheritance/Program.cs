using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineriS3Inheritance
{
    internal enum OccupationEnum
    {
        None = 0,
        Child,
        Student,
        Employee
    }

    internal class PersonClass : 
        IStringable, 
        IComparable<PersonClass>
    {
        #region Properties

        #region Age - Without using Properties
        private int _age;
        public int GetAge()
        {
            return _age; // "this._age" is implicit
        }
        public void SetAge(int value)
        {
            _age = value; // "this._age" is implicit
        }
        #endregion

        #region Name - Using properties
        private string _name;
        //Read/Write property
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        //Readonly property
        public string Name2
        {
            get { return _name; }
        }
        #endregion

        #region Occupation - Using auto-property
        public OccupationEnum Occupation { get; set; }
        #endregion
        #endregion

        public PersonClass()
        { }

        public PersonClass(int age)
        {
            Console.WriteLine("Constructor(default)");
            _age = age; //equivalent with this._age = age;
        }

        public PersonClass(int age, string name, OccupationEnum occupation) : this(age)
        {
            Console.WriteLine("Constructor(parameters)");
            Name = name;
            Occupation = occupation;
        }

        //Copy constructor - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/how-to-write-a-copy-constructor
        public PersonClass(PersonClass previousPerson) : this(previousPerson.GetAge(), previousPerson.Name, previousPerson.Occupation)
        {
            Console.WriteLine("Copy Constructor");
        }

        //Destructor
        ~PersonClass()
        {
            Console.WriteLine("Destructor");
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1},  Occupation: {2}", Name, _age, Occupation);
        }

        public string GetStringRepresentation()
        {
            return ToString();
        }

        public int CompareTo(PersonClass other)
        {
            // return _age - other.GetAge();
            return _age.CompareTo(other.GetAge());
        }
    }

    class Airplane : IStringable, ICloneable
    {
        public string Name { get; set; }
        public double OperationalCeiling { get; set; }

        public List<PersonClass> Passengers { get; set; }

        public Airplane() 
        {
            Name = "Airbus A320";
            OperationalCeiling = 1200.0;
            Passengers = new List<PersonClass>();
        }

        public string GetStringRepresentation()
        {
            var passengersStr = "";
            foreach (var passenger in Passengers)
            {
                passengersStr += passenger.ToString() + '\n';
            }
            return $"Name: {Name}, Operational ceiling: {OperationalCeiling}, Passengers: \n{passengersStr}";
        }

        public object Clone()
        {
            var clone = new Airplane();
            clone.Name = Name;
            clone.OperationalCeiling = OperationalCeiling;
            clone.Passengers = new List<PersonClass>();
            foreach (var person in Passengers)
            {
                clone.Passengers.Add(person);
            }
            return clone;
        }
    }

    interface IStringable 
    {
        string GetStringRepresentation();
    }

    internal class Program
    {
        static void PrintObject(IStringable obj)
        {
            Console.WriteLine(obj.GetStringRepresentation());
        }

        static void PrintObject(object obj)
        {
            Console.WriteLine(obj.ToString());
        }

        static void Main(string[] args)
        {
            var person = new PersonClass();
            person.Name = "bogdan";
            PrintObject(person);

            var persons = new List<PersonClass>();
            persons.Add(person);
            persons.Add(new PersonClass(15, "vasile", OccupationEnum.Child));
            persons.Add(new PersonClass(30, "ana", OccupationEnum.Employee));
            persons.Sort((PersonClass obj1, PersonClass obj2) => obj1.Name.CompareTo(obj2.Name));

            foreach (var pers in persons) 
            {
                PrintObject(pers);
            }

            var airplane = new Airplane();
            airplane.Passengers.Add(person);
            PrintObject(airplane);

            // shallow copy
            var airplane2 = airplane;
            airplane2.Passengers.Add(new PersonClass(25, "ioana", OccupationEnum.Student));

            PrintObject(airplane);
            PrintObject(airplane2);

            // deep copy
            var airplane3 = (Airplane)airplane.Clone();
            // var airplane3 = airplane.Clone() as Airplane;
            airplane3.Passengers.Add(new PersonClass(21, "marius", OccupationEnum.Student));
            PrintObject(airplane);
            PrintObject(airplane2);
            PrintObject(airplane3);

            var clone = airplane3.Clone();
            PrintObject(person);

            Console.ReadLine();
        }
    }
}
