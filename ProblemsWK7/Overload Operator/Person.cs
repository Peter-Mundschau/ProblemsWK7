using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsWK7
{
    class Person
    {
        public string firstName;
        public string lastName;
        public DateTime birthDate = new DateTime();
        public int age;
        public string birthday;

        public Person(string firstName, string lastName, DateTime birthDate, int age)
        {
           

            this.firstName = firstName;
            this.lastName = lastName;
            this.age = CalculateAge(birthDate);
            this.birthDate = birthDate;
            
        }

        public Person()
        {
        }

        public void EnterBirthdate()
        {
            Console.Write("Please Enter your first name;");
            firstName = Console.ReadLine();
            Console.Write("Please Enter your last name;");
            lastName = Console.ReadLine();
            Console.Write("Please enter your BirthDate(YYYY,MM,DD)");
            birthDate = Convert.ToDateTime(Console.ReadLine());
            
            Console.WriteLine("Hello {0} {1} born on {2} you are {3} years old",firstName,lastName,birthDate,age);

            Console.ReadKey();
            
        }

        private static int CalculateAge(DateTime birthDate)
        {
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;
            if (birthDate.AddYears(age) > today)
            {
                age--;
            }
            return age;
        }

//        Overload Operator
//-    Problem 1: Create a person class that has a first name, last name, age, and birthday.The Person constructor should take in a birthday.  Overload the plus (+) operator to take in a Person and integer and return a Person.The returned Person should display what age they will be 12 years later. 
    }
}
