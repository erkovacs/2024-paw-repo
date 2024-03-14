using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoiS3Inheritance
{
    internal enum OccupationEnum
    {
        Child = 0,
        Student,
        Employee
    }

    internal class PersonClass : IComparable<PersonClass>, ICloneable
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

        public int CompareTo(PersonClass other)
        {
            // return _age - other.GetAge();
            return _age.CompareTo(other.GetAge());
        }

        public object Clone()
        {
            return new PersonClass(this);
        }
    }

    internal class Student : PersonClass, ICloneable
    {
        public List<float> Grades { get; set; }

        public Student() : base(0)
        { 
        }

        public Student(int age) : base(age)
        {
        }

        public Student(int age, List<float> grades) : base(age)
        {
            Grades = grades;
        }

        public object Clone()
        {
            var other = new Student();
            other.SetAge(GetAge());
            other.Name = Name;
            other.Occupation = Occupation;
            other.Grades = new List<float>();
            foreach (var grade in Grades)
            {
                other.Grades.Add(grade);
            }
            return other;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<PersonClass>();
            persons.Add(new PersonClass(10, "zoli", OccupationEnum.Employee));
            persons.Add(new PersonClass(25, "bogdan", OccupationEnum.Child));
            persons.Add(new PersonClass(45, "alex", OccupationEnum.Child));

            persons.Sort(
                (PersonClass o1, PersonClass o2) => { 
                    return o1.Name.CompareTo(o2.Name); 
                });
            // persons.Sort();

            foreach (PersonClass person in persons)
            {
                Console.WriteLine(person.ToString());
            }

            var pers1 = new PersonClass(21, "mihai", OccupationEnum.Student);
            var pers2 = pers1;

            Console.WriteLine(pers1);
            Console.WriteLine(pers2);

            pers2.Name = "vasile";

            Console.WriteLine(pers1);
            Console.WriteLine(pers2);

            // pers2 = (PersonClass)pers2.Clone();
            pers2 = pers1.Clone() as PersonClass;
            pers2.Name = "bogdan";
            
            Console.WriteLine(pers1);
            Console.WriteLine(pers2);

            var stud1 = new Student(21, new List<float> { 10.0f, 10.0f});

        }
    }
}
