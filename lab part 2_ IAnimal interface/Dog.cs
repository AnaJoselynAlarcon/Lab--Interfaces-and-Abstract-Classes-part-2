using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_part_2__IAnimal_interface
{
    internal class Dog : IAnimal
    {

        public string Name { get; set; }
        public string Colour { get; set; }
        public int Age { get; set; }
        public double Height { get; set; }


        public Dog(string name, string colour, int age, double height)
        {
            this.Name = name;
            this.Colour = colour;
            this.Age = age;
            this.Height = height;
        }

        public void Eat()
        {
            Console.WriteLine("Dogs eat meat");
        }

        public string Cry()
        {
            return "Woof!";
        }
    }
}
