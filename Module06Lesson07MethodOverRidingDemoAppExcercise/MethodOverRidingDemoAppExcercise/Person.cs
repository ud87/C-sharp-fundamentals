namespace MethodOverRidingDemoAppExcercise
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}";
            
        }
    }
}


/*
Create a person class and override the ToString method in it. 
Make it return the user's first and last name
add a abstract method to the person class then override the method in an employee class which inherits from a person
 */
