using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverload
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person = new PersonModel("Udaya", "Rai");     //press ctrl + shift + space for overloads

            person.GenerateEmail("gmail.com", true);

            Console.WriteLine(person.Email);
            
            Console.ReadLine();
        }
    }

    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public PersonModel()
        {
            
        }

        public PersonModel(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            
        }

        public PersonModel(string firstName, string lastName, string email)
        {
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }


        //three different configuration that the generate email can be called so we have different configurations set up
        public void GenerateEmail()
        {
            GenerateEmail("aol.com", false);
        }

        public void GenerateEmail (string domain)
        {
            GenerateEmail(domain, false);
        }

        public void GenerateEmail(bool firstInitialMethod)
        {
            GenerateEmail("aol.com", firstInitialMethod);
        }

        //main method which can be set up as different configuration
        public void GenerateEmail(string domain, bool firstInitialMethod)
        {
            if (firstInitialMethod)
            {
                Email = $"{FirstName.Substring(0, 1)}.{LastName}@{domain}";
            }
            else
            {
                Email = $"{FirstName}.{LastName}@{domain}";
            }
        }

    } 
}


/*
 We can have two methods with same name as long as their signatures are different 
signature line is the name of the method, 
 if we are not careful we will repeat ourselves

overloads makes things easier for the user. Behind the scenes just make sure you keep your code DRY
 */