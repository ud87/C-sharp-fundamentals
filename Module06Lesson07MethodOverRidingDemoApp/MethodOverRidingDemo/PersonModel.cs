namespace MethodOverRidingDemo
{
    public class PersonModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }


        //it overrides the method that was there to new method
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
