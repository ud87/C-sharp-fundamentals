using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class PersonModel
    {
        //Below are auto properties
        public string FirstName { private get; set; }  //we can also private get and set it will only be accessible within the local scope
        public string LastName { get; private set; }
        //public int Age { get; set; }

         
        //full property
        private string _password;

        public string Password
        {
            set { _password = value; } //passwords must always be encrypted, we may not need to get the value as _password stores the value
        }

        public string FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }


        private int _age;   //this is called private backing field; underscore and camelcase 

        public int Age
        {
            get     //this is what gets run when we ask 
            { 
                return _age; 
            }
            set 
            { 
                if (value >= 0 && value < 100)
                {
                    _age = value;  
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age needs to be in a valid range.");
                }
            }
        }

        //public string SSN { get; set; }  // Social sec no 123-45-6789
        private string _ssn;

        public string SSN
        {
            get 
            {
                //123-45-6789
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);    //to mask data
                return output; 
            }
            set { _ssn = value; }
        }

        public PersonModel() //we can have same named methods with different values and it will be treated as different values
        {
            
        }

        public PersonModel(string lastName)   //ctor is constructor, special method that gets run when you build a house
        {
            LastName = lastName;
        }
    }


}


/*
 Property allows us to do more with get set i.e. it allows us to protect information
 In classes use auto properties by default. Move to full properties when needed
 
 */