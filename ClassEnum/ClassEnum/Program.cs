using System;
using System.Linq;


namespace ClassEnum
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Below are the first names of all the students in a class: \n");

            //create new student class object
            Student student = new Student();

            //lets user see names to choose from
            student.PrintClassList();

            Console.Write("\nPlease type in a first name to see the student's last name: ");

            //takes user input and creates string
            string nameEntered = Console.ReadLine();
            Student.FirstName firstName;
            //parses users input to be used in case/switch
            try
            {
                firstName = (Student.FirstName)Enum.Parse(typeof(Student.FirstName), nameEntered);
                Console.Write($"\nThe student's full name is: {nameEntered} ");
                student.LastName(firstName);
            }

            catch (Exception ex)
            {
                Console.WriteLine("\nSorry this name is not in the class list.\n");
                Console.WriteLine(ex.Message);
            }

            //prints student's full name to console
            //firstName = (Student.FirstName)Enum.Parse(typeof(Student.FirstName), nameEntered);
            
            Console.ReadLine();

        }    
     }
  }

