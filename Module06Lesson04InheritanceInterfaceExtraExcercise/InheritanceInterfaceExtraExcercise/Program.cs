using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceInterfaceExtraExcercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Dog1 = new DogModel
            {
                Name = "Labrador"
            };
            Dog1.Move();

            var Bird1 = new BirdModel
            {
                Name = "Sparrow"
            };
            Bird1.Move();
            
            
            Console.ReadLine();
        }
    }

    public class Animal       //Base class Animal
    {
        public string Name { get; set; }
        public void Eat()
        {
            Console.WriteLine($"{Name} eats.");
        } 
    }

    public interface IMovable      //Interface
    {
        void Move();
    }

    public class DogModel : Animal, IMovable
    {
        public void Move()
        {
            Console.WriteLine($"A {Name} moves by running");
        }
    }

    public class BirdModel : Animal, IMovable
    {
        public void Move()
        {
            Console.WriteLine($"A {Name} moves by flying");
        }
    }
}


/*
 Create Animal Kingdom where different animals share common behaviours but some have unique traits
use interface to define common behavours and inheritance to create a base class for all animals.
 
 */
