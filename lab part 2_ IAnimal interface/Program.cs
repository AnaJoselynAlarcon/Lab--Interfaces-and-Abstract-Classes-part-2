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
            //-----------LIST OF IANIMAL OBJECTS----------
            //List<IAnimal> animals = new List<IAnimal>();
            List<IAnimal> animals = new List<IAnimal>();


            //------------DOG------------
            Console.WriteLine("Please enter a dog name: ");
            string dogName = Console.ReadLine();

            Console.WriteLine("Please enter the dog's height: ");
            double dogHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the dog's age: ");
            int dogAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the dog's colour: ");
            string dogColour = Console.ReadLine();

            IAnimal myDog = new Dog(dogName, dogColour, dogAge, dogHeight);


            //adding object to list
            //animals.Add(myDog);

           
            Console.WriteLine("Your Dog's Name  is " + myDog.Name);
            Console.WriteLine("Colour: " + myDog.Colour);
            Console.WriteLine("Age: " + myDog.Age);
            Console.WriteLine("Height: " + myDog.Height);
            myDog.Eat();
            Console.WriteLine(myDog.Cry());




            //-------CAT---------
            Console.WriteLine("Please enter a cat name: ");
            string catName = Console.ReadLine();

            Console.WriteLine("Please enter the cat's height: ");
            double catHeight = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the cat's age: ");
            int catAge = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the cat's colour: ");
            string catColour = Console.ReadLine();

            IAnimal myCat = new Cat(catName, catColour, catHeight, catAge);

            Console.WriteLine("Your Dog's Name  is " + myCat.Name);
            Console.WriteLine("Colour: " + myCat.Colour);
            Console.WriteLine("Age: " + myCat.Age);
            Console.WriteLine("Height: " + myCat.Height);
            myCat.Eat();
            Console.WriteLine(myCat.Cry());


            // Create a list of animal objects and add some animals to it
            
            animals.Add(myDog);
            animals.Add(myCat);

            // Print the names of all the animals in the list
            Console.WriteLine("List of animal names:");
            foreach (IAnimal animal in animals)
            {
                Console.WriteLine(animal.Name);
            }
            ///// <summary>
            ///// Prints out appliances in list
            ///// </summary>
            ///// <param name="appliances">List of appliances</param>
            ///// <param name="max">Maximum number of appliances to display (0 is unlimited)</param>
            //public void DisplayAppliancesFromList(List<Appliance> appliances, int max)
            //{
            //    if (appliances.Count > 0)
            //    {
            //        Console.WriteLine("Found appliances:");
            //        Console.WriteLine();

            //        // Display found appliances until either end of list is reached or number of appliances requested is shown.
            //        for (int i = 0; i < appliances.Count && (max == 0 || i < max); i++)
            //        {
            //            Appliance appliance = appliances[i];
            //            Console.WriteLine(appliance);
            //            Console.WriteLine();
            //        }

            //    }
            //    else
            //    {
            //        Console.WriteLine("No appliances found.");
            //    }

            //    Console.WriteLine();
        }
    }
}
