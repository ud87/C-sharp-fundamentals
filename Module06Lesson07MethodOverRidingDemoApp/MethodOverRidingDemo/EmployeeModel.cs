namespace MethodOverRidingDemo
{
    public class  EmployeeModel : PersonModel
    {
        public decimal HourlyRate { get; set; }
        public virtual decimal GetPaycheckAmount(int hoursWorked) //virtual keyword allows this prop to be overridden
        {
            return HourlyRate * hoursWorked;
        }
    }
}
