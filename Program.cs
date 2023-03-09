using System;//Console class from the System library
using System.Collections.Generic;//List<T> class from the System.Collections.Generic library

namespace Unidad2csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool start = false;

            do
            {
                // We ask the user for the dog's data
                Console.Write("Enter the name of the dog: ");
                string name = Console.ReadLine();

                Console.Write("Enter the breed of the dog: ");
                string breed = Console.ReadLine();

                Console.Write("Enter the age of the dog: ");
                int age = Convert.ToInt32(Console.ReadLine());

                // We create an object of the derived class (Dog)
                Dog myDog = new Dog();
                myDog.Name = name;
                myDog.Age = age;
                myDog.Breed = breed;

                Console.WriteLine("My dog's name is {0}, he is of breed {1} and he is {2} years old.", myDog.Name, myDog.Breed, myDog.Age);
                myDog.Eat(); // We call the method of the base class
                myDog.Bark(); // We call the method of the derived class

                // We create a list of objects of the derived class (Dog)
                List<Dog> DogsList = new List<Dog>();
                DogsList.Add(myDog);

                Console.Write("Do you want to start the program again? (Y/N): ");
                string answer = Console.ReadLine();

                if (answer.ToUpper() == "Y")
                {
                    start = true;
                    Console.Clear();
                }
                else
                {
                    start = false;
                    Console.WriteLine("Good Bye");
                }

            } while (start);
            Console.ReadKey();
        }
    }
}
