using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VineriS2CSharpBasics
{
    internal enum OccupationEnum
    {
        Child = 0,
        Student,
        Employee
    }

    internal enum HttpStatusCode
    {
        Ok = 200,
        Created = 201,
        NotFound = 404,
        InternalServerError = 500
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
            if (value < 0) 
            { 
                throw new ArgumentOutOfRangeException("Age cannot be negative!"); 
            }
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
        // private OccupationEnum _occupation;
        public OccupationEnum Occupation { get; set; }
        /*{ 
            get { return _occupation;  } 
            set { throw new Exception("Test"); } 
        }*/
        #endregion
        #endregion

        public PersonClass() { }

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

    internal class Server
    {
        public void Run() 
        {
            //
        }
    }

    internal class HttpServer : Server
    {
        public HttpServer() { }

        public void Respond(HttpStatusCode code) 
        { 
            //
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            /*Server server = new HttpServer();
            server.Run();

            var person = new PersonStruct();
            Console.WriteLine(person);*/

            /*try 
            {
                var person = new PersonClass();
                person.SetAge(-10);
                person.Name = "erik";
                // person.Occupation = OccupationEnum.Student;
                Console.WriteLine(person);
            } 
            catch (ArgumentOutOfRangeException aoore) 
            { 
                Console.WriteLine("Error occurred: age is incorrect!");
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error occurred: other error!");
            }
            Console.WriteLine("Program executed successfully!");*/

            var person1 = new PersonClass(19, "Denis", OccupationEnum.Student);
            // var person2 = person1;
            var person2 = new PersonClass(person1);
            Console.WriteLine(person1);
            Console.WriteLine(person2);
            person1.Name = "Richard";
            Console.WriteLine(person1);
            Console.WriteLine(person2);
        }
    }
}
