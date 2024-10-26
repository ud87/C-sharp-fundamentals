using DemoLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new DemoLibrary.Models.PersonModel();

            person.FirstName = "Udaya";
            person.LastName = "Rai";

            Console.WriteLine($"{person.FirstName} {person.LastName}");

            Console.ReadLine();
        }
    }
}


/*
 Solution holds multiple projects
Rightclick solution > add > new project > ClassLibrary(.NETFRAMEWORK)    //to create a new project type with in a class library
If we have class library we can move projects to other platforms such as winforms, WPF, etc
Console is a user interface, common convention to write Console as ConsoleUI and class library as Library, for e.g. DemoLibrary, names must be Pascal case
Inside Library it automatically creates class1.cs, delete this so we do not mistakenly rename it

Using statements do not bring in code
References bring in code equivalent to import statement in C++ or C

References > Add Reference > Project > Select the relevant library and tick it 

pdb file is used for debugging when its not in visual studio
demolibrary.dll, class library is built in dll file
we have to add library to ConsoleUI but we cannot add the other way around
we cannot reference a user interface to library but we can add another reference

Class library is a foundation of how we share data

Put all of the code in a class library, then we can use any user interface

Right click setup as a startup project (We cannot do this for class library
 */