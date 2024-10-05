using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            string enterStudent = "y";
            bool enterStudentValid = true;
            string studentName = "";
            List<string> studentNames = new List<string>();

            //ask user if they want to enter students
            do
            {

                Console.Write("Do you want to enter student name (y or n) ? ");
                enterStudent = Console.ReadLine();


                if (enterStudent.ToLower() == "y")
                {
                    enterStudentValid = true;
                    Console.Write("Please enter student name: ");
                    studentName = Console.ReadLine();
                    studentNames.Add(studentName);
                    count++;        //increment counter by 1 to account for zero index
                }
                else if (enterStudent.ToLower() == "n")
                {
                    enterStudentValid = false;
                }
                else
                {
                    enterStudentValid = false;
                    while (!enterStudentValid)      //false
                    {
                        Console.Write("Invalid input, please enter y or n: ");
                        enterStudent = Console.ReadLine();

                        if (enterStudent.ToLower() == "y")
                        {
                            enterStudentValid = true;
                            Console.Write("Please enter student name: ");
                            studentName = Console.ReadLine();
                            studentNames.Add(studentName);
                            count++;        //increment counter by 1 to account for zero index
                        }
                        else if (enterStudent.ToLower() == "n")
                        {
                            enterStudentValid = false;
                        }
                    }
                }
                
            } while (enterStudentValid);  //is true



            Console.WriteLine($"Total no of student/s is {count}");  
            //if yes then ask to enter the name of the student
            //if no then exit the program
            Console.ReadLine();
        }
    }
}

/*
 Add students to a class roster until there are no more students.
Then print out the count of students to the console


 
 */
