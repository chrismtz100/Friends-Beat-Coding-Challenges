using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassesPersonPractice
{
    public class Person //This class/scope can be public to obtain information from
    {
        public string Name; //Fields
        public int Age; //Fields
        public bool HasPet; //Fields

        public Person(string pName, int pAge, bool pHasPet)
        {
            Name = pName;
            Age = pAge;
            HasPet = pHasPet;
        }
        public void Greeting() //Method that returns nothing
        {
            if (HasPet == false)
                Console.WriteLine("Hello! My name is " + this.Name + ". I'm " + Age + " years old. I do not have a pet");
            else if (HasPet == true)
                Console.WriteLine("Hello! My name is " + this.Name + ". I'm " + Age + " years old. I do have a pet");
        }

        public void ChangeName(string newName)
        {
            this.Name = newName;
        }

        public void ChangeAge(int newAge)
        {
            this.Age = newAge;
        }

        public void ChangeHasPet(bool newHasPet)
        {
            this.HasPet = newHasPet;
        }
    }

    class Program //This class just runs
    {
        static void Main(string[] args)
        {
            Person person = new Person("John", 21, false);
            person.Greeting();
            person.ChangeName("Christian Martinez");
            person.ChangeAge(24);
            person.ChangeHasPet(true);
            person.Greeting();
        }
    }
}