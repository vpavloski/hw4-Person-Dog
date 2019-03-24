using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLibrary
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; } = new List<Dog>();

        public Person (string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
        }
        public Person()
        {

        }
        public void printDog()
        {
            foreach (var item in Dogs)
                {
                Console.WriteLine($"{item.Name} with {item.Color} color and from {item.Race} race.");
            }
        }
    }
}
