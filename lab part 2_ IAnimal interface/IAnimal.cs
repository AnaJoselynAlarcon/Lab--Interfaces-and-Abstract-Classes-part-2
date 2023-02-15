using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_part_2__IAnimal_interface
{
    public interface IAnimal
    {
        //abstract string name;
        string Name { get; set; }
        string Colour { get; set; }
        int Age { get; set; }
        double Height { get; set; }

        void Eat();

        string Cry();
    }
}
