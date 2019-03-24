using System;
using MyClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw4_Person_Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person("Nathanael", "Holt", 20, Job.Choreographer),
                new Person("Jabari", "Chapman", 35, Job.Dentist),
                new Person("Oswaldo", "Wilson", 19, Job.Developer),
                new Person("Kody", "Walton", 43, Job.Sculptor),
                new Person("Andreas", "Weeks", 17, Job.Developer),
                new Person("Kayla", "Douglas", 28, Job.Developer),
                new Person("Xander", "Campbell", 19, Job.Waiter),
                new Person("Soren", "Velasquez", 33, Job.Interpreter),
                new Person("August", "Rubio", 21, Job.Developer),
                new Person("Malakai", "Mcgee", 57, Job.Barber),
                new Person("Emerson", "Rollins", 42, Job.Choreographer),
                new Person("Everett", "Parks", 39, Job.Sculptor),
                new Person("Amelia", "Moody", 24, Job.Waiter),
                new Person("Emilie", "Horn", 16, Job.Waiter),
                new Person("Leroy", "Baker", 44, Job.Interpreter),
                new Person("Nathen", "Higgins", 60, Job.Archivist),
                new Person("Erin", "Rocha", 37, Job.Developer),
                new Person("Freddy", "Gordon", 26, Job.Sculptor),
                new Person("Valeria", "Reynolds", 26, Job.Dentist),
                new Person("Cristofer", "Stanley", 28, Job.Dentist)
            };

            var dogs = new List<Dog>()
            {
                new Dog("Charlie", "Black", 3, Race.Collie),
                new Dog("Buddy", "Brown", 1, Race.Doberman),
                new Dog("Max", "Olive", 1, Race.Plott),
                new Dog("Archie", "Black", 2, Race.Mutt),
                new Dog("Oscar", "White", 1, Race.Mudi),
                new Dog("Toby", "Maroon", 3, Race.Bulldog),
                new Dog("Ollie", "Silver", 4, Race.Dalmatian),
                new Dog("Bailey", "White", 4, Race.Pointer),
                new Dog("Frankie", "Gray", 2, Race.Pug),
                new Dog("Jack", "Black", 5, Race.Dalmatian),
                new Dog("Chanel", "Black", 1, Race.Pug),
                new Dog("Henry", "White", 7, Race.Plott),
                new Dog("Bo", "Maroon", 1, Race.Boxer),
                new Dog("Scout", "Olive", 2, Race.Boxer),
                new Dog("Ellie", "Brown", 6, Race.Doberman),
                new Dog("Hank", "Silver", 2, Race.Collie),
                new Dog("Shadow", "Silver", 3, Race.Mudi),
                new Dog("Diesel", "Brown", 1, Race.Bulldog),
                new Dog("Abby", "Black", 1, Race.Dalmatian),
                new Dog("Trixie", "White", 8, Race.Pointer),
            };
            //==============================
            // TODO Homework requirements
            //==============================

            //PART 1
            // 1. Structure the solution (create class library and move classes and enums accordingly)
            // **** Done *****
            //PART 2
            #region 1. Take person Cristofer and add Jack, Ellie and Hank as his dogs.

            var cristofer = people.Last();
            cristofer.Dogs = dogs.Where(d => d.Name == "Jack" || d.Name == "Ellie" || d.Name == "Hank").ToList();
            //Console.WriteLine($"{cristofer.FirstName} is carring the following dogs: ");

            //foreach (var item in cristofer.Dogs)
            //{
            //   Console.WriteLine($" {item.Name}");
            //}

            #endregion
            #region 2. Take person Freddy and add Oscar, Toby, Chanel, Bo and Scout as his dogs.

            var freddy = new Person();
            foreach (var person in people)
            {
                if (person.FirstName == "Freddy")
                {
                    freddy = person;
                }
            }
            freddy.Dogs = dogs.Where(d => d.Name == "Oscar" || d.Name == "Toby" || d.Name == "Bo" || d.Name == "Scout" || d.Name == "Chanel").ToList();
            //Console.WriteLine($"{freddy.FirstName} is taking care for the following dogs: ");

            //foreach (var item in freddy.Dogs)
            //{
            //    Console.WriteLine($" {item.Name}");
            //}

            #endregion
            #region 3. Add Trixie, Archie and Max as dogs from Erin

            var erin = new Person();
            foreach (var person in people)
            {
                if (person.FirstName == "Erin")
                {
                    erin = person;
                }
            }

            erin.Dogs = dogs.Where(d => d.Name == "Trixie" || d.Name == "Archie" || d.Name == "Max").OrderBy(p => p.Name).ToList();
            //Console.WriteLine($"{erin.FirstName} is taking care about the following dogs:");
            //foreach (var item in erin.Dogs)
            //{
            //    Console.WriteLine($"{item.Name} with {item.Color} color and from {item.Race} race.");
            //}

            #endregion
            #region 4. Give Abby and Shadow to Amelia
            var amelia = new Person();
            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].FirstName == "Amelia")
                {
                    amelia = people[i];
                }
            }
            amelia.Dogs = dogs.Where(d => d.Name == "Shadow" || d.Name == "Abby").ToList();
            //Console.WriteLine($"{amelia.FirstName} is taking care about the following dogs:");
            //amelia.printDog();

            #endregion

            //PART 3 - LINQ
            #region 1. Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER

            //var persons = people.Where(p => p.FirstName.StartsWith("A")).OrderByDescending(p => p.Age).Select(p => p.FirstName).ToList();
            //Console.WriteLine(persons.Count);
            //if (persons.Count > 0)
            //{
            //    foreach (var person in persons)
            //        Console.WriteLine(person); 
            //}
            //else
            //{
            //    Console.WriteLine("There is no person with starting `R` in his name");
            //}

            #endregion
            #region 2. Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER

            //var brownDogs = dogs.Where(d => d.Color == "Brown" && d.Age > 3).OrderBy(d => d.Age).Select(d => d.Name);
            //Console.WriteLine("List of brown dogs older than 3 years, ordered by Age - ascending: ");
            //foreach (var name in brownDogs)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion
            #region 3. Find and print all persons with more than 2 dogs, ordered by Name - DESCENDING ORDER

            //var selectedPersons = people.Where(d => d.Dogs.Count > 2).OrderByDescending(d => d.FirstName).ToList();

            //Console.WriteLine("List of people with more than 2 dogs: ");

            //foreach (var person in selectedPersons)
            //{
            //    Console.WriteLine($"{person.FirstName} {person.LastName} has {person.Dogs.Count} dogs");
            //}

            #endregion
            #region  4. Find and print all Freddy`s dogs names older than 1 year

            //var freddiesDogsOlder1Year = freddy.Dogs.Where(d => d.Age > 1).ToList();
            //foreach (var dog in freddiesDogsOlder1Year)
            //{
            //    Console.WriteLine(dog.Name);
            //}

            #endregion
            #region 5. Find and print Nathen`s first dog
            //var firstDog = erin.Dogs.First();
            //Console.WriteLine(firstDog.Name);
            #endregion


            #region 6. Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER.


            //var dogsNames = people.Where(p => p.FirstName == "Cristofer" || p.FirstName == "Freddy" || p.FirstName == "Erin" || p.FirstName == "Amelia")
            //                      .Select(t => t.Dogs.Where(c => c.Color == "Olive")
            //                        .Select(n => n.Name))
            //                      .ToList();          

            //List<string> dogTempList = new List<string>();
            //foreach (var item in dogsNames)  // stringovite od sekoja od listite vo dogNames 
            //{                                  // gi stavame vo lista od stringovi
            //    foreach (var dog in item)
            //    {
            //        dogTempList.Add(dog);
            //    }
            //}
            //var dogListFinal = dogTempList.OrderBy(o => o); // podreduvanje na lista od stringovi
            //foreach (var name in dogListFinal)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            //PART 4 - Be Creative, PLAY with LINQ :) 
                            // :-(
            Console.ReadLine();
        }
    }
}
