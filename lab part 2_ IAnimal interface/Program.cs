using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_part_2__IAnimal_interface
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a dog name: ");
            string dogName = Console.ReadLine();

            Console.WriteLine("Please enter the dog's height: ");
            double dogHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the dog's age: ");
            int dogAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the dog's colour: ");
            string dogColour = Console.ReadLine();

            IAnimal myDog = new Dog(dogName, dogColour, dogAge, dogHeight);

            Console.WriteLine("Your Dog's Name  is " + myDog.Name);
            Console.WriteLine("Colour: " + myDog.Colour);
        }
    }
}
