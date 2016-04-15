using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemsWK7
{
    public class Person
    {
        public DateTime today = DateTime.Today;
        public string firstName;
        public string lastName;
        public DateTime birthDate = new DateTime();
        public int age;
        public string birthday;

        public Person(string birthday)
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
            birthday = birthDate.ToShortDateString();
            age = today.Year - birthDate.Year;
            if (birthDate.AddYears(age) > today)
            {
                age--;
            }
            Console.WriteLine("Hello {0} {1} born on {2} you are {3} years old",firstName,lastName,birthday,age);
            Console.WriteLine("In the Year " + birthDate.AddYears(this.age) + "you will be" + this.age + "years old");
            Console.ReadKey();
            
        }

        public static Person operator +(Person person, int age)
        {
            Person olderPerson = new Person(person.birthday + person.age);
           person.birthday  = olderPerson.birthday;
            return olderPerson;
        }



        public void In12Years()
        {

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
