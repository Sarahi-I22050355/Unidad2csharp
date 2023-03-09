using System;//Console class from the System library
namespace Unidad2csharp
{
    //base Class
    public class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Eat()
        {
            Console.WriteLine("The little animal is eating.");
        }
    }
}
