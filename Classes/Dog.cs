using System;//Console class from the System library
namespace Unidad2csharp
{
    // Class that inherits from the base class
    public class Dog : Animal
    {
        public string Breed { get; set; }

        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }
}
