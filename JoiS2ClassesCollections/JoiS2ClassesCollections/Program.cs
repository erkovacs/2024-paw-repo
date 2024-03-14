using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiS2ClassesCollections
{
    internal enum OccupationEnum
    {
        Child = 0,
        Student,
        Employee,
        Professor
    }

    internal enum HTTPRequest
    {
        GET,
        POST,
        PUT,
        PATCH,
        DELETE
    }

    internal class PersonClass
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
            if (value < 0) throw new ArgumentOutOfRangeException("Age cannot be negative!");
            _age = value; // "this._age" is implicit
        }
        #endregion

        #region Name - Using properties
        private string _name;
        //Read/Write property
        public string Name
        {
            get { return _name; }
            set {
                if (value.Equals(string.Empty)) throw new ArgumentOutOfRangeException("Name cannot be empty!");
                _name = value; 
            }
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

        public PersonClass() { _age = 0; }

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
    }

    internal struct PersonStruct
    {
        #region Attributes
        public int Age;
        public string Name;
        public OccupationEnum Occupation;
        #endregion

        public PersonStruct(int age, string name, OccupationEnum occupation)
        {
            Age = age;
            Name = name;
            Occupation = occupation;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1},  Occupation: {2}", Name, Age, Occupation);
        }
    }

    internal class Request
    {
        public Request(HTTPRequest type) { }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var req = new Request(HTTPRequest.GET);

            var person = new PersonClass();
            try
            {
                person.SetAge(-50);
            } catch (Exception e) 
            {
                Console.WriteLine("Error occurred: " + e);
            }
            person.Name = "Erik";

            Console.WriteLine(person);
        }
    }
}
