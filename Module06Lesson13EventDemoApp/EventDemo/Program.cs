using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CollegeClassModel history = new CollegeClassModel("History 101", 3);
            CollegeClassModel math = new CollegeClassModel("Calculus 201", 2);

            history.EnrollmentFull += CollegeClass_EnrollmentFull;

            history.SignUpStudent("Udaya Rai").PrintToConsole();
            history.SignUpStudent("Sue Storm").PrintToConsole();
            history.SignUpStudent("Joe Walsh").PrintToConsole();
            history.SignUpStudent("John Rey").PrintToConsole();
            history.SignUpStudent("Crate Ras").PrintToConsole();
            history.SignUpStudent("Rashad Ram").PrintToConsole();
            Console.WriteLine();

            math.EnrollmentFull += CollegeClass_EnrollmentFull;

            math.SignUpStudent("Udaya Rai").PrintToConsole();
            math.SignUpStudent("Sue Storm").PrintToConsole();
            math.SignUpStudent("Joe Walsh").PrintToConsole();

            Console.ReadLine();
        }

        private static void CollegeClass_EnrollmentFull(object sender, string e)
        {
            CollegeClassModel model = (CollegeClassModel)sender; //casts CollegeClassModel to sender

            Console.WriteLine();
            Console.WriteLine($"{model.CourseTitle} is Full");
            Console.WriteLine();
        }

    }
}

public static class ConsoleHelpers
{
    public static void PrintToConsole(this string message)
    {
        Console.WriteLine(message);
    }
}

public class CollegeClassModel
{
    public event EventHandler<string> EnrollmentFull;

    private List<string> enrolledStudents = new List<string>();
    private List<string> waitingList = new List<string>();

    public string CourseTitle { get; private set; }
    public int MaximumStudents { get; private set; }

    public CollegeClassModel(string title, int maximumStudents)
    {
        CourseTitle = title;
        MaximumStudents = maximumStudents;
    }

    public string SignUpStudent(string studentName)
    {
        string output = "";

        if (enrolledStudents.Count < MaximumStudents)
        {
            enrolledStudents.Add(studentName);
            output = $"{studentName} was enrolled in {CourseTitle}";
            //Check to see if we are maxed out
            if (enrolledStudents.Count == MaximumStudents)
            {
                EnrollmentFull?.Invoke(this, $"{CourseTitle} enrollment is now full.");
            }
        }
        else
        {
            waitingList.Add(studentName);
            output = $"{studentName} was added to the wait list in {CourseTitle}";
            
        }
        return output;
    }
}



/*
What is an event Listener ?
Event listener listens to changes in state and can reports back so we know state has changed. e.g. if we are loading a lot of data in the background and
wanted to let the user know when done then we can use event listener.

Why do we need event listener ?
Whenever the state of object changes we will need event listener to notify the state has changed.

How do we create an even listener
There is three parts to event handlers. 
Declaration - must be done in class where the model will be invoked, syntax - public EventHandler<type> EventHandlerName
Listener - must be done in Main class, syntax - Object.EventHandlerName += EventHandler_Name
Invokation - must be done inside method where it is to be triggered upon meeting certain condition, syntax EventHandlerName?Invoke(this, message)
 */